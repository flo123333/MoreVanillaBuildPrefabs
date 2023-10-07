# MoreVanillaBuildPrefabs
MoreVanillaBuildPrefabs is a Valheim mod to make all vanilla prefabs buildable with the hammer (survival way) while allowing you to configure the requirements to build them. It also now has ServerSync! The mod can still be used as a Client-Side mod though.

### Acknowledgements
This mod was inspired by MoreVanillaBuilds by Galathil and PotteryBarn by ComfyMods. The core functionality of the code is based on those two mods. Thanks to blaxxun-boop for creating ServerSync.

## Key Feature
Because all the added build pieces are pre-existing vanilla prefabs, any pieces you build with this mod will persist in your world even if you uninstall the mod. This means that pieces you build on a server will also be visible for players without the mod and any builds using the pieces from this mod will load for players without the mod.

## Instructions
If you are using a mod manager for Thunderstore simply install the mod from there and skip to step 3 below. If you are not using a mod manager then, you need a modded instance of Valheim (BepInEx) and the Jötunn plugin installed.

1. Download the MoreVanillaBuildPrefabs.dll from the Publish/Thunderstore directory.
2. Place the MoreVanillaBuildPrefabs.dll into your BepInEx\plugins folder
3. Launch the game and enter a world to generate the configuration files. The plugin searches for prefabs in the game loading screen.
4. (Optional) Quit the game. Find the file Searica.Valheim.MoreVanillaBuildPrefabs.cfg in your BepInEx\config folder, open it to customize mod configuration (see Configuration section for details).
5. Play the game using the default configuration generated by the mod or your customized one.

**Recommended:** Install SearsCatalog (https://valheim.thunderstore.io/package/ComfyMods/SearsCatalog/) to extend the hammer build table and allow you to access all the pieces this mod adds even if there are too many added pieces for the vanilla build table.

## Configuration
You need to edit the configuration file with client/server off! If you use an in-game configuration manager, you need to restart the game/server to apply configuration.

For each detected prefab in the game you can:
- Enable/Disable it from the hammer.
- Define custom recipe to build the prefab in-game.
- Set the required crafting station to build and deconstruct the prefab.
- Set whether the prefab is allowed to be built inside of dungeons.
- Enable a generic placement patch if the piece is behaving strangely when placing it.

### Global Section Configuration:

**EnableMod** [Synced with Server, Requires Restart]
- Globally enable or disable this mod (restart required).
  - Acceptable values: False, True
  - Default value: true

**LockConfiguration** [Synced with Server]
- If true, the configuration is locked and can be changed by server admins only.
  - Acceptable values: False, True
  - Default value: true
 
**AdminOnlyCreatorShop** [Synced with Server]
- Set to true to restrict placement and deconstruction of CreatorShop pieces to players with Admin status.
  - Acceptable values: False, True
  - Default value: false

**AdminDeconstructCreatorShop** [Synced with Server]
- Set to true to allow admin players to deconstruct any CreatorShop pieces built by players. Intended to prevent griefing via placement of indestructible objects.
  - Acceptable values: False, True
  - Default value: true

**ForceAllPrefabs** [Synced with Server, Requires Re-Logging]
- Setting to true overrides individual configuration for all prefabs and enables them all for building with the hammer.
  - Acceptable values: False, True
  - Default value: false

**VerboseMode** [Synced with Server]
- You should keep it to false. This configuration displays debug information in the console (and slows down game performance).
  - Acceptable values: False, True
  - Default value: false.

### Prefab Configuration Sections:
The rest of the configuration files contains [xxxxxx] sections to configure each prefab. Each section contains:

**Enabled** [Synced with Server, Requires Re-Logging]
- If true then add the prefab as a buildable piece. Note: this setting is ignored if ForceAllPrefabs is true.
  - Acceptable values: False, True
  - Default value: false

**AllowedInDungeons** [Synced with Server, Requires Re-Logging]
- If true then this prefab can be built inside dungeon zones.
  - Acceptable values: False, True
  - Default value: false

**Category** [Synced with Server, Requires Re-Logging]
- A string defining the tab the prefab shows up on in the hammer build table.
  - Acceptable values: CreatorShop, Misc, Crafting, Building, Furniture# Setting type: String
- Default value: CreatorShop

**CraftingStation** [Synced with Server, Requires Re-Logging]
- A string defining the crafting station required to built the prefab.
  - Acceptable values: None, Workbench, Forge, Stonecutter, Cauldron, ArtisanTable, BlackForge, GaldrTable
  - Default value: None

**Requirements** [Synced with Server, Requires Re-Logging]
- Resources required to build the prefab. Formatted as: itemID,amount;itemID,amount where itemID is the in-game identifier for the resource and amount is an integer. You can find itemID on Valheim Wiki or on this [link](https://valheim-modding.github.io/Jotunn/data/objects/item-list.html). Example: Requirements = Wood,5;Stone,2 would mean the prefab requires 5 wood and 2 stone to build.
  - Default value:

**PlacementPatch** [Synced with Server, Requires Re-Logging]
- Set to true to enable collision patching during placement of the piece. Recommended to try this if the piece is not appearing when attempting to place it. (If enabling the placement patch via this setting fixes the issue please open an issue on Github letting me know so I can make sure the collision patch is always applied to this piece.)
  - Acceptable values: False, True
  - Default value: false
  - *Note:* this setting is not available on prefabs that I have already made custom placement patches for.

### Default Prefab Configuration
The mod comes with a default configuration that sets the crafting requirements for many of the prefabs when generating the configuration file. The defaults also enable a number of pre-configured prefabs for building. These configurations are based on my preferences and intended to ensure that someone playing with the mod will only unlock various build pieces after encountering them in the world. The default configuration also means that the mod can simply be installed and used immediately to get a sense of how it works. You are of course able to change these default configurations however you please.

### Default Enabled Pieces
<details>
  <summary>Click to see a general list of enabled pieces (contains spoilers.)</summary>

  - All black marble pieces used in Dvergr structures.
  - All Dvergr furniture.
  - Most Dvergr wooden structures.
  - Dvergr demisters.
  - Fuling village pieces.
  - Various rocks.
  - Extra furniture and decorations.
  - Turf roofs.
  - Statues.
  - Wood ledge.

  See the PrefabConfig.cs file in the source code for the full default configuration or install the mode and check the generated configuration file.
</details>

## Implementation Notes
The prefabs enabled by this mod were not necessarily intended to be built by players, so they may lack some of the things required to place them or build them such as proper collision or snap points.

All of the pieces that are enabled by default have been patched to have snap points and fix collision issues to ensure they can be used similarly to existing vanilla pieces. For the prefabs that are not enabled by default, while many of them have been patched not all of them have as the process of patching them is currently entirely manual. This means that if you enable prefabs other than the ones enabled by default there is no guarantee they will behave nicely.

If you are having issues with a prefab you would like to build with but it won't appear when you try to place it the issue is likely due to missing colliders that have not been patched yet. A work around for some prefabs is to install either [Snap Points Made Easy](https://valheim.thunderstore.io/package/MathiasDecrock/Snap_Points_Made_Easy/) by MathiasDecrock or the mod [Extra Snap Points Made Easy](https://valheim.thunderstore.io/package/Searica/Extra_Snap_Points_Made_Easy/) by Searica (that's me). Both of these mods allow you to manually select the snap points on the piece you are placing and the piece you are snapping to. Manually selecting the snap points can allow you to place a prefab that otherwise does not show up due to missing colliders. Some prefabs used for making dungeons can also behave unexpectedly such as being able to open a door but not close it. If there is piece you would really like to build with that is buggy feel free to open an issue on Github requesting it to be patched (see contributions section).

**TLDR:** Some prefabs other than the ones enabled by default may be buggy, please adjust your expectations accordingly.

### Differences from MoreVanillaBuilds by Galathil
First, MoreVanillaBuilds by Galathil has been archived on Github and has not been updated for Hildir's Request, while this mod was built for Hildir's Request. Second, the code used to allow placing added pieces for MoreVanillaBuilds had the additional effect of bypassing all placement restrictions for all pieces, which meant that it was possible to build pieces in locations that it was not possible to deconstruct them. In contrast, this mod always respect placement restrictions (such as the no build zone at spawn) to prevent issues with being unable to deconstruct pieces by using code based on PotteryBarn.

### Deconstructing Pieces
Since this mod adds more prefabs to the hammer, that means you can deconstruct more pieces. As of version 0.0.3 and all later versions, world-generated pieces will only drop their default drops, while player-built pieces will only drop the resources used to build them.

### CreatorShop Pieces
Prefabs set to the custom CreatorShop category on the hammer will behave differently than pieces from other categories with respect to deconstructing them.

Specifically, when a piece is set to the CreatorShop category player's can only deconstruct instances of that piece that they have placed themselves. This prevents player's from deconstructing world-generated prefabs like trees while still allowing you to build and deconstruct player-placed trees. If multiple player's have this mod enabled they can still only deconstruct CreatorShop pieces that they have placed themselves. If the AdminDeconstructCreatorShop option is set to True, then admins can deconstruct CreatorShop pieces placed by other players.

## Known Issues

### Custom Armor Stand Clipping
Placing armor on the Male Armor Stand and Female Armor Stand prefabs have clipping issues where not all of the armor is displayed. I have not been able to fix this as of yet.


## Planned Improvements
- Resolve known issues.
- Patch and enable more prefabs.
- Add sfx to placement and deconstruction of black marble prefabs.

## Compatibility
This is a non-exhaustive list.

### Incompatible Mods
Likely incompatible with other mods that add Vanilla prefabs to the build hammer unless you disable the prefabs from this mod that overlap with the other one since conflicting build requirements can cause unexpected behavior.
- MoreVanillaBuilds (by Galathil)
- PotteryBarn (by ComfyMods)

### Compatible Mods
- AdventureBackpacks (by Vapok)
- Aegir (by blbrdv)
- AAACrafting (by Azumatt)
- AzuCraftyBoxes (by Azumatt)
- AzuMapDetails (by Azumatt)
- AzuAreaRepair (by Azumatt)
- AzuClock (by Azumatt)
- AzuExtendedPlayerInventory (by Azumatt)
- AzuSkillTweaks (by Azumatt)
- Backpacks (by Smoothbrain)
- Better Beehives (by MaxFoxGaming)
- BetterArchery (by ishid4)
- BetterCarts (by TastyChickenLegs)
- BetterPickupNotifications (by Pfhoenix)
- BetterUI Reforged (by the defside)
- BowsBeforeHoes (by Azumatt)
- BuildRestrictionTweaks (any version that is a reupload of Aedenthorn)
- ComforTweaks (by Smoothbrain)
- ComfySigns (by ComfyMods)
- CraftingFilter (by Aedenthorn)
- DeathPinRemoval (by Azumatt)
- DeezMistyBalls (by Azumatt)
- DodgeShortcut Reupload (by NetherCrowCSOLYOO)
- EmoteWheel (by virtuaCode)
- EulersRuler (by ComfyMods)
- Evasion (by Smoothbrain)
- Extra Snap Points Made Easy (by Searica)
- FascinatingCarryWeight (by kangretto)
- FastTeleport (by GemHunter1)
- FastTools (by Crystal)
- Gizmo (by ComfyMods)
- HeyListen (by ComfyMods)
- ImFRIENDLY DAMMIT (by Azumatt)
- Instantly Destroy Boats and Carts (by GoldenRevolver)
- InstantRuneText (by Azumatt)
- MapTeleport (by Numenos)
- Mead Base Icon Fix (by Sulyvana)
- MultiUserChest (by MSchmoecker)
- Multiverse (by 1010101110)
- Minimal UI (by Azumatt)
- NoSmokeStayList (by TastyChickenLegs)
- OdinsFoodBarrels (by OdinPlus)
- PassivePowers (by Smoothbrain)
- Pathfinder (by Crystal)
- Perfect Placement (by Azumatt)
- PlanBuild (by MathiasDecrock)
- PlantEasily (by Advize)
- PlantEverything (by Advize)
- ProfitablePieces (by Azumatt)
- QoLPins (by Tekla)
- Queue Me Maybe (by Azumatt)
- Quick Stack Store Soft Trash Restock (by Goldenrevolver)
- QuickConnect (by bdew)
- QuietyPortals (by Neobotics)
- Ranching (by Smoothbrain)
- RepairAll (by LoadedGun)
- Sailing (by Smoothbrain)
- SearsCatalog (by ComfyMods)
- Server devcommands (by JereKuusela)
- ShieldMeBruh (by Vapok)
- SilenceTameWolfCub (by GetOffMyLawn)
- Snap Points Made Easy (by MathiasDecrock)
- SNEAKer (by black7ar)
- Sorted Menus Cooking Crafting and Skills Menu (by Goldenrevolver)
- SpeedyPaths (by Nextek)
- StackedBars (by Azumatt)
- StaminRegenerationFromFood (by Smoothbrain)
- SuperConfigurablePickupRadius (by TastyChickenLegs)
- TargetPortal (by Smoothbrain)
- ToggleMovementMod (by GetOffMyLawn)
- Veinmine (by WiseHorrer)
- Venture Location Reset (by VentureValheim)
- VikingsDoSwim (by blacks7ar)
- WieldEquipmentWhileSwimming (by blacks7ar)
- Probably even more, it's pretty compatible.

### Source Code
Github: https://github.com/searica/MoreVanillaBuildPrefabs

## Donations/Tips
My mods will always be free to use but if you feel like saying thanks you can tip/donate here: https://ko-fi.com/searica

### Contributions
You are welcome to open issues on the Github repository to provide suggestions, feature requests, compatibility issues, and bug reports. Over time I will slowly patch more prefabs and hopefully come up with a more generalizable method of patching them, but if you'd really like a specific prefab to work better just open an issue letting me know. I'm a grad student and have a lot of personal responsibilities on top of that so I can't promise I will respond quickly, but I do intend to maintain and improve the mod in my free time.
