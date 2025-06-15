using Terraria.ModLoader;

namespace ScarletSun.Common.MagicSystem
{
    internal class MagicProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.friendly = true;

            //Alright, so we'll come back to this class later.

        }

        public override void AI()
        {
            base.AI();
            //This is where we'll put all the custom AI
        }
    }
}
