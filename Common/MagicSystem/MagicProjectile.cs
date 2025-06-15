using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ScarletSun.Common.Helpers;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScarletSun.Common.MagicSystem
{
    internal class MagicProjectile : ModProjectile
    {
        private List<Enchantment> _enchantments;
        private Element _element;

        public override string Texture => AssetHelper.EmptyTexture;
        public Element Element
        {
            get
            {
                if (_element == null)
                    _element = new NoElement();
                return _element;
            }
            set
            {
                _element = value;
            }
        }

        //Lazy loading so it's never null
        public List<Enchantment> Enchantments
        {
            get
            {
                if (_enchantments == null)
                    _enchantments = new List<Enchantment>();
                return _enchantments;
            }
        }

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            //Just in case we want to render trails, but I don't think we will need it.
            ProjectileID.Sets.TrailCacheLength[Type] = 8;
            ProjectileID.Sets.TrailingMode[Type] = 2;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.friendly = true;
        }

        public override void AI()
        {
            base.AI();
            //This is where we'll put all the custom AI         
            //Update the element ai first.
            Element.AI(this);
            for (int i = 0; i < Enchantments.Count; i++)
            {
                Enchantment enchantment = Enchantments[i];
                enchantment.AI(this);
            }

            //Just for testing to see if we're shooting anything
            if (Main.rand.NextBool(8))
            {
                Dust.NewDustPerfect(Projectile.position, DustID.GemDiamond);
            }
        }

        public override bool PreDraw(ref Color lightColor)
        {
            SpriteBatch spriteBatch = Main.spriteBatch;
            Element.DrawForm(this, spriteBatch, ref lightColor);
            return false;
        }
    }
}
