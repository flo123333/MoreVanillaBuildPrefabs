﻿using System.Reflection;
using BepInEx;
using HarmonyLib;

namespace MoreVanillaBuildPrefabs
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid, Jotunn.Main.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginName = "MoreVanillaPrefabBuilds";
        internal const string Author = "Searica";
        public const string PluginGuid = $"{Author}.Valheim.{PluginName}";
        public const string PluginVersion = "0.3.3";

        Harmony _harmony;

        public static bool DisableDestructionDrops { get; set; } = false;

        public void Awake()
        {
            Log.Init(Logger);

            PluginConfig.Init(Config);
            PluginConfig.SetUpConfig();

            _harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), harmonyInstanceId: PluginGuid);

            PluginConfig.SetupWatcher();
        }

        public void OnDestroy()
        {
            PluginConfig.Save();
            _harmony?.UnpatchSelf();
        }
    }
}