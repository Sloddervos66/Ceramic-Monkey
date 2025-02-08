using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.MiddlePath;

public class CM010 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 380;
    public override string DisplayName => "Torn Influence";
    public override string Description => "Can target more Bloons";
    public override int Path => MIDDLE;
    public override int Tier => 1;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        towerModel.GetWeapon().projectile.pierce = 8;
    }
}
