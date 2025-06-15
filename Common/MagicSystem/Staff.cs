using Terraria.ModLoader;

namespace ScarletSun.Common.MagicSystem
{
    internal abstract class Staff : ModItem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();

            //Set some defaults for the staff
            Item.damage = 9;
            Item.DamageType = DamageClass.Magic;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.autoReuse = true;
        }
    }
}
