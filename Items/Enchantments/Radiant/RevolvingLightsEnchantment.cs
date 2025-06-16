using Microsoft.Xna.Framework;
using ScarletSun.Common.MagicSystem;
using Terraria;

namespace ScarletSun.Items.Enchantments.Radiant
{
    internal class RevolvingLightsEnchantment : Enchantment
    {
        public override void AI(MagicProjectile mProj)
        {
            base.AI(mProj);
            Projectile projectile = mProj.Projectile;
            projectile.velocity = projectile.velocity.RotatedBy(MathHelper.ToRadians(1));
        }
    }
}
