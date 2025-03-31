using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;

namespace BTD5Towers.BTD5DartMonkey
{
    internal class BTD5DartMonkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Primary;

        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 200;

        public override string Description => "Shoots a single dart that pops a single bloon. A good, cheap tower suitable for the early rounds.";

        public override string DisplayName => "BTD5 Dart Monkey";

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectilemodel = weaponModel.projectile;

            towerModel.range = 32;
            attackModel.range = 32;

            weaponModel.rate = 0.9F;

            projectilemodel.pierce = 1;
            projectilemodel.GetDamageModel().damage = 1;
        }
    }
}
