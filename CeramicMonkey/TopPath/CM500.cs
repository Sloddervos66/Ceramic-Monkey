using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using NAudio.Codecs;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicMonkey.CeramicMonkeyTower.TopPath;

public class CM500 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 45_000;
    public override string Description => "This tower can now target all MOAB-class Bloons. Increased Ceramic Shards damage and pierce and increased attack speed and range.";
    public override string DisplayName => "Groundbreaking Assault";

    public override int Path => TOP;

    public override int Tier => 5;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Ceramic Explosion can now target all MOAB-class Bloons (MOAB 5s, BFB 12s, DDTs 10s, ZOMGs 20s, BAD 30s)
		// ▫ MOAB Pieces: 25 pierce and 50 damage for MOABs, 40 pierce and 60 damage for BFBs, 50 pierce and 55 damage for DDTs, 80 pierce and 110 damage for ZOMGs, 130 pierce and 200 damage for BADs
		// ▪ Ceramic Shards damage 1 -> 10 (+1 -> +10 Ceramic or Fortified), 2 -> 20 pierce
        towerModel.GetAttackModel().weapons[0].rate = 0.5f;
        towerModel.GetAttackModel().range = 50;
        towerModel.range = 50;
    }
}
