using Terraria.ModLoader;

namespace ScarletSun.Common.MagicSystem
{
    internal abstract class Enchantment : ModItem
    {
        public bool isTimedEnchantment;
        public override void SetDefaults()
        {

        }
        public virtual void AI(MagicProjectile mProj)
        {

        }
    }
}
