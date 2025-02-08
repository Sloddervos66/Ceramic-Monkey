using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.BottomPath;

public class CM005 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 32_000;
    public override string DisplayName => "Intimate Bond";
    public override string Description => "Main attack now conducts itself on MOABs, damaging them constantly until destruction. Main attack of it and other monkeys have increased MOAB damage.";
    public override int Path => BOTTOM;
    public override int Tier => 5;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Ceramic Explosion +20 MOAB damage, other monkeys +5 MOAB Damage
		// ▪ Adds Ceramic Explosion Conduction
		// ▫ Ceramic Explosion Conduction: 30 MOAB damage every 0.5s for 10s.
    }
}
