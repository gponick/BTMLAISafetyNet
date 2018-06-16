# BTMLAISafetyNet
BattleTech Mod (using [BTML](https://github.com/Mpstark/BattleTechModLoader) and [ModTek](https://github.com/Mpstark/ModTek)) that attempts to fix the AI's null exceptions.

## Download
Downloads can be found on [Github](https://github.com/gponick/BTMLAISafetyNet/releases) 

## Install
- [Install BTML and Modtek](https://github.com/Mpstark/ModTek/wiki/The-Drop-Dead-Simple-Guide-to-Installing-BTML-&-ModTek-&-ModTek-mods).
- Put the `BTMLAISafetyNet.dll` and `mod.json` files into `\BATTLETECH\Mods\BTMLAISafetyNet` folder.
- If you want to change the settings do so in the mod.json.
- Start the game.

## Settings


Setting | Type | Default | Description
--- | --- | --- | ---

## Special Thanks

HBS, @Mpstark, @Morphyum

## Maintainer Notes: New HBS Patch Instructions

* pop open VS
* grab the latest version of the assembly
* copy the new version of the methods in `original_src` over the existing ones
* see if anything important changed via git
