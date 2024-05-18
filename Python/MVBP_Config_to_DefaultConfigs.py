import os
from pathlib import Path
from typing import Dict, List


class PrefabConfig:
    """Class to hold prefab configuration settings"""
    _tab = "    "

    _ordering = {
        "name": 1,
        "enabled": 2,
        "allowedInDungeons": 3,
        "category": 4,
        "craftingStation": 5,
        "requirements": 6,
        "clipEverything": 7,
        "clipGround": 8,
        "placementPatch": 9,
        "placementOffset": 10,
        "pieceName": 11,
        "pieceDesc": 12,
        "pieceGroup": 13,
        "playerBasePatch": 14,
        "spawnOnDestroyed": 15,
        "invWidth": 16,
        "invHeight": 17
    }

    _needs_quotes = set(
        [
            "name",
            "requirements",
            "pieceDesc",
            "pieceName",
            "spawnonDestroyed"
        ]
    )

    def __init__(self):
        self.name = None
        self.enabled = None
        self.allowedInDungeons = None
        self.category = None
        self.craftingStation = None
        self.requirements = None
        self.clipEverything = None
        self.clipGround = None
        self.placementPatch = None
        self.placementOffset = None
        self.pieceName = None
        self.pieceDesc = None
        self.pieceGroup = None
        self.playerBasePatch = None
        self.spawnOnDestroyed = None
        self.invWidth = None
        self.invHeight = None

    def _sort_attr_names(self, name: str):
        if name not in self._ordering:
            raise KeyError(f"Could not find ordering value for: {name}")
        return self._ordering[name]

    def get_attr_names(self) -> List[str]:
        names = [x for x in dir(self) if self.__is_attr(x)]
        names.sort(key=self._sort_attr_names)
        return names

    def __is_attr(self, name: str) -> bool:
        return not name.startswith('_') and not callable(getattr(self, name))

    def is_valid(self):
        return self.name is not None

    def __str__(self):
        result = ["new PrefabDB("]

        for name in self.get_attr_names():
            if getattr(self, name) is not None:
                val = getattr(self, name)
                if name in self._needs_quotes:
                    val = f'\"{val}\"'
                result.append(f'{self._tab}{name}: {val},')

        result[-1] = result[-1].strip(",")
        result.append(")")
        return "\n".join(result)


def main():
    default_config_path = Path(__file__).parents[1].joinpath(
        "Configs",
        "PrefabDefaults.cs"
    )

    cfg_file_path = Path(os.getenv('APPDATA')).joinpath(
        "r2modmanPlus-local",
        "Valheim",
        "profiles",
        "Mod-Debug",
        "BepInEx",
        "config",
        "Searica.Valheim.MoreVanillaBuildPrefabs.cfg"
    )

    out_path = Path(__file__).parent.joinpath("DefaultConfigs.txt")

    start_line = "        internal static readonly Dictionary<string, PrefabDB> DefaultConfigValues = new()\n"

    default_configs = read_default_prefabs(default_config_path, start_line)
    prefab_configs = read_config_file(cfg_file_path)

    # Add entries from the config file to the default configs
    # Also overwrite any values in default configs with values from
    # the config file (iff values exist in config file)
    for key, val in prefab_configs.items():
        if key not in default_configs:
            default_configs.update({key: val})
            print(f"Added Prefab: {key}")
            print(val)
        else:
            for attr in val.get_attr_names():
                attr_val = getattr(val, attr)
                if attr_val is not None:
                    current_val = getattr(default_configs[key], attr)
                    if current_val != attr_val:
                        setattr(default_configs[key], attr, attr_val)
                        if current_val is not None:
                            print("Modified Prefab:", key)
                            print(
                                f"Changed {attr}: {current_val} to {attr_val}"
                            )

    # write modified default configs to output
    write_output(out_path, default_configs)


def read_default_prefabs(file_path, start_line) -> Dict[str, PrefabConfig]:
    """Reads the cs file containing the prefab
    configs and construct a dictionary of them."""
    default_configs = {}
    prefab_config = PrefabConfig()

    with open(file_path, "r") as file:
        lines = file.readlines()
        i = 0
        while (lines[i] != start_line):
            i = i + 1

        prefab_config = PrefabConfig()

        for line in lines[i:]:
            if "name:" in line:
                # Encountering a "name:" line when prefab_config is valid
                # means this is a new prefab config settings so cache the
                # current prefab_config and make a new one
                if (prefab_config.is_valid()):
                    default_configs.update({prefab_config.name: prefab_config})
                prefab_config = PrefabConfig()
                prefab_config.name = get_line_value(line, "name:")

            for name in prefab_config.get_attr_names():
                if f"{name}:" in line:
                    setattr(
                        prefab_config,
                        name,
                        get_line_value(line, f"{name}:")
                    )

        if (prefab_config.is_valid()):
            default_configs.update({prefab_config.name: prefab_config})

    return default_configs


def read_config_file(file_path) -> Dict[str, PrefabConfig]:
    """Reads mod cfg file to create dictionary of prefab configs"""

    prefab_configs = {}
    prefab_config = PrefabConfig()

    with open(file_path, "r") as file:
        lines = file.readlines()

        prefab_config = PrefabConfig()

        for line in lines[88:]:
            if line.startswith("["):  # prefab config section
                # add config to dictionary is it has been initialized
                if (prefab_config.is_valid()):
                    prefab_configs.update({prefab_config.name: prefab_config})
                    prefab_config = PrefabConfig()
                prefab_config.name = line[1:-2]  # strip ["name"]\n

            for name in prefab_config.get_attr_names():
                line_start = f"{captialize_first_letter(name)} = "
                if line.startswith(line_start):
                    setattr(prefab_config, name, get_line_value(line, "="))

    if (prefab_config.is_valid()):
        prefab_configs.update({prefab_config.name: prefab_config})

    return prefab_configs


def captialize_first_letter(text: str):
    first = text[0].capitalize()
    return first + text[1:]


def get_line_value(line: str, split: str):
    """Gets value from line after the split string"""
    val = line.split(split)[-1].strip(",\n").strip().strip('"')
    val = val.replace("BuildingWorkbench", "Building")
    val = val.replace("BuildingStonecutter", "Stonecutter")
    if "Category = " in line:
        return f"HammerCategories.{val}"
    if "CraftingStation = " in line:
        val = f"nameof(CraftingStations.{val})"

    return val


def write_output(out_path: Path, prefab_configs: Dict[str, PrefabConfig]):
    """Write output to a text file"""
    tab = "    "
    with open(out_path, "w") as out_file:
        out_file.write(tab*2 + "internal static readonly Dictionary<string, PrefabDB> DefaultConfigValues = new()\n")
        out_file.write(tab*2 + "{\n")

        sorted_keys = sorted([x for x in prefab_configs.keys()])
        for key in sorted_keys:
            prefab_config = prefab_configs[key]
            out_file.write(tab*3 + "{\n")
            out_file.write(f'{tab*4}"{prefab_config.name}",\n')
            prefab_str = str(prefab_config)
            lines = [tab*4 + line for line in prefab_str.split("\n")]
            out_file.write("\n".join(lines) + "\n")
            out_file.write(tab*3 + "},\n")
        out_file.write(tab*2 + "};\n")


if __name__ == "__main__":
    main()
