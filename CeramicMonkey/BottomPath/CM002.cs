using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.BottomPath;

public class CM002 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 300;
    public override string DisplayName => "Fast Destruction";
    public override string Description => "Bloon layers are turned to ceramic faster.";
    public override int Path => BOTTOM;
    public override int Tier => 2;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Ceramic Explosion transformation 0.5s -> 0.4s
    }
}
