using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Simulation.Artifacts.Behaviors;

namespace BTD5Towers.BTD5DartMonkey.Upgrades
{
    internal class LongRangeDarts : ModUpgrade<BTD5DartMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 1;

        public override string DisplayName => "Long Range Darts";

        public override int Cost => 90;

        public override string Description => "Makes the dart monkey shoot further than normal.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectilemodel = weaponModel.projectile;

            towerModel.range = 40;
            attackModel.range = 40;

        }
    }
}
