using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using CeramicMonkey.Logging;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Effects;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Unity;

namespace CeramicMonkey.CeramicMonkeyTower;

public class CeramicMonkeyTower : ModTower
{
    public override TowerSet TowerSet => TowerSet.Magic;
    public override string BaseTower => "SniperMonkey-010";
    public override int Cost => 750;
    public override string DisplayName => "Ceramic Monkey";
    public override string Description => "The spirit inhabiting these ceramic statues will not leave so easily once it arrives. Targets Bloons within range and transforms their layers into brittle ceramic, shattering them in an explosion. Can detect Camo Bloons.";
    public override int TopPathUpgrades => 5;
    public override int MiddlePathUpgrades => 5;
    public override int BottomPathUpgrades => 5;
    public int Pierce { get; set; } = 5;

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        towerModel.RemoveBehavior<AttackModel>();
        towerModel.towerSize = TowerModel.TowerSize.medium;

        // Main attack
        AttackModel ceramicExplosion = CreateCeramicExplosion();

        // Ceramic shards
        CreateProjectileOnContactModel ceramicShards = CreateCeramicShards();
        ceramicExplosion.weapons[0].projectile.AddBehavior(ceramicShards);

        // Set the weapon to the actual tower;
        towerModel.AddBehavior(ceramicExplosion);
        towerModel.range = 35;

        // Replace attack model with sniper
        AttackModel attackModel = towerModel.GetAttackModel();
        SwapAttackModelBehaviour(attackModel);
    }

    public override bool IsValidCrosspath(params int[] tiers) =>
        ModHelper.HasMod("UltimateCrosspathing") || base.IsValidCrosspath(tiers);

    private static AttackModel CreateCeramicExplosion()
    {
        WeaponModel psiWeaponModel = Game.instance.model.GetTowerFromId("Psi 20").GetAttackModel().weapons[0].Duplicate();
        EjectEffectModel effectModel = psiWeaponModel.GetBehavior<EjectEffectModel>();
        effectModel.fullscreen = Fullscreen.No;

        //EjectEffectModel ejectEffectModel = new EjectEffectModel("", effectModel, 0.5f, Fullscreen.No, true, false, false, true);

        AttackModel attack = Game.instance.model.GetTower(TowerType.DartMonkey, 0, 0, 0).GetAttackModel().Duplicate();
        WeaponModel weapon = attack.weapons[0];
        weapon.Rate = 0.8f;
        weapon.AddBehavior(effectModel);

        ProjectileModel projectile = weapon.projectile;
        projectile.pierce = 1;
        projectile.GetDamageModel().damage = 1;
        projectile.SetHitCamo(true);

        return attack;
    }

    private static CreateProjectileOnContactModel CreateCeramicShards()
    {
        ProjectileModel iceProjectile = Game.instance.model.GetTower(TowerType.IceMonkey, 3, 0, 0).GetWeapons()[0].projectile.Duplicate();

        AddBehaviorToBloonModel shardsEffect = iceProjectile.GetBehavior<AddBehaviorToBloonModel>();
        EmitOnPopModel emitShards = shardsEffect.GetBehavior<EmitOnPopModel>();

        ProjectileModel iceShard = emitShards.projectile.Duplicate();
        iceShard.GetDamageModel().damage = 1;
        iceShard.pierce = 2;

        TravelStraitModel travelModel = iceShard.GetBehavior<TravelStraitModel>();
        travelModel.Speed = 160;
        travelModel.Lifespan = 0.2f;

        return new CreateProjectileOnContactModel("", iceShard, new ArcEmissionModel("ArcEmissionModel_", 8, 0, 45, null, false, false), true, false, false);
    }

    private static void SwapAttackModelBehaviour(AttackModel attackModel)
    {
        foreach(var behaviour in attackModel.behaviors)
        {
            attackModel.RemoveBehavior(behaviour);
        }

        foreach(var behaviour in Game.instance.model.GetTower(TowerType.SniperMonkey, 0, 1, 0).GetAttackModel().behaviors.Duplicate())
        {
            attackModel.AddBehavior(behaviour);
        }
    }

    private static void PsiAttackModel()
    {
        /*
         * Psi Main Attack behaviours
         * 
            [10:00:45.723] [CeramicMonkey] Behavior: RotateToTargetModel_ (Il2CppAssets.Scripts.Models.Model)
            [10:00:45.723] [CeramicMonkey] Behavior: TargetFirstModel_ (Il2CppAssets.Scripts.Models.Model)
            [10:00:45.723] [CeramicMonkey] Behavior: TargetLastModel_ (Il2CppAssets.Scripts.Models.Model)
            [10:00:45.723] [CeramicMonkey] Behavior: TargetCloseModel_ (Il2CppAssets.Scripts.Models.Model)
            [10:00:45.723] [CeramicMonkey] Behavior: TargetStrongModel_ (Il2CppAssets.Scripts.Models.Model)
            [10:00:45.723] [CeramicMonkey] Behavior: AttackFilterModel_ (Il2CppAssets.Scripts.Models.Model)
            [10:00:45.723] [CeramicMonkey] Behavior: DisplayModel_AttackDisplay (Il2CppAssets.Scripts.Models.Model)

         * Psi weapon behaviours
         * 
            [10:03:14.290] [CeramicMonkey] Behavior: PsiLimitProjectileModel_ (Il2CppAssets.Scripts.Models.Model)
            [10:03:14.291] [CeramicMonkey] Behavior: EjectEffectModel_ (Il2CppAssets.Scripts.Models.Model)

         * Psi projectile behaviours
         * 
            [10:26:13.597] [CeramicMonkey] Behavior: ProjectileFilterModel_BaseProjectile (Il2CppAssets.Scripts.Models.Model)
            [10:26:13.597] [CeramicMonkey] Behavior: AgeModel_BaseProjectile (Il2CppAssets.Scripts.Models.Model)
            [10:26:13.597] [CeramicMonkey] Behavior: PsiEffectModel_ (Il2CppAssets.Scripts.Models.Model)
            [10:26:13.598] [CeramicMonkey] Behavior: CreateProjectileOnContactModel_ (Il2CppAssets.Scripts.Models.Model)
            [10:26:13.598] [CeramicMonkey] Behavior: DisplayModel_ProjectileDisplay (Il2CppAssets.Scripts.Models.Model)

         * Psi projectileOnContact behaviours
         * 
            [10:28:33.084] [CeramicMonkey] Behavior: ProjectileFilterModel_BaseProjectileSplash (Il2CppAssets.Scripts.Models.Model)
            [10:28:33.086] [CeramicMonkey] Behavior: AgeModel_BaseProjectileSplash (Il2CppAssets.Scripts.Models.Model)
            [10:28:33.086] [CeramicMonkey] Behavior: PsiEffectModel_ (Il2CppAssets.Scripts.Models.Model)
            [10:28:33.086] [CeramicMonkey] Behavior: DisplayModel_ProjectileDisplay (Il2CppAssets.Scripts.Models.Model)
        */
    }
}
