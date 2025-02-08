using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppFacepunch.Steamworks;
using Il2CppSystem.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.MiddlePath;

public class CM040 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 4000;
    public override string DisplayName => "Disgraceful Dissection";
    public override string Description => "Status Grip Ability: Covers up to 100 targets over the course of 5 seconds in ink, causing status effects and damage-over-time effects to be 50% more effective against them. Shards can now apply ink on Bloons and vessels improved.";
    public override int Path => MIDDLE;
    public override int Tier => 4;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Adds Status Grip Ability
		// ▫ Status Grip: 100 pierce, 35% Bloon slow, 15% MOAB-class Bloon slow, increases status effect vulnerability on Bloons +50% (does not affect itself), lasts 10s on Bloons and 5s on MOAB-class Bloons, cooldown 30s.
		// ▪ Ceramic Shrapnel can now apply Ink Splat
		// ▪ Vessel Attack pierce 10 -> 25, blast radius 25 -> 30
    }
}
