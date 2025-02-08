using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Data.Behaviors.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.TopPath;

public class CM100 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 300;
    public override string DisplayName => "Aggressive Possession";
    public override string Description => "Statue attacks faster.";
    public override int Path => TOP;
    public override int Tier => 1;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (WeaponModel weapon in towerModel.GetWeapons())
        {
            weapon.Rate = 0.6f;
        }
    }
}
