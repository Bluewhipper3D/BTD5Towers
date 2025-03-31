using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Data.Behaviors.Attacks;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using UnityEngine;

namespace BTD5Towers.BTD5DartMonkey.Upgrades.Top.EnhancedEyesight
{
    internal class EnhancedEyesight : ModUpgrade<BTD5DartMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 2;

        public override string DisplayName => "Enhanced Eyesight";

        public override int Cost => 120;

        public override string Description => "Increase attack range even further and allows Dart Monkey to shoot Camo Bloons";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectilemodel = weaponModel.projectile;

            towerModel.GetAttackModel().RemoveFilter<FilterInvisibleModel>();
            towerModel.GetAttackModel().weapons[0].projectile.SetHitCamo(true);

            towerModel.range = 48;
            attackModel.range = 48;
        }
    }
}
