using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;

namespace BTD5Towers.BTD5DartMonkey.Upgrades.Middle.Spike_O_Pult
{
    internal class Spike_O_Pult : ModUpgrade<BTD5DartMonkey>
    {
        public override int Path => TOP;

        public override string DisplayName => "Spike-O-Pult";

        public override int Tier => 3;

        public override string Description => "Converts the Dart Monkey into a Spike-O-Pult, a powerful tower that hurls a large spiked ball instead of darts. Good range but slower attack speed. Each ball can pop 18 bloons.";

        public override int Cost => 500;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectilemodel = weaponModel.projectile;

            weaponModel.rate = 1.54F;
            projectilemodel.pierce += 17;
        }
    }
}
