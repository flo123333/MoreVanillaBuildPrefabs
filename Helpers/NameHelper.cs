﻿using System.Text.RegularExpressions;
using UnityEngine;
using MoreVanillaBuildPrefabs.Configs;

namespace MoreVanillaBuildPrefabs.Helpers
{
    internal class NameHelper
    {
        private static readonly Regex PrefabNameRegex = new(@"([a-z])([A-Z])");

        /// <summary>
        ///     Formats the prefab name to something friendlier
        ///     to use as a piece name, or applies a custom name map
        ///     if one exists.
        /// </summary>
        /// <param name="prefabName"></param>
        /// <returns></returns>
        internal static string FormatPrefabName(PieceDB pieceDB)
        {
            if (pieceDB.pieceName != null) return pieceDB.pieceName;

            var name = PrefabNameRegex
                .Replace(pieceDB.name, "$1 $2")
                .TrimStart(' ')
                .Replace('_', ' ')
                .Replace("  ", " ")
                .ToLower()
                .Replace("dverger", "dvergr")
                .Replace("dvergrtown", "dvergr")
                .Replace("dvergrprops", "dvergr")
                .Replace("destructable", "destructible")
                .Replace("rockdolmen", "rock dolmen")
                .Replace("blackmarble", "black marble")
                .Replace("sunkencrypt", "sunken crypt")
                .Replace("irongate", "iron gate")
                .Replace("goblin", "fuling");
            //.Replace("secretdoor", "secret door")
            //.Replace("slidngdoor", "sliding door");

            name = RemovePrefix(name, "piece");

            if (name.EndsWith("destructible"))
            {
                name = string.Concat(
                    RemoveSuffix(name, "destructible").Trim(),
                    " (destructible)"
                );
            }

            if (name.StartsWith("pickable"))
            {
                name = string.Concat(
                    RemovePrefix(name, "pickable").Trim(),
                    " (pickable)"
                );
            }
            return CapitalizeFirstLetter(name);
        }

        internal static string GetPrefabDescription(PieceDB pieceDB)
        {
            if (pieceDB.pieceDesc != null) return pieceDB.pieceDesc;

            return GetPrefabDescription(pieceDB.Prefab);
        }

        internal static string GetPrefabDescription(GameObject prefab)
        {
            HoverText hover = prefab.GetComponent<HoverText>();
            if (hover && !string.IsNullOrEmpty(hover.m_text)) return hover.m_text;

            ItemDrop item = prefab.GetComponent<ItemDrop>();
            if (item && !string.IsNullOrEmpty(item.m_itemData.m_shared.m_name)) return item.m_itemData.m_shared.m_name;

            Character chara = prefab.GetComponent<Character>();
            if (chara && !string.IsNullOrEmpty(chara.m_name)) return chara.m_name;

            RuneStone runestone = prefab.GetComponent<RuneStone>();
            if (runestone && !string.IsNullOrEmpty(runestone.m_name)) return runestone.m_name;

            ItemStand itemStand = prefab.GetComponent<ItemStand>();
            if (itemStand && !string.IsNullOrEmpty(itemStand.m_name)) return itemStand.m_name;

            MineRock mineRock = prefab.GetComponent<MineRock>();
            if (mineRock && !string.IsNullOrEmpty(mineRock.m_name)) return mineRock.m_name;

            Pickable pickable = prefab.GetComponent<Pickable>();
            if (pickable) return GetPrefabDescription(pickable.m_itemPrefab);

            CreatureSpawner creatureSpawner = prefab.GetComponent<CreatureSpawner>();
            if (creatureSpawner) return GetPrefabDescription(creatureSpawner.m_creaturePrefab);

            SpawnArea spawnArea = prefab.GetComponent<SpawnArea>();
            if (spawnArea && spawnArea.m_prefabs.Count > 0)
            {
                return GetPrefabDescription(spawnArea.m_prefabs[0].m_prefab);
            }

            Piece piece = prefab.GetComponent<Piece>();
            if (piece && !string.IsNullOrEmpty(piece.m_name)) return piece.m_name;

            return prefab.name;
        }

        /// <summary>
        ///     Get name of parent prefab by stripping suffix "(Clone)" if nessecary
        /// </summary>
        /// <param name="piece"></param>
        /// <returns></returns>
        internal static string GetPrefabName(Piece piece)
        {
            return RemoveSuffix(piece.gameObject.name, "(Clone)");
        }

        internal static string RemoveSuffix(string s, string suffix)
        {
            if (s.EndsWith(suffix))
            {
                return s.Substring(0, s.Length - suffix.Length);
            }

            return s;
        }

        internal static string RemovePrefix(string s, string prefix)
        {
            if (s.StartsWith(prefix))
            {
                return s.Substring(prefix.Length, s.Length - prefix.Length);
            }
            return s;
        }

        internal static string CapitalizeFirstLetter(string s)
        {
            if (s.Length == 0)
                return s;
            else if (s.Length == 1)
                return $"{char.ToUpper(s[0])}";
            else
                return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}