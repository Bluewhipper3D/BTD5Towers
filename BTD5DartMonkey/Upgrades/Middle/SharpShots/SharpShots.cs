using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;

namespace BTD5Towers.BTD5DartMonkey.Upgrades.Middle.SharpShots
{
    internal class SharpShots : ModUpgrade<BTD5DartMonkey>
    {
        public override int Path => MIDDLE;

        public override string DisplayName => "Sharp Shots";

        public override int Tier => 1;

        public override string Description => "Can pop 1 extra bloon per shot.";

        public override int Cost => 140;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectilemodel = weaponModel.projectile;

            projectilemodel.pierce += 1;
        }
    }
}
