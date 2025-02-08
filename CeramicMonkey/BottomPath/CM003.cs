using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.BottomPath;

public class CM003 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 1400;
    public override string DisplayName => "Jumping Infection";
    public override string Description => "Main attack now jumps from Bloon to Bloon, no matter the distance.";
    public override int Path => BOTTOM;
    public override int Tier => 3;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Ceramic Explosion attack changed. Instead of targeting 5 Bloons within range, it will target 1 Bloon and bounce from it to another Bloon determined by its targeting. It has infinite bouncing range, hits instantly, and works in the same way as the regular attack.
    }
}
