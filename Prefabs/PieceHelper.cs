﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using BepInEx.Configuration;
using Jotunn.Managers;


namespace MoreVanillaBuildPrefabs
{
    internal class PieceHelper
    {   
        /// <summary>
        ///     Get existing objects of type PieceTable.
        /// </summary>
        /// <returns></returns>
        internal static IEnumerable<PieceTable> GetPieceTables()
        {
            return Resources.FindObjectsOfTypeAll<PieceTable>();
        }

        /// <summary>
        ///     Method to get existing piece table.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static PieceTable GetPieceTable(string name)
        {
            var pieceTables = GetPieceTables();
            if (pieceTables != null)
            {
                foreach (var pieceTable in pieceTables)
                {
                    if (pieceTable.name == name) return pieceTable;
                }
            }
            return null;
        }
        
        /// <summary>
        ///     Get HashSet of all piece name attached to existing PieceTable objects.
        /// </summary>
        /// <returns></returns>
        internal static HashSet<string> GetExistingPieceNames()
        {
            var result = GetPieceTables()
                .SelectMany(pieceTable => pieceTable.m_pieces)
                .Select(piece => piece.name);
            return new HashSet<string>(result);

        }

        /// <summary>
        ///     Create and initalize piece component if needed.
        /// </summary>
        /// <param name="prefab"></param>
        internal static void InitPieceComponent(GameObject prefab)
        {
            if (prefab?.GetComponent<Piece>() == null)
            {
                var piece = prefab.AddComponent<Piece>();
                if (piece != null)
                {
                    piece.m_groundOnly = false;
                    piece.m_groundPiece = false;
                    piece.m_cultivatedGroundOnly = false;
                    piece.m_waterPiece = false;
                    piece.m_noInWater = false;
                    piece.m_notOnWood = false;
                    piece.m_notOnTiltingSurface = false;
                    piece.m_inCeilingOnly = false;
                    piece.m_notOnFloor = false;
                    piece.m_onlyInTeleportArea = false;
                    piece.m_allowedInDungeons = false;
                    piece.m_clipEverything = !PrefabDefaults.RestrictClipping.Contains(prefab.name);
                    piece.m_allowRotatedOverlap = true;
                    piece.m_repairPiece = false; // setting this to true breaks a lot of pieces
                    piece.m_canBeRemoved = true;
                    piece.m_onlyInBiome = Heightmap.Biome.None;
                    if (PluginConfig.IsVerbose())
                    {
                        Log.LogInfo($"Creating Piece for: {prefab.name}");
                    }
                }
            }
        }

        /// <summary>
        ///     Method to configure piece fields based on cfg file data.
        /// </summary>
        /// <param name="piece"></param>
        /// <returns></returns>
        internal static Piece ConfigurePiece(
            Piece piece,
            string name,
            string description,
            bool allowedInDungeons,
            string category,
            string craftingStation,
            string requirements,
            Sprite icon
        )
        {
            var pieceCategory = (Piece.PieceCategory)PieceManager.Instance.GetPieceCategory(category);
            var reqs = CreateRequirements(requirements);

            CraftingStation station;
            if (craftingStation == "None")
            {
                station = null;
            }
            else
            {
                var internalName = CraftingStations.GetNames()[craftingStation];
                station = ZNetScene.instance?.GetPrefab(internalName)?.GetComponent<CraftingStation>();
            }
            
            return ConfigurePiece(piece, name, description, allowedInDungeons, pieceCategory, station, reqs, icon);
        }

        /// <summary>
        ///     Method to configure piece fields.
        /// </summary>
        /// <param name="piece"></param>
        /// <returns></returns>
        internal static Piece ConfigurePiece(
            Piece piece, 
            string name, 
            string description, 
            bool allowedInDungeons,
            Piece.PieceCategory category,
            CraftingStation craftingStation,
            Piece.Requirement[] requirements,
            Sprite icon
        )
        {
            piece.m_name = name;
            piece.m_description = description;
            piece.m_allowedInDungeons = allowedInDungeons;
            piece.m_category = category;
            piece.m_craftingStation = craftingStation;
            piece.m_resources = requirements;
            piece.m_icon = icon;
            return piece;
        }

        /// <summary>
        ///     Method to add a piece to a piece table.
        /// </summary>
        /// <param name="piece"></param>
        /// <param name="pieceTable"></param>
        /// <returns> bool indicating if piece was added. </returns>
        internal static bool AddPieceToPieceTable(Piece piece, PieceTable pieceTable)
        {
            if (!piece || !pieceTable || pieceTable.m_pieces == null || pieceTable.m_pieces.Contains(piece.gameObject))
            {
                return false;
            }

            pieceTable.m_pieces.Add(piece.gameObject);
#if DEBUG
            Log.LogInfo($"Added Piece {piece.m_name} to PieceTable {pieceTable.name}");
#endif
            return true;
        }

        static Piece.Requirement[] CreateRequirements(string data)
        {
            if (string.IsNullOrEmpty(data)) return new Piece.Requirement[0];

            // If not empty
            List<Piece.Requirement> requirements = new();

            foreach (var entry in data.Split(';'))
            {
                string[] values = entry.Split(',');

                var itm = PrefabHelper.Cache.GetPrefab(values[0].Trim())?.GetComponent<ItemDrop>();
                if (itm == null)
                {
                    Log.LogWarning($"Invalid build requirement ID: {values[0].Trim()}");
                    continue;
                }
                Piece.Requirement req = new()
                {
                    m_resItem = PrefabHelper.Cache.GetPrefab(values[0].Trim()).GetComponent<ItemDrop>(),
                    m_amount = int.Parse(values[1].Trim()),
                    m_recover = true
                };
                requirements.Add(req);
            }
            return requirements.ToArray();
        }


        /// <summary>
        ///     Helper to get existing crafting station names
        /// </summary>
        public static class CraftingStations
        {
            /// <summary>
            ///     No crafting station
            /// </summary>
            public static string None => string.Empty;

            /// <summary>
            ///    Workbench crafting station
            /// </summary>
            public static string Workbench => "piece_workbench";

            /// <summary>
            ///    Forge crafting station
            /// </summary>
            public static string Forge => "forge";

            /// <summary>
            ///     Stonecutter crafting station
            /// </summary>
            public static string Stonecutter => "piece_stonecutter";

            /// <summary>
            ///     Cauldron crafting station
            /// </summary>
            public static string Cauldron => "piece_cauldron";

            /// <summary>
            ///     Artisan table crafting station
            /// </summary>
            public static string ArtisanTable => "piece_artisanstation";

            /// <summary>
            ///     Black forge crafting station
            /// </summary>
            public static string BlackForge => "blackforge";

            /// <summary>
            ///     Galdr table crafting station
            /// </summary>
            public static string GaldrTable => "piece_magetable";


            private static readonly Dictionary<string, string> NamesMap = new()
            {
                { nameof(None), None },
                { nameof(Workbench), Workbench },
                { nameof(Forge), Forge },
                { nameof(Stonecutter), Stonecutter },
                { nameof(Cauldron), Cauldron },
                { nameof(ArtisanTable), ArtisanTable },
                { nameof(BlackForge), BlackForge },
                { nameof(GaldrTable), GaldrTable },
            };

            private static readonly AcceptableValueList<string> AcceptableValues = new(NamesMap.Keys.ToArray());

            /// <summary>
            ///     Gets the human readable name to internal names map
            /// </summary>
            /// <returns></returns>
            public static Dictionary<string, string> GetNames()
            {
                return NamesMap;
            }

            /// <summary>
            ///     Get a <see cref="AcceptableValueList{T}"/> of all crafting station names.
            ///     This can be used to create a <see cref="ConfigEntry{T}"/> where only valid crafting stations can be selected.<br/><br/>
            ///     Example:
            ///     <code>
            ///         var stationConfig = Config.Bind("Section", "Key", nameof(CraftingStations.Workbench), new ConfigDescription("Description", CraftingStations.GetAcceptableValueList()));
            ///     </code>
            /// </summary>
            /// <returns></returns>
            public static AcceptableValueList<string> GetAcceptableValueList()
            {
                return AcceptableValues;
            }

            /// <summary>
            ///     Get the internal name for a crafting station from its human readable name.
            /// </summary>
            /// <param name="craftingStation"></param>
            /// <returns>
            ///     The matched internal name.
            ///     If the craftingStation parameter is null or empty, <see cref="None"/> is returned.
            ///     Otherwise the unchanged craftingStation parameter is returned.
            /// </returns>
            /// 
            public static string GetInternalName(string craftingStation)
            {
                if (string.IsNullOrEmpty(craftingStation))
                {
                    return None;
                }

                if (NamesMap.TryGetValue(craftingStation, out string internalName))
                {
                    return internalName;
                }

                return craftingStation;
            }
        } // End CraftingStations
    }
}
