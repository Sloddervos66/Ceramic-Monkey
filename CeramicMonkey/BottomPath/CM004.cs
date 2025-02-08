using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.BottomPath;

public class CM004 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 9100;
    public override string DisplayName => "Shared Infestation";
    public override string Description => "Monkeys within range are turned into ceramic, allowing it to attack Bloons within their range and adding Shatter to affected monkeys' attacks. Increased MOAB damage in radius.";
    public override int Path => BOTTOM;
    public override int Tier => 4;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Ceramic Monkey can attack Bloons within range of transformed monkeys and MOAB-class Bloons take 10 damage every 0.2s when they're within radius of any affected Monkeys.
    }
}
