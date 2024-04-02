using BepInEx.Configuration;
using System;

namespace MVBP.Configs
{
    internal class PrefabDBConfig
    {
        internal ConfigEntry<bool> enabled;
        internal ConfigEntry<bool> allowedInDungeons;
        internal ConfigEntry<string> category;
        internal ConfigEntry<string> craftingStation;
        internal ConfigEntry<string> requirements;
        internal ConfigEntry<bool> placementPatch;
        internal ConfigEntry<bool> clipEverything;
        internal ConfigEntry<bool> clipGround;

        /// <summary>
        ///     Casts config data into the PrefabDB class format.
        /// </summary>
        /// <returns></returns>
        public PrefabDB AsPrefabDB()
        {
            try
            {
                // Get default prefabDB if it exists or make a new blank prefabDB
                string prefabName = this.enabled.Definition.Section;
                PrefabDB prefabDB = PrefabConfigs.GetDefaultPrefabDB(prefabName);
                prefabDB.Update(this);
                return prefabDB;
            }
            catch (Exception ex)
            {
                Log.LogError($"Invalid cast from PrefabDBConfig to PrefabDB: {ex}");
                return null;
            }           
        }
    }
}
