using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ScarletSun.Common.MagicSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScarletSun.Items.Elements
{
    internal class Radiant : Element
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
        }


        public override void DrawForm(MagicProjectile mProj, SpriteBatch spriteBatch, ref Color lightColor)
        {
            base.DrawForm(mProj, spriteBatch, ref lightColor);

        }
    }
}
