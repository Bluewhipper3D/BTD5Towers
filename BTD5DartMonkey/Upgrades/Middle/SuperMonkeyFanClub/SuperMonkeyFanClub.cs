using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Unity;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace BTD5Towers.BTD5DartMonkey.Upgrades.Middle.SuperMonkeyFanClub
{
    internal class SuperMonkeyFanClub : ModUpgrade<BTD5DartMonkey>
    {
        public override int Path => MIDDLE;

        public override string DisplayName => "Super Monkey Fan Club";

        public override int Tier => 4;

        public override string Description => "Super Monkey Fan Club Ability: Converts up to 10 nearby dart monkeys into Super Monkeys for 15 seconds.";

        public override int Cost => 8000;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectilemodel = weaponModel.projectile;

            AbilityModel ability = Game.instance.model.GetTower("DartMonkey", 0, 4, 0).GetAbility().Duplicate();

            //var ability = new AbilityModel("superMonkeyFanClub", "Super Monkey Fan Club", "Converts up to 10 nearby dart monkeys into Super Monkeys for 15 seconds.", 0, 0, GetSpriteReference(Icon), 50F, null, false, false, "", 0F, 0, 999999, false, false);

            towerModel.AddBehavior(ability);
        }
    }
}
