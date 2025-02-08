using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Il2CppAssets.Scripts.Models.ServerEvents.QuickMatchSkuSettings;

namespace CeramicMonkey.CeramicMonkeyTower.TopPath;

public class CM400 : ModUpgrade<CeramicMonkeyTower>
{
    public override int Cost => 7560;
    public override string Description => "Ceramic Monkey can now turn MOABs and BFBs into ceramic over a period of time, leaving their transformed ceramic pieces all over the track.";
    public override string DisplayName => "Massive Phenomena";

    public override int Path => TOP;

    public override int Tier => 4;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // ▪ Ceramic Explosion can now target MOABs and BFBs. MOABs take 5s and BFBs take 12s to transform from full health. Damaging the blimps speeds up this process. They leave MOAB Pieces on the track if their MOAB layer is destroyed within range. Affected blimps gradually slow down as they're transformed, starting at a 20% slow all the way to 80%. Does not stack with itself.
		// ▫ MOAB Pieces: 25 pierce and 50 damage for MOABs, 40 pierce and 60 damage for BFBs. Disappear after one round.
    }
}
