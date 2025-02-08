using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Simulation.Bloons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Il2CppAssets.Scripts.Models.ServerEvents.QuickMatchSkuSettings;
using UnityEngine.InputSystem.XR;
using UnityEngine.UIElements.UIR;

namespace CeramicMonkey.CeramicMonkeyTower.TopPath;

public class CM300 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 3700;
    public override string Description => "Increased layer removal against Bloons. Allows Ceramic Monkey to target the children of MOABs while they're still inside them, damaging them and the parent MOAB.";
    public override string DisplayName => "Weaponized Internals";
    public override int Path => TOP;
    public override int Tier => 3;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Ceramic Explosion layer removal 1 -> 3
		// ▪ Ceramic Monkey can now target the Bloon children inside of MOABs. The Ceramic Shards will deal damage to the MOAB, and the children will spawn damaged once the MOAB is destroyed. MOABs being damaged are represented by ceramic pieces protruding out of it. BFBs and above cannot be targeted.
    }
}
