using MelonLoader;
using BTD_Mod_Helper;
using BTD5Towers;

[assembly: MelonInfo(typeof(BTD5Towers.BTD5Towers), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BTD5Towers;

public class BTD5Towers : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<BTD5Towers>("BTD5Towers loaded!");
    }
}