using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CeramicMonkey.CeramicMonkeyTower.TopPath;

public class CM200 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 660;
    public override string Description => "Allows shards and Ceramic Monkey to pop Lead Bloons";
    public override string DisplayName => "Malevolent Strength";

    public override int Path => TOP;

    public override int Tier => 2;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Ceramic Shards damage type Sharp -> Normal
		// ▪ Ceramic Explosion damage type Shatter -> Normal

        
    }
}
