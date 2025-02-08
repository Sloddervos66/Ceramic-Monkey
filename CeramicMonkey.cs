using MelonLoader;
using BTD_Mod_Helper;
using CeramicMonkey;

[assembly: MelonInfo(typeof(CeramicMonkey.CeramicMonkey), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CeramicMonkey;

public class CeramicMonkey : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<CeramicMonkey>("CeramicMonkey loaded!");
    }
}