using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.MiddlePath;

public class CM030 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 1200;
    public override string DisplayName => "Multiplying Vessels";
    public override string Description => "Extra vessels that throw themselves at Bloons, damaging them and exploding in a black ink that slows them down. Less effective versus MOAB-class Bloons.";
    public override int Path => MIDDLE;
    public override int Tier => 3;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Adds Vessel Attack
		// ▫ Vessel Attack: 1 damage, 25 blast radius, 10 pierce, applies Ink Splat
		// ▫ Ink Splat: 35% slow, 15% slow vs. MOAB-class Bloons
    }
}
