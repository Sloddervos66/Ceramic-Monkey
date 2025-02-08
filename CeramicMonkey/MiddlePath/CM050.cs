using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.MiddlePath;

public class CM050 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 20_000;
    public override string DisplayName => "Cataclysmic Desecration";
    public override string Description => "Status Grip slows more, improves status effects +100%, and applies to all targets on screen for 12 seconds. Increased main attack pierce.";
    public override int Path => MIDDLE;
    public override int Tier => 5;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Status Grip status effect vulnerability +50% -> +100%, Bloon slow 35% -> 66%, MOAB-class Bloon slow 15% -> 40%, now affects entire screen for 12s and reapplies every second
        towerModel.GetWeapon().projectile.pierce = 20;
    }
}
