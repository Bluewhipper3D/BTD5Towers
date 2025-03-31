using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Data.Behaviors.Projectiles;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;

namespace BTD5Towers.BTD5DartMonkey.Upgrades.Middle.RazorSharpShots
{
    internal class RazorSharpShots : ModUpgrade<BTD5DartMonkey>
    {
        public override int Path => MIDDLE;

        public override string DisplayName => "Razor Sharp Shots";

        public override int Tier => 2;

        public override string Description => "Can pop 2 extra bloons per shot";

        public override int Cost => 170;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectilemodel = weaponModel.projectile;

            projectilemodel.pierce += 2;
        }
    }
}
