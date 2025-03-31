using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Mods;
using Il2CppSystem.Linq;

namespace BTD5Towers.BTD5DartMonkey.Upgrades.Top.Juggernaut
{
    internal class Juggernaut : ModUpgrade<BTD5DartMonkey>
    {
        public override int Path => TOP;

        public override string DisplayName => "Juggernaut";

        public override int Tier => 4;

        public override string Description => "Hurls a giant unstoppable killer spiked ball that can pop lead blons and excels at crushing ceramic bloons.";

        public override int Cost => 1500;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectilemodel = weaponModel.projectile;

            projectilemodel.GetDamageModel().damage = 5;
            projectilemodel.pierce += 82;

            towerModel.range = 53;
            attackModel.range = 53;
        }
    }
}
