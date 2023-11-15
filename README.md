# MoreVanillaBuildPrefabs
MoreVanillaBuildPrefabs is a Valheim mod to make all vanilla prefabs buildable with the hammer (survival way) while allowing you to configure the requirements to build them. You can configure which prefabs are available for building and what the building requirements are, though the mod comes with a default configuration that enables ~100 new pieces so you can start playing right away.

**Server-Side Info**: This mod does work as a client-side only mod. It is strongly recommended that you install it on the server you play on if possible though as multiple players with conflicting configurations can result in losing build resources when pieces are deconstructed. Not installing the mod on the server also means that some pieces (like the new ship) may not function well for players without the mod.

## Key Feature
Because all the added build pieces are pre-existing vanilla prefabs, any pieces you build with this mod will persist in your world even if you uninstall the mod. This means that pieces you build on a server will also be visible for players without the mod and any builds using the pieces from this mod will load for players without the mod.

## Instructions
If you are using a mod manager for Thunderstore simply install the mod from there and skip to step 3 below. If you are not using a mod manager then, you need a modded instance of Valheim (BepInEx) and the Jotunn plugin installed.

1. Download the MoreVanillaBuildPrefabs.dll from the Publish/Thunderstore directory.
2. Place the MoreVanillaBuildPrefabs.dll into your BepInEx\plugins folder
3. Launch the game and enter a world to generate the configuration files. The plugin searches for prefabs in the game loading screen.
4. (Optional) Edit the default configuration using an in-game configuration manager or find the file Searica.Valheim.MoreVanillaBuildPrefabs.cfg in your BepInEx\config folder and edit it to customize mod configuration (see Configuration section for details).
5. Play the game using the default configuration generated by the mod or your customized one.

**Recommended:** Install [SearsCatalog](https://valheim.thunderstore.io/package/ComfyMods/SearsCatalog/) to extend the hammer build table and allow you to access all the pieces this mod adds even if there are too many added pieces for the vanilla build table. If you install the mod from Thunderstore via r2modman or Thunderstore mod manager then SearsCatalog will automatically be installed as well.

## Configuration
Most changes made to the configuration settings will be reflected in-game immediately (options requiring a restart will explicity say so) and they will also sync to clients if the mod is on the server. The mod also has a built in file watcher so you can edit settings via an in-game configuration manager (changes applied upon closing the in-game configuration manager) or by changing values in the file via a text editor or mod manager.

### Default Configuration
The mod has a default configuration that enables ~100 new pieces by default. The configuration settings for these pieces are intended to provide a reasonable balance and ensure that someone playing with the mod will only unlock various build pieces after encountering them in the world. As you progress through the game you will also unlock torches that don't require fuel, fires that don't require fuel, and a new portal that can be configured to ignore portal restrictions. As the default settings are based on my preferences and not yours, you are of course able to change these default configurations however you please.

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

  See the PrefabConfig.cs file in the source code for the full default configuration or install the mod and check the generated configuration file.
</details>

<div class="header">
	<h3>Global Section</h3>
  These settings control the main features of the mod and how verbose it's output to the log is.
</div>
<table>
	<tbody>
		<tr>
			<th align="center">Setting</th>
      <th align="center">Server&nbspSync</th>
			<th align="center">Description</th>
		</tr>
    <tr>
			<td align="center"><b>CreativeMode</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Setting to enable pieces set to the custom CreatorShop or Nature piece categories. By default, the pieces set to those categories are not standard build pieces. These prefabs are also more likely to have bugs like being unable to remove them after placing them and are a lower priority for me to patch.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
				</ul>
        <b>Note:</b> If you're doing a survival playthrough and just want more build pieces then leave CreativeMode off. If you want to build new environmental locations or new dungeons then you probably want to enable CreativeMode.
			</td>
		</tr>
		<tr>
			<td align="center"><b>ForceAllPrefabs</b></td>
      <td align="center">Yes</td>
			<td align="left">
        If enabled, adds all prefabs to the hammer for building. Unless CreativeMode is also enabled it will not add pieces set to the CreatorShop or Nature category though.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>Verbosity</b></td>
      <td align="center">No</td>
			<td align="left">
        Low will log basic information about the mod. Medium will log information that is useful for troubleshooting. High will log a lot of information, do not set it to this without good reason as it will slow down your game.
				<ul>
					<li>Acceptable values: Low, Medium, High</li>
					<li>Default value: Low</li>
				</ul>
			</td>
		</tr>
  </tbody>
</table>

<div class="header">
	<h3>Admin Section</h3>
  These settings let server admins customize how the mod works to help prevent griefing and/or make the mod more of an admin-only tool.
</div>
<table>
	<tbody>
		<tr>
			<th align="center">Setting</th>
      <th align="center">Server&nbspSync</th>
			<th align="center">Description</th>
		</tr>
		<tr>
			<td align="center"><b>CreatorShopAdminOnly</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true to restrict placement and deconstruction of CreatorShop pieces to players with Admin status.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>AdminDeconstructOtherPlayers</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true to allow admin players to deconstruct any pieces built by other players, even if doing so would normally be prevented (such as for CreatorShop or Nature pieces). Intended to prevent griefing via placement of indestructible objects.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: true</li>
				</ul>
			</td>
		</tr>
  </tbody>
</table>

<div class="header">
	<h3>Customization Section</h3>
  These settings let you customize and improve the behaviour of pieces adds by MoreVanillaBuildPrefabs. Most of them are enabled by default.
</div>
<table>
	<tbody>
		<tr>
			<th align="center">Setting</th>
      <th align="center">Server&nbspSync</th>
			<th align="center">Description</th>
		</tr>
    <tr>
			<td align="center"><b>ComfortPatches (Requires Restart)</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true/enabled to patch new pieces to have comfort values like their vanilla counterparts.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: true</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>DoorPatches (Requires Restart)</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true/enabled to patch player-built instances of new doors (that do not require keys) to allow closing them even if that is normally prevented.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: true</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>PlayerBasePatches (Requires Restart)</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true/enabled to patch player-built instances of new torches, fires, and beds so they suppress monster spawning just like their vanilla counterparts.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: true</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>HammerCrops</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true/enabled to enable placing vanilla crops with the hammer. Unless this setting is true Vanilla crops will not be available for placing with the hammer. Can be useful if you want to make pretty gardens without having to wait for crops to grow (plus you control the crop rotation this way).
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center"><b>SeasonalPieces</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true/enabled to add all currently disabled seasonal pieces to the hammer build table.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: true</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>PortalPatch</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true/enabled to have the new portal allow unrestricted teleporting. Set to false/disabled to have the new portal work the same as the vanilla portal.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: true</li>
				</ul>
			</td>
		</tr>
  </tbody>
</table>

<div class="header">
	<h3>Texture Section</h3>
  These settings let you customize the appearance of some of the pieces added by MoreVanillaBuildPrefabs. Thanks to DreamWraith for creating the alternative portal texture and Goldenrevolver for the idea and general method of changing the wood texture.
</div>
<table>
	<tbody>
		<tr>
			<th align="center">Setting</th>
      <th align="center">Server&nbspSync</th>
			<th align="center">Description</th>
		</tr>
		<tr>
			<td align="center"><b>PortalTexturePatch (Requires Restart)</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true/enabled to change the texture of the new portal to appear as if it was created by those who dwell in the Mistlands. <b>Note:</b> change in appearance will not work for users without this mod.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>DvergrWoodPatch (Requires Restart)</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true/enabled to change the texture of the player built instances of of Dvergr wood floors and stairs to appear as if they were brand new. <b>Note:</b> change in appearance will not work for users without this mod.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
				</ul>
			</td>
		</tr>
  </tbody>
</table>

<div class="header">
	<h3>Unsafe Patches Section</h3>
  These settings enable optional patches that can have unintended side effects if you log into your world without MoreVanillaBuildPrefabs installed. They are all off by default.
</div>
<table>
	<tbody>
		<tr>
			<th align="center">Setting</th>
      <th align="center">Server&nbspSync</th>
			<th align="center">Description</th>
		</tr>
		<tr>
			<td align="center"><b>BedPatches (Requires Restart, Unsafe)</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true/enabled to patch player-built instances of new beds so you can sleep in them. <b>WARNING:</b> enabling this setting can result in you losing your spawn point if had set your spawn using a patched bed and log in without this mod.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>FermenterPatches (Requires Restart, Unsafe)</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true/enabled to patch player-built instances of fermenting barrels to function as a fermenter that is 30% faster than the vanilla fermenter. <b>NOTE:</b> players without this mod cannot use the patched fermenter and you cannot retrieve your mead without the mod.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
				</ul>
			</td>
		</tr>
  </tbody>
</table>

<div class="header">
	<h3>Prefab Configuration Sections</h3>
  The rest of the configuration files contains ["Prefab-Name"] sections to configure each prefab.
</div>
<table>
	<tbody>
		<tr>
			<th align="center">Setting</th>
      <th align="center">Server&nbspSync</th>
			<th align="center">Description</th>
		</tr>
		<tr>
			<td align="center"><b>Enabled</b></td>
      <td align="center">Yes</td>
			<td align="left">
        If true then allow this prefab to be built and deconstructed. Note: this setting is ignored if ForceAllPrefabs is true.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: <i>Depends on the prefab</i></li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>AllowedInDungeons</b></td>
      <td align="center">Yes</td>
			<td align="left">
        If true/enabled then this prefab can be built inside dungeon zones.
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>Category</b></td>
      <td align="center">Yes</td>
			<td align="left">
        A string defining the tab the prefab shows up on in the hammer build table.
				<ul>
					<li>Acceptable values: Acceptable values: CreatorShop, Nature, Misc, Crafting, Building, Furniture</li>
					<li>Default value: CreatorShop</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>CraftingStation</b></td>
      <td align="center">Yes</td>
			<td align="left">
        A string defining the crafting station required to built the prefab.
				<ul>
					<li>Acceptable values: None, Workbench, Forge, Stonecutter, Cauldron, ArtisanTable, BlackForge, GaldrTable</li>
					<li>Default value: None</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>Requirements</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Resources required to build the prefab. Formatted as: itemID,amount;itemID,amount where itemID is the in-game identifier for the resource and amount is an integer. You can find itemID on Valheim Wiki or on this <a href="https://valheim-modding.github.io/Jotunn/data/objects/item-list.html">link</a>. Example: Requirements = Wood,5;Stone,2 would mean the prefab requires 5 wood and 2 stone to build.
			</td>
		</tr>
    <tr>
			<td align="center"><b>ClipEverything</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true to allow piece to clip through everything during placement. Recommended to try this if the piece is not appearing when you go to place it. (If this setting fixes the issue please let me know via Github or Discord so I can change the default settings.)
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
          <li><b>Note:</b> Some prefabs are missing this setting because changing it breaks them.</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>ClipGround</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true to allow piece to clip through everything during placement. Recommended to try this if the piece is not appearing when you go to place it.(If this setting fixes the issue please let me know via Github or Discord so I can change the default settings.)
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
          <li><b>Note:</b> Some prefabs are missing this setting because changing it breaks them.</li>
				</ul>
			</td>
		</tr>
    <tr>
			<td align="center"><b>PlacementPatch</b></td>
      <td align="center">Yes</td>
			<td align="left">
        Set to true to enable collision patching during placement of the piece. Recommended to try this if the piece is not appearing when attempting to place it. (If this setting fixes the issue please let me know via Github or Discord so I can change the default settings.)
				<ul>
					<li>Acceptable values: False, True</li>
					<li>Default value: false</li>
          <li><b>Note:</b> Some prefabs are missing this setting because changing it breaks them.</li>
				</ul>
			</td>
		</tr>
	</tbody>
</table>

## Detailed Mechanics
This mod enables prefabs that were not intended to used for building by players, so they may lack things like proper collision or snap points. All of the prefabs enabled by the default configuration have been patched to fix those sorts of issues and make them behave similarly to vanilla build pieces. These patches are applied whether the prefab is enabled for building or not to make sure that prefabs that have been placed previously still behave as intended (ie they don't lose their collision and fall though the world).

If a prefab is not enabled by default then there is no guarantee that it will behave nicely. While many of them have been patched, I currently have to make custom patches for each prefab so not all of them have been patched yet. It also takes a long time to test and patch 300+ prefabs.

That said, the placement patch config setting provides a generic patch that may resolve placement issues for some prefabs, so please try toggling that if there is a prefab you would like to build with but it there are issues. If the placement patch does resolve the issue then please let me know so I can change the mod to always enable the placement patch for that prefab.

Alternatively if the placement patch setting does not resolve the issue, then a work around that may work is using either [Snap Points Made Easy](https://valheim.thunderstore.io/package/MathiasDecrock/Snap_Points_Made_Easy/) by MathiasDecrock or the mod [Extra Snap Points Made Easy](https://valheim.thunderstore.io/package/Searica/Extra_Snap_Points_Made_Easy/) by Searica (that's me). Both of these mods allow you to manually select the snap points on the piece you are placing and the piece you are snapping to. Manually selecting the snap points can allow you to place a prefab that otherwise does not show up due to missing colliders.

Some prefabs found in vanilla dungeons can also behave unexpectedly, such as being able to open a door but not close it. If there is piece you would really like to build with that is buggy feel free to open an issue on Github requesting it to be patched (see contributions section).

**TLDR:** Some prefabs other than the ones enabled by default may be buggy, please adjust your expectations accordingly.

## Custom Piece Categories
This mod adds two custom piece categories: **CreatorShop** and **Nature**. Pieces set to either of the custom categories will only be enabled for building if CreativeMode is set to True. Additionally, these pieces can only be deconstructed by the player who placed them and world-generated instances of these pieces cannot be deconstructed. This prevents player's from deconstructing things like world-generated trees, while still allowing them to build and deconstruct their own trees.

If multiple player's have this mod, the same restrictions still apply and they will not be able to deconstruct instances of  pieces set to either of the custom piece categories that were built by other players.

The AdminDeconstructOtherPlayers setting can allow players with admin status to deconstruct CreatorShop or Nature pieces built by other players, so that admins have a way to remove indestructible pieces. Even if you enable the AdminDeconstructOtherPlayers setting, admins are still not able to deconstruct world-generated instances of pieces set to the CreatorShop or Nature categories.

## Resource Costs and Drops
Since this mod adds more prefabs to the hammer, that means you can deconstruct more pieces. World-generated pieces will only drop their default drops, while player-built pieces will only drop the resources used to build them.

### Pickable Pieces
Building and deconstructing prefabs that have pickable components could potentially allow for exploits that create infinite resources. To prevent that, the following adjustments are made.

#### Pickable Resource Costs
If a prefab has a pickable component, such as a berry bush, then whatever resource it drops will always be added to the required resources for building it. The amount of the resource required to build the prefab will also always be equal to or greater than the amount of the resource that is dropped when you pick it (after accounting for world modifiers). These conditions will override the required resources set in the configuration file.

**Example:** If building a berry bush drops 1 berry when you pick it then no matter what the settings are in the configuration file it will always cost at least 1 berry to build the berry bush. If world modifiers are set to 2 so the bush would drop 2 berries then it will always cost at least 2 berries to build.

#### Pickable Resource Drops
When you deconstruct a prefab with a pickable component if the pickable item has not been picked then it will drop the pickable item. The resources dropped by deconstructing it will also be adjusted to reduce the amount of the pickable item drops by the amount that was gained by picking the item (after accounting for world modifiers).

**Example:** If you built a berry bush that cost 5 berries to build, then picked the berries and got 2 berries, and then deconstructed the bush only 3 berries would drop.

If a pickable piece has additional random drops, like some pickables found in dungeons, the random drops will be disabled for player-built instances of the piece. World-generated instances are unaffected and will picking them will drop the random drops as normal.

### Mineable Pieces
Any piece that you can hit with a pickaxe and destroy parts of is a mineable piece (for anyone who has gone through the game code this is prefabs with a MineRock5 or MineRock component).

#### Resource Costs
All mineable pieces have the cost for building them adjusted so that building them always require resources equal to or greater than the average resources dropped when the mineable piece is completely mined.

#### Resource Drops
Deconstructing mineable pieces effectively "mines" the entire piece and per vanilla behavior the dropped resources are slightly randomized (as if you had mined it). When deconstructing mineable pieces the resources required to build it are returned after subtracting the average resources dropped by fully mining the piece.

**Example:** If you built a rock that on average drops 41 stone, it would cost 41 stone to build. If you configured that rock to cost 56 stone, built it, and deconstructed it then it would drop 15 stone plus whatever is randomly dropped due to mining the entire piece which will on average result in dropping 56 stone, but could be slightly more or less. If you configured the rock to cost 41 stone and 2 iron, then it would always drop 2 iron when removed and whatever is dropped due to mining the entire piece.

## ItemStand Pieces
Any piece that you can attach an item to has an ItemStand component and has a unique behavior when deconstructed.

#### ItemStand Drops
When you deconstruct a piece that has an ItemStand component it will always drop the attached item, even if you could not normally remove it.

## Known Issue/Feature
MVBP is able to detect prefabs added by other mods. It is possible to enable and configure those prefabs much like the Vanilla prefabs added by MVBP. In some cases, prefabs from other mods can cause issues, though it is uncommon. As a general rule, I also will not patch or support issues regarding prefabs from other mods as I do not have access to the assets from other mods.

## Known Issues
**Config Changes on Dedicated Server**: Configuration changes made to a dedicated server using an in-game configuration manager do persist after logging out and re-connecting  but they are not saved to disk on the server until the server is shut down. Once Jotunn updates this issue should be resolved.

**Placement Glitch**: There is one pickable that will appear to not be created when placed.This is because it falls through the ground is pushed back up after a short period of time. If you wait it will appear.

**Impossible Recipes**: Forcing pickable pieces to always require resources equal to or greater than what they drop when picked means that if a pickable piece is unattainable in the Vanilla game, then the recipe for it can never be unlocked. I am currently considering how I want to address this and whether this should be considered a bug or not as it is a consequence of the intended behavior to prevent infinite resource exploits. It is still possible to unlock these recipes via console commands or using other mods like [ExpandWorld](https://valheim.thunderstore.io/package/JereKuusela/Expand_World_Data/) or [Immersively Obtainable Blue Mushrooms](https://valheim.thunderstore.io/package/Goldenrevolver/Immersively_Obtainable_Blue_Mushrooms/) to populate them in the world.

## Planned Improvements
- Resolve known issues.
- Patch and enable more prefabs by default.
- Integrate the material replacement method that GoldenRevolver demonstrated as a configurable option.
- Learn how localization works and add localization options to the mod.

## Potential Improvements
- Adding patches that are **unsafe** and a corresponding setting to enable/disable those patches. Examples of **unsafe** patches are:
    - Changing inventory sizes for some prefabs or other patches that could make you lose items if you loaded the world without the mod.
    - Adding fermenter functionality to some prefabs. Could result in losing the mead base if loaded without the mod.
    - Add Wear-N-Tear or Destructible components all to player built pieces upon placement.


## Compatibility
These are non-exhaustive lists.

### Incompatible Mods
**PotteryBarn (by ComfyMods)** Currently both mods apply a transpiler patch to `Player.SetUpPlacementGhost()` and using MoreVanillaBuildPrefabs while PotteryBarn is installed will cause MoreVanillaBuildPrefabs to fail to load correctly. I am looking into a possible fix for this but it is not high priory as I think it is unlikely someone would use both mods at the same time given their functions directly overlap (I could be wrong though).

**MoreVanillaBuilds (by Galathil)** The original mod that this one is a remake of. I haven't actually checked what happens if you use both at once but they do modify the same pieces so I wouldn't recommend it.

### Partial Incompatibly
**PlanBuild (by MathiasDecrock)** The two mods do work together but not all of the icons for custom pieces added by MoreVanillaBuildPieces show on correctly in the build table for PlanBuild's Plan Hammer. MoreVanillaBuildPrefabs can now cause PlanBuild to detect pieces as they are enabled but PlanBuild does not update for when MVBP removes prefabs. A fix is currently being worked on in collaboration with the authors of PlanBuild though.


### Compatible Mods

**PlantEverything (by Advize)**: These two mods are fully compatible. If PlantEverything is installed then MoreVanillaBuildPrefabs will not touch any of the prefabs that PlantEverything adds to the cultivator so all of the plants added by PlantEverything will function as normal. I also highly recommend using PlantEverything as it targeted at providing a balanced and configurable experience for enabling more plant pieces and compliments MoreVanillaBuildPrefabs.

**Gizmo (by ComfyMods)**: Fully compatible and highly recommended if you like building.

**WackysDatabase (by Wackymole)**: These two mods are fully compatible. You can use WackyDB to alter pieces added by this mod. Depending on what you alter the dynamic configuration changes of this mod may override the change changes made by WackyDB when the mod updates in response to the config changes. To resolve this you can A.) avoid changing the config for this mod while in-game, B.) log out and rejoin to allow WackyDB to reapply it's changes, C.) use the wackydb_reload console command to reapply changes without exiting the game (probably the easiest and best option).

<details>

<summary><b>Click to see full list of compatible mods</b></summary>

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
- CreatureLevelAndLootControl (by Smoothbrain)
- ComfortTweaks (by Smoothbrain)
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

</details>

## Donations/Tips
My mods will always be free to use but if you feel like saying thanks you can tip/donate.

| My Ko-fi: | [![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/searica) |
|-----------|---------------|

## Source Code
Source code is available on Github.

| Github Repository: | <button style="font-size:20px"><img height="18" src="https://github.githubassets.com/favicons/favicon-dark.svg"></img><a href="https://https://github.com/searica/MoreVanillaBuildPrefabs"> More Vanilla Build Prefabs</button> |
|-----------|---------------|

### Contributions
If you would like to provide suggestions, make feature requests, or reports bugs and compatibility issues you can either open an issue on the Github repository or tag me (@searica) with a message on my discord [Searica's Mods](https://discord.gg/sFmGTBYN6n).

Over time I will slowly patch more prefabs and hopefully come up with a more generalizable method of patching them, but if you'd really like a specific prefab to work better then let me know via one of the methods above. I'm a grad student and have a lot of personal responsibilities on top of that so I can't promise I will always respond quickly, but I do intend to maintain and improve the mod in my free time.

### Credits
This mod was inspired by MoreVanillaBuilds by Galathil and PotteryBarn by ComfyMods.

#### Development Credits
- Huge shoutout and thanks to the developers of Jotunn for all their work making the library and to Margmas specifically for all their help and advice.
- Thanks to Advize for the advice and examples for re-writing the mod to respond to configuration settings changes while in-game.
- Thanks to Goldenrevolver for the advice and help with piece sorting + modifying textures.
- Thanks to probablykory for the advice and examples on optimizing how mods respond to configuration settings changes.
- Thanks to OrianaVenture for the example of using Jotunn's server sync features.
- Thanks to redseiko for the advice and pointing me to resources to learn more about Unity and also for making PotteryBarn.
- Thanks to Wackymole for the help figuring out when to hook the game and resolving server sync issues.
- Thanks to Jules and MarcoPogo for their help with figuring out a solution for compatability with PlanBuild.
- Thanks to Marlthon for the help figuring out how to fix the wind physics on the new ship's sail.


#### Community Credits
- Thanks to DreamWraith, onnan, and Havengrad for all their suggestions, feedback, and testing
- Thanks to Cass, Blubbson, Katosan, and LunaEversor for quickly finding and reporting issues or bugs.

## Shameless Self Plug (Other Mods By Me)
If you like this mod you might like some of my other ones.

#### Building Mods
- [Extra Snap Points Made Easy](https://valheim.thunderstore.io/package/Searica/Extra_Snap_Points_Made_Easy/)
- [AdvancedTerrainModifiers](https://valheim.thunderstore.io/package/Searica/AdvancedTerrainModifiers/)
- [BuildRestrictionTweaksSync](https://valheim.thunderstore.io/package/Searica/BuildRestrictionTweaksSync/)

#### Gameplay Mods
- [CameraTweaks](https://valheim.thunderstore.io/package/Searica/CameraTweaks/)
- [DodgeShortcut](https://valheim.thunderstore.io/package/Searica/DodgeShortcut/)
- [FortifySkillsRedux](https://valheim.thunderstore.io/package/Searica/FortifySkillsRedux/)
- [ProjectileTweaks](https://github.com/searica/ProjectileTweaks/)
- [SkilledCarryWeight](https://github.com/searica/SkilledCarryWeight/)
- [SafetyStatus](https://valheim.thunderstore.io/package/Searica/SafetyStatus/)
