﻿// Ignore Spelling: MVBP

using System.Collections.Generic;
using Jotunn.Configs;
using UnityEngine;

namespace MVBP.Configs
{
    internal static class PrefabDefaults
    {
        private static readonly HashSet<string> DoNotCacheIcon = new()
        {
            "portal",
            "dvergrprops_wood_floor",
            "dvergrprops_wood_stair",
        };

        internal static bool ShouldCacheIcon(string name) => !DoNotCacheIcon.Contains(name);

        internal static readonly HashSet<string> DvergrWoodPieces = new()
        {
            "dvergrprops_wood_floor",
            "dvergrprops_wood_stair",
        };

        internal static PrefabDB GetDefaultPrefabDB(string prefabName)
        {
            if (DefaultConfigValues.ContainsKey(prefabName))
            {
                return DefaultConfigValues[prefabName];
            }
            return new PrefabDB(prefabName);
        }

        internal static readonly Dictionary<string, PrefabDB> DefaultConfigValues = new()
        {
            {
                "ArmorStand_Female",
                new PrefabDB(
                    name: "ArmorStand_Female",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "FineWood,8;BronzeNails,2;Tar,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceDesc: "",
                    pieceGroup: PieceGroup.ArmorStand
                )
            },
            {
                "ArmorStand_Male",
                new PrefabDB(
                    name: "ArmorStand_Male",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "FineWood,8;BronzeNails,2;Tar,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceDesc: "",
                    pieceGroup: PieceGroup.ArmorStand
                )
            },
            {
                "Ashland_Stair",
                new PrefabDB(
                    name: "Ashland_Stair",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,32",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashland_Steepstair",
                new PrefabDB(
                    name: "Ashland_Steepstair",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "AshlandsBranch1",
                new PrefabDB(
                    name: "AshlandsBranch1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "AshlandsBranch2",
                new PrefabDB(
                    name: "AshlandsBranch2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "AshlandsBranch3",
                new PrefabDB(
                    name: "AshlandsBranch3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "AshlandsBush1",
                new PrefabDB(
                    name: "AshlandsBush1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "AshlandsBush2",
                new PrefabDB(
                    name: "AshlandsBush2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "AshlandsTree1",
                new PrefabDB(
                    name: "AshlandsTree1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    placementOffset: new Vector3(0f, 1f, 0f)
                )
            },
            {
                "AshlandsTree3",
                new PrefabDB(
                    name: "AshlandsTree3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    placementOffset: new Vector3(0f, 1f, 0f)
                )
            },
            {
                "AshlandsTree4",
                new PrefabDB(
                    name: "AshlandsTree4",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "AshlandsTree5",
                new PrefabDB(
                    name: "AshlandsTree5",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    placementOffset: new Vector3(0f, 0.5f, 0f)
                )
            },
            {
                "AshlandsTree6",
                new PrefabDB(
                    name: "AshlandsTree6",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "AshlandsTree6_big",
                new PrefabDB(
                    name: "AshlandsTree6_big",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "AshlandsTreeLog1",
                new PrefabDB(
                    name: "AshlandsTreeLog1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "AshlandsTreeLog2",
                new PrefabDB(
                    name: "AshlandsTreeLog2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "AshlandsTreeLogHalf1",
                new PrefabDB(
                    name: "AshlandsTreeLogHalf1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "AshlandsTreeLogHalf2",
                new PrefabDB(
                    name: "AshlandsTreeLogHalf2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "AshlandsTreeStump1",
                new PrefabDB(
                    name: "AshlandsTreeStump1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "AshlandsTreeStump2",
                new PrefabDB(
                    name: "AshlandsTreeStump2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "AshlandsTreeStump3",
                new PrefabDB(
                    name: "AshlandsTreeStump3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Ashlands_Altar",
                new PrefabDB(
                    name: "Ashlands_Altar",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Arch1",
                new PrefabDB(
                    name: "Ashlands_Arch1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Arch2",
                new PrefabDB(
                    name: "Ashlands_Arch2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Arch2_Broken1",
                new PrefabDB(
                    name: "Ashlands_Arch2_Broken1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Arch2_Broken2",
                new PrefabDB(
                    name: "Ashlands_Arch2_Broken2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_ArchRoof",
                new PrefabDB(
                    name: "Ashlands_ArchRoof",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "Ashlands_ArchRoofDamaged",
                new PrefabDB(
                    name: "Ashlands_ArchRoofDamaged",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_ArchRoofDamaged_half1",
                new PrefabDB(
                    name: "Ashlands_ArchRoofDamaged_half1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_ArchRoofDamaged_half2",
                new PrefabDB(
                    name: "Ashlands_ArchRoofDamaged_half2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_ArchRoofLong_Damaged",
                new PrefabDB(
                    name: "Ashlands_ArchRoofLong_Damaged",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Boss_Pillar",
                new PrefabDB(
                    name: "Ashlands_Boss_Pillar",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "Ashlands_Boss_Pillar_Twist_broken1",
                new PrefabDB(
                    name: "Ashlands_Boss_Pillar_Twist_broken1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Boss_Pillar_Twist_broken2",
                new PrefabDB(
                    name: "Ashlands_Boss_Pillar_Twist_broken2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Boss_Pillar_Twist_broken3",
                new PrefabDB(
                    name: "Ashlands_Boss_Pillar_Twist_broken3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Floor",
                new PrefabDB(
                    name: "Ashlands_Floor",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Fortress_Floor",
                new PrefabDB(
                    name: "Ashlands_Fortress_Floor",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Fortress_Gate",
                new PrefabDB(
                    name: "Ashlands_Fortress_Gate",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,32",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Fortress_Gate_Door",
                new PrefabDB(
                    name: "Ashlands_Fortress_Gate_Door",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "Copper,35",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Fortress_Wall_PillarTopStone_frac",
                new PrefabDB(
                    name: "Ashlands_Fortress_Wall_PillarTopStone_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true,
                    placementOffset: new Vector3(0f, -0.1f, 0f)
                )
            },
            {
                "Ashlands_Fortress_Wall_PillarTop_frac",
                new PrefabDB(
                    name: "Ashlands_Fortress_Wall_PillarTop_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Fortress_Wall_Pillar_frac",
                new PrefabDB(
                    name: "Ashlands_Fortress_Wall_Pillar_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Fortress_Wall_Spikes",
                new PrefabDB(
                    name: "Ashlands_Fortress_Wall_Spikes",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "Copper,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4",
                new PrefabDB(
                    name: "Ashlands_Pillar4",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4_tip",
                new PrefabDB(
                    name: "Ashlands_Pillar4_tip",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4_tip2",
                new PrefabDB(
                    name: "Ashlands_Pillar4_tip2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4_tip2_broken1",
                new PrefabDB(
                    name: "Ashlands_Pillar4_tip2_broken1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4_tip2_broken2",
                new PrefabDB(
                    name: "Ashlands_Pillar4_tip2_broken2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4_tip3",
                new PrefabDB(
                    name: "Ashlands_Pillar4_tip3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4_tip3_broken1",
                new PrefabDB(
                    name: "Ashlands_Pillar4_tip3_broken1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4_tip3_broken2",
                new PrefabDB(
                    name: "Ashlands_Pillar4_tip3_broken2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4_tip3_broken3",
                new PrefabDB(
                    name: "Ashlands_Pillar4_tip3_broken3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4_tip_broken1",
                new PrefabDB(
                    name: "Ashlands_Pillar4_tip_broken1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Pillar4_tip_broken2",
                new PrefabDB(
                    name: "Ashlands_Pillar4_tip_broken2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_PillarBase3_double",
                new PrefabDB(
                    name: "Ashlands_PillarBase3_double",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,3",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ramp",
                new PrefabDB(
                    name: "Ashlands_Ramp",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Floor_1point5x1point5",
                new PrefabDB(
                    name: "Ashlands_Ruins_Floor_1point5x1point5",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Floor_1point5x1point5_broken",
                new PrefabDB(
                    name: "Ashlands_Ruins_Floor_1point5x1point5_broken",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Floor_3x3",
                new PrefabDB(
                    name: "Ashlands_Ruins_Floor_3x3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Floor_3x3_broken1",
                new PrefabDB(
                    name: "Ashlands_Ruins_Floor_3x3_broken1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Floor_3x3_broken2",
                new PrefabDB(
                    name: "Ashlands_Ruins_Floor_3x3_broken2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Floor_3x3_broken3",
                new PrefabDB(
                    name: "Ashlands_Ruins_Floor_3x3_broken3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Floor_6x6",
                new PrefabDB(
                    name: "Ashlands_Ruins_Floor_6x6",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Floor_6x6_broken1",
                new PrefabDB(
                    name: "Ashlands_Ruins_Floor_6x6_broken1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Floor_6x6_broken2",
                new PrefabDB(
                    name: "Ashlands_Ruins_Floor_6x6_broken2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "Ashlands_Ruins_Ramp",
                new PrefabDB(
                    name: "Ashlands_Ruins_Ramp",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Ramp_Upsidedown",
                new PrefabDB(
                    name: "Ashlands_Ruins_Ramp_Upsidedown",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_TopStone",
                new PrefabDB(
                    name: "Ashlands_Ruins_TopStone",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_4x6",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_4x6",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_Broken3_4x6",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_Broken3_4x6",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_Broken4_4x6",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_Broken4_4x6",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_Broken5_4x6",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_Broken5_4x6",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_Top_wHole",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_Top_wHole",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,16",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_Window_4x6_broken2",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_Window_4x6_broken2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_Window_4x6_broken3",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_Window_4x6_broken3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_Window_4x6_broken4",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_Window_4x6_broken4",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_Window_4x6_broken5",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_Window_4x6_broken5",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_Window_4x6_broken6",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_Window_4x6_broken6",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_Wall_Windows_Broken_4x6",
                new PrefabDB(
                    name: "Ashlands_Ruins_Wall_Windows_Broken_4x6",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "Ashlands_Ruins_twist_ArchBig",
                new PrefabDB(
                    name: "Ashlands_Ruins_twist_ArchBig",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_twist_PillarBase",
                new PrefabDB(
                    name: "Ashlands_Ruins_twist_PillarBase",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Ruins_twist_PillarBaseSmall",
                new PrefabDB(
                    name: "Ashlands_Ruins_twist_PillarBaseSmall",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,3",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_StairsBroad",
                new PrefabDB(
                    name: "Ashlands_StairsBroad",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,24",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_WallBlock",
                // This prefab acts as if it does not have correct WearNTear data, so it may have issues.
                new PrefabDB(
                    name: "Ashlands_WallBlock",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_WallBlock_1x2x2",
                new PrefabDB(
                    name: "Ashlands_WallBlock_1x2x2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_WallBlock_base",
                new PrefabDB(
                    name: "Ashlands_WallBlock_base",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,3",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Wall_2x2",
                new PrefabDB(
                    name: "Ashlands_Wall_2x2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Wall_2x2_cornerL",
                new PrefabDB(
                    name: "Ashlands_Wall_2x2_cornerL",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Wall_2x2_cornerL_top",
                new PrefabDB(
                    name: "Ashlands_Wall_2x2_cornerL_top",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Wall_2x2_cornerR",
                new PrefabDB(
                    name: "Ashlands_Wall_2x2_cornerR",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Wall_2x2_cornerR_top",
                new PrefabDB(
                    name: "Ashlands_Wall_2x2_cornerR_top",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Wall_2x2_edge",
                new PrefabDB(
                    name: "Ashlands_Wall_2x2_edge",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Wall_2x2_edge2",
                new PrefabDB(
                    name: "Ashlands_Wall_2x2_edge2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Wall_2x2_edge2_top",
                new PrefabDB(
                    name: "Ashlands_Wall_2x2_edge2_top",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Wall_2x2_edge_top",
                new PrefabDB(
                    name: "Ashlands_Wall_2x2_edge_top",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_Wall_2x2_top",
                new PrefabDB(
                    name: "Ashlands_Wall_2x2_top",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ashlands_floor_large_fractured",
                new PrefabDB(
                    name: "Ashlands_floor_large_fractured",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Beech1",
                new PrefabDB(
                    name: "Beech1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,16",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Beech_Stub",
                new PrefabDB(
                    name: "Beech_Stub",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Beech_small1",
                new PrefabDB(
                    name: "Beech_small1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Beech_small2",
                new PrefabDB(
                    name: "Beech_small2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Birch1",
                new PrefabDB(
                    name: "Birch1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BirchSeeds,1;FineWood,2",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Birch1_aut",
                new PrefabDB(
                    name: "Birch1_aut",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BirchSeeds,1;FineWood,2",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Birch1 (autumn)",
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Birch2",
                new PrefabDB(
                    name: "Birch2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BirchSeeds,1;FineWood,2",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Birch2_aut",
                new PrefabDB(
                    name: "Birch2_aut",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BirchSeeds,1;FineWood,2",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Birch (autumn)",
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "BirchStub",
                new PrefabDB(
                    name: "BirchStub",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Birch_log",
                new PrefabDB(
                    name: "Birch_log",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Birch_log_half",
                new PrefabDB(
                    name: "Birch_log_half",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "BlueberryBush",
                new PrefabDB(
                    name: "BlueberryBush",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Blueberries,5",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Plant
                )
            },
            {
                "BossStone_Bonemass",
                new PrefabDB(
                    name: "BossStone_Bonemass",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true,
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "BossStone_DragonQueen",
                new PrefabDB(
                    name: "BossStone_DragonQueen",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true,
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "BossStone_Eikthyr",
                new PrefabDB(
                    name: "BossStone_Eikthyr",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true,
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "BossStone_Fader",
                new PrefabDB(
                    name: "BossStone_Fader",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "BossStone_TheElder",
                new PrefabDB(
                    name: "BossStone_TheElder",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true,
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "BossStone_TheQueen",
                new PrefabDB(
                    name: "BossStone_TheQueen",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true,
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "BossStone_Yagluth",
                new PrefabDB(
                    name: "BossStone_Yagluth",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true,
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "Bush01",
                new PrefabDB(
                    name: "Bush01",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Bush01_heath",
                new PrefabDB(
                    name: "Bush01_heath",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Bush02_en",
                new PrefabDB(
                    name: "Bush02_en",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "CastleKit_braided_box01",
                new PrefabDB(
                    name: "CastleKit_braided_box01",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Misc,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Wood box",
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "CastleKit_groundtorch",
                new PrefabDB(
                    name: "CastleKit_groundtorch",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Iron,2;Resin,2;SurtlingCore,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Standing iron torch (everburning)",
                    pieceDesc: "Burns eternally without fuel.",
                    pieceGroup: PieceGroup.Torch,
                    playerBasePatch: true
                )
            },
            {
                "CastleKit_groundtorch_blue",
                new PrefabDB(
                    name: "CastleKit_groundtorch_blue",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Iron,2;GreydwarfEye,2;SurtlingCore,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Standing blue-burning iron torch (everburning)",
                    pieceDesc: "Burns eternally without fuel.",
                    pieceGroup: PieceGroup.Torch,
                    playerBasePatch: true
                )
            },
            {
                "CastleKit_groundtorch_green",
                new PrefabDB(
                    name: "CastleKit_groundtorch_green",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Iron,2;Guck,2;SurtlingCore,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Standing green-burning iron torch (everburning)",
                    pieceDesc: "Burns eternally without fuel.",
                    pieceGroup: PieceGroup.Torch,
                    playerBasePatch: true
                )
            },
            {
                "CharredBanner1",
                new PrefabDB(
                    name: "CharredBanner1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "CharredBanner2",
                new PrefabDB(
                    name: "CharredBanner2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "CharredBanner3",
                new PrefabDB(
                    name: "CharredBanner3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Charred_altar_bellfragment",
                new PrefabDB(
                    name: "Charred_altar_bellfragment",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Charredfortress_LOD",
                new PrefabDB(
                    name: "Charredfortress_LOD",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "Chest",
                new PrefabDB(
                    name: "Chest",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,10;Iron,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Chest
                )
            },
            {
                "Cinder",
                new PrefabDB(
                    name: "Cinder",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "CinderSky",
                new PrefabDB(
                    name: "CinderSky",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "CinderStorm",
                new PrefabDB(
                    name: "CinderStorm",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Cinder_campfire",
                new PrefabDB(
                    name: "Cinder_campfire",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "CloudberryBush",
                new PrefabDB(
                    name: "CloudberryBush",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Cloudberry,5",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Plant
                )
            },
            {
                "CreepProp_egg_hanging01",
                new PrefabDB(
                    name: "CreepProp_egg_hanging01",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "CreepProp_egg_hanging02",
                new PrefabDB(
                    name: "CreepProp_egg_hanging02",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "CreepProp_entrance1",
                new PrefabDB(
                    name: "CreepProp_entrance1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,2",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "CreepProp_entrance2",
                new PrefabDB(
                    name: "CreepProp_entrance2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,2",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "CreepProp_hanging01",
                new PrefabDB(
                    name: "CreepProp_hanging01",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "CreepProp_wall01",
                new PrefabDB(
                    name: "CreepProp_wall01",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "FernAshlands",
                new PrefabDB(
                    name: "FernAshlands",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "FernFiddleHeadAshlands",
                new PrefabDB(
                    name: "FernFiddleHeadAshlands",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "FirTree",
                new PrefabDB(
                    name: "FirTree",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,16",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "FirTree_Stub",
                new PrefabDB(
                    name: "FirTree_Stub",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "FirTree_log",
                new PrefabDB(
                    name: "FirTree_log",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "FirTree_log_half",
                new PrefabDB(
                    name: "FirTree_log_half",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "FirTree_oldLog",
                new PrefabDB(
                    name: "FirTree_oldLog",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "FirTree_small",
                new PrefabDB(
                    name: "FirTree_small",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "FirTree_small_dead",
                new PrefabDB(
                    name: "FirTree_small_dead",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Fire",
                new PrefabDB(
                    name: "Fire",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "FireFlies",
                new PrefabDB(
                    name: "FireFlies",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "FlametalRockstand_frac",
                new PrefabDB(
                    name: "FlametalRockstand_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "GlowingMushroom",
                new PrefabDB(
                    name: "GlowingMushroom",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Ooze,1",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "GraveStone_Broken_CharredTwitcherNest",
                new PrefabDB(
                    name: "GraveStone_Broken_CharredTwitcherNest",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "GraveStone_Broken_World",
                new PrefabDB(
                    name: "GraveStone_Broken_World",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "GraveStone_CharredFaderLocation",
                new PrefabDB(
                    name: "GraveStone_CharredFaderLocation",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "GraveStone_CharredTwitcherNest",
                new PrefabDB(
                    name: "GraveStone_CharredTwitcherNest",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "GraveStone_Elite_Broken_CharredTwitcherNest",
                new PrefabDB(
                    name: "GraveStone_Elite_Broken_CharredTwitcherNest",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "GraveStone_Elite_CharredTwitcherNest",
                new PrefabDB(
                    name: "GraveStone_Elite_CharredTwitcherNest",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Greydwarf_Root",
                new PrefabDB(
                    name: "Greydwarf_Root",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "GuckSack",
                new PrefabDB(
                    name: "GuckSack",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Guck,12",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "GuckSack_small",
                new PrefabDB(
                    name: "GuckSack_small",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Guck,6",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "HouseFire",
                new PrefabDB(
                    name: "HouseFire",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "HugeRoot1",
                new PrefabDB(
                    name: "HugeRoot1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "ElderBark,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "IceBlocker",
                new PrefabDB(
                    name: "IceBlocker",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Ice_floor",
                new PrefabDB(
                    name: "Ice_floor",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,16",
                    clipEverything: false,
                    clipGround: true,
                    placementPatch: false
                )
            },
            {
                "LavaRock",
                new PrefabDB(
                    name: "LavaRock",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "Leviathan",
                new PrefabDB(
                    name: "Leviathan",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Chitin,50",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "LeviathanLava",
                new PrefabDB(
                    name: "LeviathanLava",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "LuredWisp",
                new PrefabDB(
                    name: "LuredWisp",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wisp,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "MineRock_Copper",
                new PrefabDB(
                    name: "MineRock_Copper",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,10;CopperOre,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "MineRock_Iron",
                new PrefabDB(
                    name: "MineRock_Iron",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,10;IronScrap,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "MineRock_Meteorite",
                new PrefabDB(
                    name: "MineRock_Meteorite",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "MineRock_Obsidian",
                new PrefabDB(
                    name: "MineRock_Obsidian",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Obsidian,7",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "MineRock_Stone",
                new PrefabDB(
                    name: "MineRock_Stone",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "MineRock_Tin",
                new PrefabDB(
                    name: "MineRock_Tin",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "TinOre,4",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "MountainGraveStone01",
                new PrefabDB(
                    name: "MountainGraveStone01",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "MountainKit_brazier",
                new PrefabDB(
                    name: "MountainKit_brazier",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Bronze,5;Coal,2;BlackCore,1;WolfClaw,3",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Standing brazier (everburning)",
                    pieceDesc: "Burns eternally without fuel.",
                    pieceGroup: PieceGroup.Brazier,
                    playerBasePatch: true
                )
            },
            {
                "MountainKit_brazier_blue",
                new PrefabDB(
                    name: "MountainKit_brazier_blue",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Bronze,5;GreydwarfEye,2;BlackCore,1;WolfClaw,3",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Blue standing brazier (everburning)",
                    pieceDesc: "Burns eternally without fuel.",
                    pieceGroup: PieceGroup.Brazier,
                    playerBasePatch: true
                )
            },
            {
                "MountainKit_brazier_purple",
                new PrefabDB(
                    name: "MountainKit_brazier_purple",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "MountainKit_wood_gate",
                new PrefabDB(
                    name: "MountainKit_wood_gate",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Wood,20;Iron,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Oak1",
                new PrefabDB(
                    name: "Oak1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,20;FineWood,20",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "OakStub",
                new PrefabDB(
                    name: "OakStub",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,5;FineWood,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Oak_log",
                new PrefabDB(
                    name: "Oak_log",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,10;FineWood,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Oak_log_half",
                new PrefabDB(
                    name: "Oak_log_half",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,5;FineWood,5",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Pickable_Ashstone",
                new PrefabDB(
                    name: "Pickable_Ashstone",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_Barley",
                new PrefabDB(
                    name: "Pickable_Barley",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Barley,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.VanillaCrop
                )
            },
            {
                "Pickable_BlackCoreStand",
                new PrefabDB(
                    name: "Pickable_BlackCoreStand",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "Iron,2;BlackCore,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_BogIronOre",
                new PrefabDB(
                    name: "Pickable_BogIronOre",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "IronScrap,1",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "Pickable_Branch",
                new PrefabDB(
                    name: "Pickable_Branch",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Pickable_Carrot",
                new PrefabDB(
                    name: "Pickable_Carrot",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Carrot,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.VanillaCrop
                )
            },
            {
                "Pickable_Charredskull",
                new PrefabDB(
                    name: "Pickable_Charredskull",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_Dandelion",
                new PrefabDB(
                    name: "Pickable_Dandelion",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Dandelion,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Plant
                )
            },
            {
                "Pickable_DolmenTreasure",
                new PrefabDB(
                    name: "Pickable_DolmenTreasure",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Coins,5",
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_DragonEgg",
                new PrefabDB(
                    name: "Pickable_DragonEgg",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "DragonEgg,1",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_DvergrLantern",
                new PrefabDB(
                    name: "Pickable_DvergrLantern",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_DvergrMineTreasure",
                new PrefabDB(
                    name: "Pickable_DvergrMineTreasure",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_DvergrStein",
                new PrefabDB(
                    name: "Pickable_DvergrStein",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_Fiddlehead",
                new PrefabDB(
                    name: "Pickable_Fiddlehead",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_Fishingrod",
                new PrefabDB(
                    name: "Pickable_Fishingrod",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_Flax",
                new PrefabDB(
                    name: "Pickable_Flax",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Flax,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.VanillaCrop
                )
            },
            {
                "Pickable_Flint",
                new PrefabDB(
                    name: "Pickable_Flint",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Flint,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Pickable_ForestCryptRemains01",
                new PrefabDB(
                    name: "Pickable_ForestCryptRemains01",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_ForestCryptRemains02",
                new PrefabDB(
                    name: "Pickable_ForestCryptRemains02",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_ForestCryptRemains03",
                new PrefabDB(
                    name: "Pickable_ForestCryptRemains03",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_ForestCryptRemains04",
                new PrefabDB(
                    name: "Pickable_ForestCryptRemains04",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_Hairstrands01",
                new PrefabDB(
                    name: "Pickable_Hairstrands01",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_Hairstrands02",
                new PrefabDB(
                    name: "Pickable_Hairstrands02",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_Item",
                new PrefabDB(
                    name: "Pickable_Item",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    pieceName: "Coins (pickable)",
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_MeatPile",
                new PrefabDB(
                    name: "Pickable_MeatPile",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_Meteorite",
                new PrefabDB(
                    name: "Pickable_Meteorite",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "Pickable_MoltenCoreStand",
                new PrefabDB(
                    name: "Pickable_MoltenCoreStand",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_MountainCaveCrystal",
                new PrefabDB(
                    name: "Pickable_MountainCaveCrystal",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "Pickable_MountainCaveObsidian",
                new PrefabDB(
                    name: "Pickable_MountainCaveObsidian",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "Pickable_MountainRemains01_buried",
                new PrefabDB(
                    name: "Pickable_MountainRemains01_buried",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_Mushroom",
                new PrefabDB(
                    name: "Pickable_Mushroom",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Mushroom,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Plant
                )
            },
            {
                "Pickable_Mushroom_JotunPuffs",
                new PrefabDB(
                    name: "Pickable_Mushroom_JotunPuffs",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "MushroomJotunPuffs,1",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.VanillaCrop
                )
            },
            {
                "Pickable_Mushroom_Magecap",
                new PrefabDB(
                    name: "Pickable_Mushroom_Magecap",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "MushroomMagecap,1",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.VanillaCrop
                )
            },
            {
                "Pickable_Mushroom_blue",
                new PrefabDB(
                    name: "Pickable_Mushroom_blue",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "MushroomBlue,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Plant
                )
            },
            {
                "Pickable_Mushroom_yellow",
                new PrefabDB(
                    name: "Pickable_Mushroom_yellow",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "MushroomYellow,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Plant
                )
            },
            {
                "Pickable_Obsidian",
                new PrefabDB(
                    name: "Pickable_Obsidian",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Obsidian,1",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "Pickable_Onion",
                new PrefabDB(
                    name: "Pickable_Onion",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Obsidian,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.VanillaCrop
                )
            },
            {
                "Pickable_Pot_Shard",
                new PrefabDB(
                    name: "Pickable_Pot_Shard",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_RoyalJelly",
                new PrefabDB(
                    name: "Pickable_RoyalJelly",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_SeedCarrot",
                new PrefabDB(
                    name: "Pickable_SeedCarrot",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.VanillaCrop
                )
            },
            {
                "Pickable_SeedOnion",
                new PrefabDB(
                    name: "Pickable_SeedOnion",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.VanillaCrop
                )
            },
            {
                "Pickable_SeedTurnip",
                new PrefabDB(
                    name: "Pickable_SeedTurnip",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.VanillaCrop
                )
            },
            {
                "Pickable_SmokePuff",
                new PrefabDB(
                    name: "Pickable_SmokePuff",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_Stone",
                new PrefabDB(
                    name: "Pickable_Stone",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Pickable_SulfurRock",
                new PrefabDB(
                    name: "Pickable_SulfurRock",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_SurtlingCoreStand",
                new PrefabDB(
                    name: "Pickable_SurtlingCoreStand",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Iron,2;SurtlingCore,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Treasure
                )
            },
            {
                "Pickable_Swordpiece1",
                new PrefabDB(
                    name: "Pickable_Swordpiece1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_Swordpiece2",
                new PrefabDB(
                    name: "Pickable_Swordpiece2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_Swordpiece3",
                new PrefabDB(
                    name: "Pickable_Swordpiece3",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Pickable_Tar",
                new PrefabDB(
                    name: "Pickable_Tar",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Tar,1",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Pickable_TarBig",
                new PrefabDB(
                    name: "Pickable_TarBig",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Pickable_Thistle",
                new PrefabDB(
                    name: "Pickable_Thistle",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Thistle,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Plant
                )
            },
            {
                "Pickable_Tin",
                new PrefabDB(
                    name: "Pickable_Tin",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "TinOre,1",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "Pickable_Turnip",
                new PrefabDB(
                    name: "Pickable_Turnip",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Turnip,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.VanillaCrop
                )
            },
            {
                "Pickable_VoltureEgg",
                new PrefabDB(
                    name: "Pickable_VoltureEgg",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "PineTree",
                new PrefabDB(
                    name: "PineTree",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "PineTree_log",
                new PrefabDB(
                    name: "PineTree_log",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,10;RoundLog,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "PineTree_log_half",
                new PrefabDB(
                    name: "PineTree_log_half",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,5;RoundLog,5",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Pinetree_01",
                new PrefabDB(
                    name: "Pinetree_01",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,10;RoundLog,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Pinetree_01_Stub",
                new PrefabDB(
                    name: "Pinetree_01_Stub",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,5;RoundLog,5",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "RaspberryBush",
                new PrefabDB(
                    name: "RaspberryBush",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Raspberry,5",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Plant
                )
            },
            {
                "RockDolmen_1",
                new PrefabDB(
                    name: "RockDolmen_1",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,75",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "RockDolmen_2",
                new PrefabDB(
                    name: "RockDolmen_2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,50",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "RockDolmen_3",
                new PrefabDB(
                    name: "RockDolmen_3",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,75",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "RockFinger",
                new PrefabDB(
                    name: "RockFinger",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,350",
                    clipEverything: true
                )
            },
            {
                "RockFingerBroken",
                new PrefabDB(
                    name: "RockFingerBroken",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,175",
                    clipEverything: true
                )
            },
            {
                "RockFingerBroken_frac",
                new PrefabDB(
                    name: "RockFingerBroken_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,175",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "RockFinger_frac",
                new PrefabDB(
                    name: "RockFinger_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,350",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "RockThumb",
                new PrefabDB(
                    name: "RockThumb",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,200",
                    clipEverything: true
                )
            },
            {
                "RockThumb_frac",
                new PrefabDB(
                    name: "RockThumb_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,200",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Rock_3",
                new PrefabDB(
                    name: "Rock_3",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,24",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "Rock_3_frac",
                new PrefabDB(
                    name: "Rock_3_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,24",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "Rock_4",
                new PrefabDB(
                    name: "Rock_4",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,16",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "Rock_4_plains",
                new PrefabDB(
                    name: "Rock_4_plains",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,24",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "Rock_7",
                new PrefabDB(
                    name: "Rock_7",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "Rock_destructible",
                new PrefabDB(
                    name: "Rock_destructible",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,24",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "Rock_destructible_test",
                new PrefabDB(
                    name: "Rock_destructible_test",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,24",
                    clipEverything: true,
                    clipGround: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "SeekerEgg",
                new PrefabDB(
                    name: "SeekerEgg",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "SeekerEgg_alwayshatch",
                new PrefabDB(
                    name: "SeekerEgg_alwayshatch",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "SeekerQueen_spithit",
                new PrefabDB(
                    name: "SeekerQueen_spithit",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ShootStump",
                new PrefabDB(
                    name: "ShootStump",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "Skull1",
                new PrefabDB(
                    name: "Skull1",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "TrophySkeleton,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Skull2",
                new PrefabDB(
                    name: "Skull2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "StatueCorgi",
                new PrefabDB(
                    name: "StatueCorgi",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,24",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Statue
                )
            },
            {
                "StatueDeer",
                new PrefabDB(
                    name: "StatueDeer",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,24",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Statue
                )
            },
            {
                "StatueEvil",
                new PrefabDB(
                    name: "StatueEvil",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Statue
                )
            },
            {
                "StatueHare",
                new PrefabDB(
                    name: "StatueHare",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,24",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Statue
                )
            },
            {
                "StatueSeed",
                new PrefabDB(
                    name: "StatueSeed",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,16",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Statue
                )
            },
            {
                "SwampTree1",
                new PrefabDB(
                    name: "SwampTree1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "ElderBark,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "SwampTree1_Stub",
                new PrefabDB(
                    name: "SwampTree1_Stub",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "SwampTree1_log",
                new PrefabDB(
                    name: "SwampTree1_log",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "SwampTree2",
                new PrefabDB(
                    name: "SwampTree2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "ElderBark,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "SwampTree2_darkland",
                new PrefabDB(
                    name: "SwampTree2_darkland",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "ElderBark,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "SwampTree2_log",
                new PrefabDB(
                    name: "SwampTree2_log",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "ElderBark,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "TESTTOWER",
                new PrefabDB(
                    name: "TESTTOWER",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "Trailership",
                new PrefabDB(
                    name: "Trailership",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Misc,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "IronNails,100;DeerHide,10;FineWood,40;ElderBark,40",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Trader ship",
                    pieceGroup: PieceGroup.Ship
                    //invWidth: 6,
                    //invHeight: 4
                )
            },
            {
                "TreasureChest_ashland_stone",
                new PrefabDB(
                    name: "TreasureChest_ashland_stone",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Chest,
                    invWidth: 5,
                    invHeight: 2
                )
            },
            {
                "TreasureChest_charredfortress",
                new PrefabDB(
                    name: "TreasureChest_charredfortress",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Chest,
                    invWidth: 8,
                    invHeight: 4
                )
            },
            {
                "TreasureChest_dvergr_loose_stone",
                new PrefabDB(
                    name: "TreasureChest_dvergr_loose_stone",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Black marble chest",
                    pieceGroup: PieceGroup.Chest,
                    invWidth: 8,
                    invHeight: 4
                )
            },
            {
                "TreasureChest_dvergrtower",
                new PrefabDB(
                    name: "TreasureChest_dvergrtower",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,10;Copper,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr chest",
                    pieceGroup: PieceGroup.Chest,
                    invWidth: 7,
                    invHeight: 4
                )
            },
            {
                "TreasureChest_dvergrtown",
                new PrefabDB(
                    name: "TreasureChest_dvergrtown",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,10;Copper,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr chest (large)",
                    pieceGroup: PieceGroup.Chest,
                    invWidth: 8,
                    invHeight: 4
                )
            },
            {
                "TreasureChest_fCrypt",
                new PrefabDB(
                    name: "TreasureChest_fCrypt",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,10;RoundLog,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Stone chest (mossy)",
                    pieceGroup: PieceGroup.Chest,
                    invWidth: 5,
                    invHeight: 2
                )
            },
            {
                "TreasureChest_mountaincave",
                new PrefabDB(
                    name: "TreasureChest_mountaincave",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,10;Crystal,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Stone chest (snow)",
                    pieceGroup: PieceGroup.Chest,
                    invWidth: 6,
                    invHeight: 3
                )
            },
            {
                "TreasureChest_sunkencrypt",
                new PrefabDB(
                    name: "TreasureChest_sunkencrypt",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,10;ElderBark,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Stone chest (dark moss)",
                    pieceGroup: PieceGroup.Chest,
                    invWidth: 5,
                    invHeight: 2
                )
            },
            {
                "TreasureChest_trollcave",
                new PrefabDB(
                    name: "TreasureChest_trollcave",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,10;RoundLog,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Stone chest (mossy, big)",
                    pieceGroup: PieceGroup.Chest,
                    invWidth: 6,
                    invHeight: 3
                )
            },
            {
                "UnstableLavaRock",
                new PrefabDB(
                    name: "UnstableLavaRock",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "VineAsh",
                new PrefabDB(
                    name: "VineAsh",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "YggaShoot1",
                new PrefabDB(
                    name: "YggaShoot1",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,16",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "YggaShoot2",
                new PrefabDB(
                    name: "YggaShoot2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,16",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "YggaShoot3",
                new PrefabDB(
                    name: "YggaShoot3",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,16",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "YggaShoot_small1",
                new PrefabDB(
                    name: "YggaShoot_small1",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "YggdrasilRoot",
                new PrefabDB(
                    name: "YggdrasilRoot",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,64;Sap,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "ancient_skull",
                new PrefabDB(
                    name: "ancient_skull",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BlackMarble,100",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true,
                    spawnOnDestroyed: "sfx_rock_destroyed"
                )
            },
            {
                "ashland_pot1_green",
                new PrefabDB(
                    name: "ashland_pot1_green",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashland_pot1_red",
                new PrefabDB(
                    name: "ashland_pot1_red",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashland_pot2_green",
                new PrefabDB(
                    name: "ashland_pot2_green",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashland_pot2_red",
                new PrefabDB(
                    name: "ashland_pot2_red",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashland_pot3_green",
                new PrefabDB(
                    name: "ashland_pot3_green",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashland_pot3_red",
                new PrefabDB(
                    name: "ashland_pot3_red",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashwood_arch_bottom",
                new PrefabDB(
                    name: "ashwood_arch_bottom",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Blackwood,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashwood_arch_top",
                new PrefabDB(
                    name: "ashwood_arch_top",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Blackwood,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashwood_wall_beam_26_alt",
                new PrefabDB(
                    name: "ashwood_wall_beam_26_alt",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashwood_wall_beam_45_alt",
                new PrefabDB(
                    name: "ashwood_wall_beam_45_alt",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashwood_wall_cross_26_alt",
                new PrefabDB(
                    name: "ashwood_wall_cross_26_alt",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ashwood_wall_cross_45_alt",
                new PrefabDB(
                    name: "ashwood_wall_cross_45_alt",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "asksvin_carrion",
                new PrefabDB(
                    name: "asksvin_carrion",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "asksvin_carrion2",
                new PrefabDB(
                    name: "asksvin_carrion2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "barrell",
                new PrefabDB(
                    name: "barrell",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Misc,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "FineWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Barrel",
                    pieceDesc: "",
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "beech_log",
                new PrefabDB(
                    name: "beech_log",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BeechSeeds,1,Wood,20",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "beech_log_half",
                new PrefabDB(
                    name: "beech_log_half",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BeechSeeds,1,Wood,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "blackmarble_2x2_enforced",
                new PrefabDB(
                    name: "blackmarble_2x2_enforced",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "BlackMarble,8;Copper,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_2x2x1",
                new PrefabDB(
                    name: "blackmarble_2x2x1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_altar_crystal",
                new PrefabDB(
                    name: "blackmarble_altar_crystal",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "blackmarble_altar_crystal_broken",
                new PrefabDB(
                    name: "blackmarble_altar_crystal_broken",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "blackmarble_base_2",
                new PrefabDB(
                    name: "blackmarble_base_2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Black marble plinth (wide)",
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_column_3",
                new PrefabDB(
                    name: "blackmarble_column_3",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,16",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_creep_4x1x1",
                new PrefabDB(
                    name: "blackmarble_creep_4x1x1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_creep_4x2x1",
                new PrefabDB(
                    name: "blackmarble_creep_4x2x1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_creep_slope_inverted_1x1x2",
                new PrefabDB(
                    name: "blackmarble_creep_slope_inverted_1x1x2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_creep_slope_inverted_2x2x1",
                new PrefabDB(
                    name: "blackmarble_creep_slope_inverted_2x2x1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_creep_stair",
                new PrefabDB(
                    name: "blackmarble_creep_stair",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_floor_large",
                new PrefabDB(
                    name: "blackmarble_floor_large",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,32",
                    clipEverything: false,
                    clipGround: true,
                    placementPatch: false,
                    pieceName: "Black marble floor 8x8",
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_head01",
                new PrefabDB(
                    name: "blackmarble_head01",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_head02",
                new PrefabDB(
                    name: "blackmarble_head02",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_head_big01",
                new PrefabDB(
                    name: "blackmarble_head_big01",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_head_big02",
                new PrefabDB(
                    name: "blackmarble_head_big02",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_out_2",
                new PrefabDB(
                    name: "blackmarble_out_2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Black marble cornice (wide)",
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_post01",
                new PrefabDB(
                    name: "blackmarble_post01",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,8",
                    clipEverything: false,
                    clipGround: true,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_slope_1x2",
                new PrefabDB(
                    name: "blackmarble_slope_1x2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_slope_inverted_1x2",
                new PrefabDB(
                    name: "blackmarble_slope_inverted_1x2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_stair_corner",
                new PrefabDB(
                    name: "blackmarble_stair_corner",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_stair_corner_left",
                new PrefabDB(
                    name: "blackmarble_stair_corner_left",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_tile_floor_1x1",
                new PrefabDB(
                    name: "blackmarble_tile_floor_1x1",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_tile_floor_2x2",
                new PrefabDB(
                    name: "blackmarble_tile_floor_2x2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_tile_wall_1x1",
                new PrefabDB(
                    name: "blackmarble_tile_wall_1x1",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_tile_wall_2x2",
                new PrefabDB(
                    name: "blackmarble_tile_wall_2x2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "blackmarble_tile_wall_2x4",
                new PrefabDB(
                    name: "blackmarble_tile_wall_2x4",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "bucket",
                new PrefabDB(
                    name: "bucket",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Misc,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "caverock_ice_pillar_wall",
                new PrefabDB(
                    name: "caverock_ice_pillar_wall",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ice
                )
            },
            {
                "caverock_ice_stalagmite",
                new PrefabDB(
                    name: "caverock_ice_stalagmite",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,2",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ice
                )
            },
            {
                "caverock_ice_stalagmite_broken",
                new PrefabDB(
                    name: "caverock_ice_stalagmite_broken",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ice
                )
            },
            {
                "caverock_ice_stalagtite",
                new PrefabDB(
                    name: "caverock_ice_stalagtite",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ice
                )
            },
            {
                "caverock_ice_stalagtite_falling",
                new PrefabDB(
                    name: "caverock_ice_stalagtite_falling",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ice
                )
            },
            {
                "charred_shieldgenerator",
                new PrefabDB(
                    name: "charred_shieldgenerator",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "cliff_ashlands1_frac",
                new PrefabDB(
                    name: "cliff_ashlands1_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "cliff_ashlands2_frac",
                new PrefabDB(
                    name: "cliff_ashlands2_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "cliff_ashlands4_frac",
                new PrefabDB(
                    name: "cliff_ashlands4_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "cliff_ashlands6_frac",
                new PrefabDB(
                    name: "cliff_ashlands6_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "cliff_ashlands7_HalfArch_frac",
                new PrefabDB(
                    name: "cliff_ashlands7_HalfArch_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "cliff_ashlands_Arch_frac",
                new PrefabDB(
                    name: "cliff_ashlands_Arch_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "cliff_ashlandsflowrock_frac",
                new PrefabDB(
                    name: "cliff_ashlandsflowrock_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "cliff_mistlands1",
                new PrefabDB(
                    name: "cliff_mistlands1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,350",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "cliff_mistlands1_creep",
                new PrefabDB(
                    name: "cliff_mistlands1_creep",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,350",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "cliff_mistlands1_creep_frac",
                new PrefabDB(
                    name: "cliff_mistlands1_creep_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,350",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "cliff_mistlands1_frac",
                new PrefabDB(
                    name: "cliff_mistlands1_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,350",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "cliff_mistlands2",
                new PrefabDB(
                    name: "cliff_mistlands2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,175",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "cliff_mistlands2_frac",
                new PrefabDB(
                    name: "cliff_mistlands2_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,175",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "cloth_hanging_door",
                new PrefabDB(
                    name: "cloth_hanging_door",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Banner
                )
            },
            {
                "cloth_hanging_door_double",
                new PrefabDB(
                    name: "cloth_hanging_door_double",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "JuteRed,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Banner
                )
            },
            {
                "cloth_hanging_long",
                new PrefabDB(
                    name: "cloth_hanging_long",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Banner
                )
            },
            {
                "crypt_skeleton_chest",
                new PrefabDB(
                    name: "crypt_skeleton_chest",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "dead_deer",
                new PrefabDB(
                    name: "dead_deer",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "dungeon_forestcrypt_door",
                new PrefabDB(
                    name: "dungeon_forestcrypt_door",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "dungeon_queen_door",
                new PrefabDB(
                    name: "dungeon_queen_door",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BlackMarble,40;DvergrKeyFragment,4;Iron,12",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "dungeon_sunkencrypt_irongate",
                new PrefabDB(
                    name: "dungeon_sunkencrypt_irongate",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Iron,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Iron
                )
            },
            {
                "dungeon_sunkencrypt_irongate_rusty",
                new PrefabDB(
                    name: "dungeon_sunkencrypt_irongate_rusty",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Iron,4",
                    clipEverything: false,
                    clipGround: true,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Iron
                )
            },
            {
                "dverger_demister",
                new PrefabDB(
                    name: "dverger_demister",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "Iron,1;Wisp,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Torch
                )
            },
            {
                "dverger_demister_broken",
                new PrefabDB(
                    name: "dverger_demister_broken",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "dverger_demister_large",
                new PrefabDB(
                    name: "dverger_demister_large",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "Iron,1;Wisp,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Torch
                )
            },
            {
                "dverger_demister_ruins",
                new PrefabDB(
                    name: "dverger_demister_ruins",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "dverger_guardstone",
                new PrefabDB(
                    name: "dverger_guardstone",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Misc,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,5;BlackMarble,5;BlackCore,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "dvergrprops_banner",
                new PrefabDB(
                    name: "dvergrprops_banner",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "JuteBlue,6;FineWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Banner
                )
            },
            {
                "dvergrprops_barrel",
                new PrefabDB(
                    name: "dvergrprops_barrel",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "YggdrasilWood,20;Bronze,5;Resin,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrprops_bed",
                new PrefabDB(
                    name: "dvergrprops_bed",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,8;ScaleHide,2;IronNails,5",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Bed,
                    playerBasePatch: true
                )
            },
            {
                "dvergrprops_chair",
                new PrefabDB(
                    name: "dvergrprops_chair",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Chair
                )
            },
            {
                "dvergrprops_crate",
                new PrefabDB(
                    name: "dvergrprops_crate",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Misc,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "dvergrprops_crate_ashlands",
                new PrefabDB(
                    name: "dvergrprops_crate_ashlands",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "dvergrprops_crate_long",
                new PrefabDB(
                    name: "dvergrprops_crate_long",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Misc,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr component crate",
                    pieceDesc: "",
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "dvergrprops_curtain",
                new PrefabDB(
                    name: "dvergrprops_curtain",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "JuteBlue,6;FineWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Banner
                )
            },
            {
                "dvergrprops_hooknchain",
                new PrefabDB(
                    name: "dvergrprops_hooknchain",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "Chain,2;Iron,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr hook & chain",
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "dvergrprops_lantern_standing",
                new PrefabDB(
                    name: "dvergrprops_lantern_standing",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrprops_pickaxe",
                new PrefabDB(
                    name: "dvergrprops_pickaxe",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    placementOffset: new Vector3(-1f, 0f, 0f),
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrprops_shelf",
                new PrefabDB(
                    name: "dvergrprops_shelf",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,4;IronNails,5",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrprops_stool",
                new PrefabDB(
                    name: "dvergrprops_stool",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Chair
                )
            },
            {
                "dvergrprops_table",
                new PrefabDB(
                    name: "dvergrprops_table",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,6;IronNails,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Table
                )
            },
            {
                "dvergrprops_wood_beam",
                new PrefabDB(
                    name: "dvergrprops_wood_beam",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrprops_wood_floor",
                new PrefabDB(
                    name: "dvergrprops_wood_floor",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrprops_wood_pole",
                new PrefabDB(
                    name: "dvergrprops_wood_pole",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr wood pole (large)",
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrprops_wood_stair",
                new PrefabDB(
                    name: "dvergrprops_wood_stair",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrprops_wood_stakewall",
                new PrefabDB(
                    name: "dvergrprops_wood_stakewall",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrprops_wood_wall",
                new PrefabDB(
                    name: "dvergrprops_wood_wall",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr wood wall 4x4",
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_arch",
                new PrefabDB(
                    name: "dvergrtown_arch",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "BlackMarble,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_creep_door",
                new PrefabDB(
                    name: "dvergrtown_creep_door",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Door hanging (creep)",
                    pieceDesc: "",
                    pieceGroup: PieceGroup.Misc
                )
            },
            {
                "dvergrtown_secretdoor",
                new PrefabDB(
                    name: "dvergrtown_secretdoor",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "BlackMarble,12;Eitr,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr secret door",
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_slidingdoor",
                new PrefabDB(
                    name: "dvergrtown_slidingdoor",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "BlackMarble,32;Copper,8",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr sliding door",
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_stair_corner_wood_left",
                new PrefabDB(
                    name: "dvergrtown_stair_corner_wood_left",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,5;CopperScrap,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_wood_beam",
                new PrefabDB(
                    name: "dvergrtown_wood_beam",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr wood beam (creep)",
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_wood_crane",
                new PrefabDB(
                    name: "dvergrtown_wood_crane",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,8;Chain,2;Iron,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_wood_pole",
                new PrefabDB(
                    name: "dvergrtown_wood_pole",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr wood pole (creep)",
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_wood_stake",
                new PrefabDB(
                    name: "dvergrtown_wood_stake",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_wood_stakewall",
                new PrefabDB(
                    name: "dvergrtown_wood_stakewall",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_wood_support",
                new PrefabDB(
                    name: "dvergrtown_wood_support",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_wood_wall01",
                new PrefabDB(
                    name: "dvergrtown_wood_wall01",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,20",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_wood_wall02",
                new PrefabDB(
                    name: "dvergrtown_wood_wall02",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,12",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "dvergrtown_wood_wall03",
                new PrefabDB(
                    name: "dvergrtown_wood_wall03",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,10;IronNails,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "fader_bellholder",
                new PrefabDB(
                    name: "fader_bellholder",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "fenrirhide_hanging",
                new PrefabDB(
                    name: "fenrirhide_hanging",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "WolfHairBundle,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "fenrirhide_hanging_door",
                new PrefabDB(
                    name: "fenrirhide_hanging_door",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "WolfHairBundle,2"
                )
            },
            {
                "fire_pit_haldor",
                new PrefabDB(
                    name: "fire_pit_haldor",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Misc,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,5;Wood,2;BlackCore,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Campfire (everburning)",
                    pieceDesc: "Burns eternally without fuel.",
                    pieceGroup: PieceGroup.Fire
                )
            },
            {
                "fire_pit_hildir",
                new PrefabDB(
                    name: "fire_pit_hildir",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Misc,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Ironpit,1;Wood,1;BlackCore,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Firepit iron (everburning)",
                    pieceDesc: "Burns eternally without fuel.",
                    pieceGroup: PieceGroup.Fire
                )
            },
            {
                "flying_core",
                new PrefabDB(
                    name: "flying_core",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,24",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    spawnOnDestroyed: "fx_crystal_destruction"
                )
            },
            {
                "fuling_trap",
                new PrefabDB(
                    name: "fuling_trap",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "giant_arm",
                new PrefabDB(
                    name: "giant_arm",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BlackMarble,32",
                    clipEverything: true
                )
            },
            {
                "giant_brain",
                new PrefabDB(
                    name: "giant_brain",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Softtissue,64",
                    clipEverything: true
                )
            },
            {
                "giant_brain_frac",
                new PrefabDB(
                    name: "giant_brain_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Softtissue,64",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "giant_helmet1",
                new PrefabDB(
                    name: "giant_helmet1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Iron,32",
                    clipEverything: true
                )
            },
            {
                "giant_helmet1_destruction",
                new PrefabDB(
                    name: "giant_helmet1_destruction",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Iron,24",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "giant_helmet2",
                new PrefabDB(
                    name: "giant_helmet2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Iron,32",
                    clipEverything: true
                )
            },
            {
                "giant_helmet2_destruction",
                new PrefabDB(
                    name: "giant_helmet2_destruction",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Iron,24",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "giant_ribs",
                new PrefabDB(
                    name: "giant_ribs",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BlackMarble,64",
                    clipEverything: true
                )
            },
            {
                "giant_ribs_frac",
                new PrefabDB(
                    name: "giant_ribs_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BlackMarble,64",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "giant_skull",
                new PrefabDB(
                    name: "giant_skull",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BlackMarble,32",
                    clipEverything: true
                )
            },
            {
                "giant_skull_frac",
                new PrefabDB(
                    name: "giant_skull_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BlackMarble,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "giant_sword1",
                new PrefabDB(
                    name: "giant_sword1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Iron,16",
                    clipEverything: true
                )
            },
            {
                "giant_sword1_destruction",
                new PrefabDB(
                    name: "giant_sword1_destruction",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Iron,16",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "giant_sword2",
                new PrefabDB(
                    name: "giant_sword2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Iron,16",
                    clipEverything: true
                )
            },
            {
                "giant_sword2_destruction",
                new PrefabDB(
                    name: "giant_sword2_destruction",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Iron,16",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "goblin_banner",
                new PrefabDB(
                    name: "goblin_banner",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,1;DeerHide,1;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Banner
                )
            },
            {
                "goblin_bed",
                new PrefabDB(
                    name: "goblin_bed",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,8;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Bed,
                    playerBasePatch: true
                )
            },
            {
                "goblin_fence",
                new PrefabDB(
                    name: "goblin_fence",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,2;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_pole",
                new PrefabDB(
                    name: "goblin_pole",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,1;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_pole_small",
                new PrefabDB(
                    name: "goblin_pole_small",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,1;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_roof_45d",
                new PrefabDB(
                    name: "goblin_roof_45d",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,1;DeerHide,1;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_roof_45d_corner",
                new PrefabDB(
                    name: "goblin_roof_45d_corner",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,1;DeerHide,1;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_roof_cap",
                new PrefabDB(
                    name: "goblin_roof_cap",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,4;DeerHide,4;Tar,1",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_stairs",
                new PrefabDB(
                    name: "goblin_stairs",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,2;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_stepladder",
                new PrefabDB(
                    name: "goblin_stepladder",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,2;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_strawpile",
                new PrefabDB(
                    name: "goblin_strawpile",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Rug straw (large)",
                    pieceDesc: "",
                    pieceGroup: PieceGroup.Rug
                )
            },
            {
                "goblin_totempole",
                new PrefabDB(
                    name: "goblin_totempole",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,2;GoblinTotem,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_trashpile",
                new PrefabDB(
                    name: "goblin_trashpile",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_woodwall_1m",
                new PrefabDB(
                    name: "goblin_woodwall_1m",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,1;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_woodwall_2m",
                new PrefabDB(
                    name: "goblin_woodwall_2m",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,2;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblin_woodwall_2m_ribs",
                new PrefabDB(
                    name: "goblin_woodwall_2m_ribs",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BoneFragments,6;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "goblinking_totemholder",
                new PrefabDB(
                    name: "goblinking_totemholder",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,1;Tar,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Goblin
                )
            },
            {
                "hanging_hairstrands",
                new PrefabDB(
                    name: "hanging_hairstrands",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "highstone",
                new PrefabDB(
                    name: "highstone",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,32",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "highstone_frac",
                new PrefabDB(
                    name: "highstone_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "ice1",
                new PrefabDB(
                    name: "ice1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "ice_rock1",
                new PrefabDB(
                    name: "ice_rock1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,32",
                    clipEverything: true
                )
            },
            {
                "ice_rock1_frac",
                new PrefabDB(
                    name: "ice_rock1_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "iron_floor_1x1",
                new PrefabDB(
                    name: "iron_floor_1x1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "iron_wall_1x1_rusty",
                new PrefabDB(
                    name: "iron_wall_1x1_rusty",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Iron,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Iron
                )
            },
            {
                "lavabomb_rock1",
                new PrefabDB(
                    name: "lavabomb_rock1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "lightningAOE",
                new PrefabDB(
                    name: "lightningAOE",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "loot_chest_stone",
                new PrefabDB(
                    name: "loot_chest_stone",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Stone chest (light moss)",
                    pieceGroup: PieceGroup.Chest,
                    invWidth: 5,
                    invHeight: 2
                )
            },
            {
                "lox_ribs",
                new PrefabDB(
                    name: "lox_ribs",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "BoneFragments,30",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "marker01",
                new PrefabDB(
                    name: "marker01",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "marker02",
                new PrefabDB(
                    name: "marker02",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "metalbar_1x2",
                new PrefabDB(
                    name: "metalbar_1x2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "BlackMarble,2;Copper,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Black marble 1x2 enforced",
                    pieceDesc: "",
                    pieceGroup: PieceGroup.BlackMarble
                )
            },
            {
                "mistvolume",
                new PrefabDB(
                    name: "mistvolume",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Eitr,10;Wisp,4",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Mist volume",
                    pieceDesc: "Warning: requires devcommands to remove."
                )
            },
            {
                "morgenhole_pile",
                new PrefabDB(
                    name: "morgenhole_pile",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "mountainkit_chair",
                new PrefabDB(
                    name: "mountainkit_chair",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "FineWood,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Chair
                )
            },
            {
                "mountainkit_table",
                new PrefabDB(
                    name: "mountainkit_table",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "FineWood,10;IronNails,20",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Table
                )
            },
            {
                "mudpile",
                new PrefabDB(
                    name: "mudpile",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "IronScrap,10"
                )
            },
            {
                "mudpile2",
                new PrefabDB(
                    name: "mudpile2",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "IronScrap,10",
                    clipEverything: true
                )
            },
            {
                "mudpile2_frac",
                new PrefabDB(
                    name: "mudpile2_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "IronScrap,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "mudpile_beacon",
                new PrefabDB(
                    name: "mudpile_beacon",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: ""
                )
            },
            {
                "mudpile_frac",
                new PrefabDB(
                    name: "mudpile_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "IronScrap,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "mudpile_old",
                new PrefabDB(
                    name: "mudpile_old",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "IronScrap,10"
                )
            },
            {
                "piece_Charred_Balista",
                new PrefabDB(
                    name: "piece_Charred_Balista",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "piece_blackwood_bench",
                new PrefabDB(
                    name: "piece_blackwood_bench",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Blackwood,6",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "piece_dvergr_pole",
                new PrefabDB(
                    name: "piece_dvergr_pole",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr wood pole",
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "piece_dvergr_wood_door",
                new PrefabDB(
                    name: "piece_dvergr_wood_door",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,16;IronNails,24",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "piece_dvergr_wood_wall",
                new PrefabDB(
                    name: "piece_dvergr_wood_wall",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "YggdrasilWood,5",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Dvergr
                )
            },
            {
                "piece_pot1_cracked",
                new PrefabDB(
                    name: "piece_pot1_cracked",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "piece_pot1_red",
                new PrefabDB(
                    name: "piece_pot1_red",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "piece_pot2_cracked",
                new PrefabDB(
                    name: "piece_pot2_cracked",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "piece_pot2_red",
                new PrefabDB(
                    name: "piece_pot2_red",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "piece_pot3_cracked",
                new PrefabDB(
                    name: "piece_pot3_cracked",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "piece_pot3_red",
                new PrefabDB(
                    name: "piece_pot3_red",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "portal",
                new PrefabDB(
                    name: "portal",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Misc,
                    craftingStation: nameof(CraftingStations.GaldrTable),
                    requirements: "GreydwarfEye,10;Stone,20;BlackCore,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Dvergr portal",
                    pieceDesc: "Connects another portal with equal or no tag.",
                    pieceGroup: PieceGroup.Portal
                )
            },
            {
                "rock1_mistlands",
                new PrefabDB(
                    name: "rock1_mistlands",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    pieceName: "Rock (large boulder)",
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock1_mountain",
                new PrefabDB(
                    name: "rock1_mountain",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock1_mountain_frac",
                new PrefabDB(
                    name: "rock1_mountain_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,350",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock2_heath",
                new PrefabDB(
                    name: "rock2_heath",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock2_heath_frac",
                new PrefabDB(
                    name: "rock2_heath_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock2_mountain",
                new PrefabDB(
                    name: "rock2_mountain",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,64",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock2_mountain_frac",
                new PrefabDB(
                    name: "rock2_mountain_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,64",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock3_ice",
                new PrefabDB(
                    name: "rock3_ice",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,32",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock3_ice_frac",
                new PrefabDB(
                    name: "rock3_ice_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Crystal,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock3_mountain",
                new PrefabDB(
                    name: "rock3_mountain",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,100",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock3_mountain_frac",
                new PrefabDB(
                    name: "rock3_mountain_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,100",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock3_silver",
                new PrefabDB(
                    name: "rock3_silver",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,64;SilverOre,32",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "rock3_silver_frac",
                new PrefabDB(
                    name: "rock3_silver_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,64;SilverOre,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "rock4_ashlands_frac",
                new PrefabDB(
                    name: "rock4_ashlands_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "rock4_coast",
                new PrefabDB(
                    name: "rock4_coast",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,64",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock4_coast_frac",
                new PrefabDB(
                    name: "rock4_coast_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,64",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock4_copper",
                new PrefabDB(
                    name: "rock4_copper",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,64;CopperOre,32",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "rock4_copper_frac",
                new PrefabDB(
                    name: "rock4_copper_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: true,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "rock4_forest",
                new PrefabDB(
                    name: "rock4_forest",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,64",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock4_forest_frac",
                new PrefabDB(
                    name: "rock4_forest_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,64",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock4_heath",
                new PrefabDB(
                    name: "rock4_heath",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,32",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock4_heath_frac",
                new PrefabDB(
                    name: "rock4_heath_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock_mistlands1",
                new PrefabDB(
                    name: "rock_mistlands1",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,48",
                    clipEverything: true,
                    pieceName: "Rock (black)",
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock_mistlands1_frac",
                new PrefabDB(
                    name: "rock_mistlands1_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,48",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Rock (black)",
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "rock_mistlands2",
                new PrefabDB(
                    name: "rock_mistlands2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,48",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Rock (black, alt)",
                    pieceGroup: PieceGroup.Rock,
                    spawnOnDestroyed: "sfx_rock_destroyed"
                )
            },
            {
                "rockformation1",
                new PrefabDB(
                    name: "rockformation1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,350",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "root07",
                new PrefabDB(
                    name: "root07",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "ElderBark,2",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "root08",
                new PrefabDB(
                    name: "root08",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "ElderBark,4",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "root11",
                new PrefabDB(
                    name: "root11",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "ElderBark,4",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "root12",
                new PrefabDB(
                    name: "root12",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "ElderBark,4",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "rug_straw",
                new PrefabDB(
                    name: "rug_straw",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,2",
                    clipEverything: false,
                    clipGround: false,
                    pieceGroup: PieceGroup.Rug
                )
            },
            {
                "shieldgenerator_attack",
                new PrefabDB(
                    name: "shieldgenerator_attack",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "shipwreck_karve_bottomboards",
                new PrefabDB(
                    name: "shipwreck_karve_bottomboards",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "FineWood,8",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "shipwreck_karve_bow",
                new PrefabDB(
                    name: "shipwreck_karve_bow",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "FineWood,16",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "shipwreck_karve_dragonhead",
                new PrefabDB(
                    name: "shipwreck_karve_dragonhead",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "FineWood,8",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    placementOffset: new Vector3(0f, -1.5f, 6f)
                )
            },
            {
                "shipwreck_karve_stern",
                new PrefabDB(
                    name: "shipwreck_karve_stern",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "FineWood,16",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "shipwreck_karve_sternpost",
                new PrefabDB(
                    name: "shipwreck_karve_sternpost",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "FineWood,10",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "shrub_2",
                new PrefabDB(
                    name: "shrub_2",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "shrub_2_heath",
                new PrefabDB(
                    name: "shrub_2_heath",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "siege_wall_1x1",
                new PrefabDB(
                    name: "siege_wall_1x1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Grausten,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "sign_notext",
                new PrefabDB(
                    name: "sign_notext",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Wood plank",
                    pieceDesc: "",
                    pieceGroup: PieceGroup.Wood
                )
            },
            {
                "silvervein",
                new PrefabDB(
                    name: "silvervein",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,50;SilverOre,50",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "silvervein_frac",
                new PrefabDB(
                    name: "silvervein_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,50;SilverOre,50",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Ore
                )
            },
            {
                "smokebomb_explosion",
                new PrefabDB(
                    name: "smokebomb_explosion",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "stone_floor",
                new PrefabDB(
                    name: "stone_floor",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,16",
                    clipEverything: false,
                    clipGround: true,
                    placementPatch: false,
                    pieceName: "Stone floor 4x4",
                    pieceGroup: PieceGroup.Stone
                )
            },
            {
                "stoneblock_fracture",
                new PrefabDB(
                    name: "stoneblock_fracture",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Stonecutter,
                    craftingStation: nameof(CraftingStations.Stonecutter),
                    requirements: "Stone,16",
                    clipEverything: false,
                    clipGround: true,
                    placementPatch: false,
                    pieceName: "Stone floor 4x4 (2)",
                    pieceGroup: PieceGroup.Stone
                )
            },
            {
                "stubbe",
                new PrefabDB(
                    name: "stubbe",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "stubbe_spawner",
                new PrefabDB(
                    name: "stubbe_spawner",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "sunken_crypt_gate",
                new PrefabDB(
                    name: "sunken_crypt_gate",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Forge),
                    requirements: "Iron,4",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Iron
                )
            },
            {
                "tarlump1",
                new PrefabDB(
                    name: "tarlump1",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Tar,50",
                    clipEverything: true,
                    clipGround: false,
                    pieceName: "Crystallized tar",
                    pieceDesc: "Warning: requires devcommands to remove"
                )
            },
            {
                "tarlump1_frac",
                new PrefabDB(
                    name: "tarlump1_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Tar,50",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceName: "Crystallized tar"
                )
            },
            {
                "trader_wagon_destructable",
                new PrefabDB(
                    name: "trader_wagon_destructable",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Furniture,
                    craftingStation: nameof(CraftingStations.BlackForge),
                    requirements: "FineWood,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "tunnel_web",
                new PrefabDB(
                    name: "tunnel_web",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "turf_roof",
                new PrefabDB(
                    name: "turf_roof",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Wood
                )
            },
            {
                "turf_roof_top",
                new PrefabDB(
                    name: "turf_roof_top",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Wood
                )
            },
            {
                "veg_skull_Ashlands",
                new PrefabDB(
                    name: "veg_skull_Ashlands",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: true
                )
            },
            {
                "vertical_web",
                new PrefabDB(
                    name: "vertical_web",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "vines",
                new PrefabDB(
                    name: "vines",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Wood,2",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "volture_strawpile",
                new PrefabDB(
                    name: "volture_strawpile",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false
                )
            },
            {
                "widestone",
                new PrefabDB(
                    name: "widestone",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,32",
                    clipEverything: true,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "widestone_frac",
                new PrefabDB(
                    name: "widestone_frac",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.CreatorShop,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "Stone,32",
                    clipEverything: true,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Rock
                )
            },
            {
                "wood_ledge",
                new PrefabDB(
                    name: "wood_ledge",
                    enabled: true,
                    allowedInDungeons: false,
                    category: HammerCategories.Building,
                    craftingStation: nameof(CraftingStations.Workbench),
                    requirements: "Wood,1",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Wood
                )
            },
            {
                "yggashoot_log",
                new PrefabDB(
                    name: "yggashoot_log",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
            {
                "yggashoot_log_half",
                new PrefabDB(
                    name: "yggashoot_log_half",
                    enabled: false,
                    allowedInDungeons: false,
                    category: HammerCategories.Nature,
                    craftingStation: nameof(CraftingStations.None),
                    requirements: "YggdrasilWood,10",
                    clipEverything: false,
                    clipGround: false,
                    placementPatch: false,
                    pieceGroup: PieceGroup.Flora
                )
            },
        };
    }
}
