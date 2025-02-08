using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.BottomPath;

public class CM001 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 150;
    public override string DisplayName => "Further Reach";
    public override string Description => "Increased range.";
    public override int Path => BOTTOM;
    public override int Tier => 1;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        towerModel.GetAttackModel().range = 40;
        towerModel.range = 40;
    }
}
