using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;

namespace BTD5Towers.BTD5DartMonkey.Upgrades.Middle.TripleDarts
{
    internal class TripleDarts : ModUpgrade<BTD5DartMonkey>
    {
        public override int Path => MIDDLE;

        public override string DisplayName => "Triple Darts";

        public override int Tier => 3;

        public override string Description => "Throws three darts at a time instead of one.";

        public override int Cost => 330;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectilemodel = weaponModel.projectile;

            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 3, 0, 30, null, false, false);
        }
    }
}
