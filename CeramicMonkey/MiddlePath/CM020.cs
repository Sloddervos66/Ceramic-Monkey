using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.MiddlePath;

public class CM020 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 400;
    public override string DisplayName => "Fast Shards";
    public override string Description => "Ceramic Shards fly further and faster.";
    public override int Path => MIDDLE;
    public override int Tier => 2;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // Ceramic shards +20% projectile speed and radius 20 -> 30.
    }
}
