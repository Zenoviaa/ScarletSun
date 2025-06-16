using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameInput;
using Terraria.UI;

namespace ScarletSun.Common.MagicSystem.UI
{
    internal class EnchantmentMenuUIState : UIState
    {
        public EnchantmentMenu enchantmentMenu;
        public EnchantmentMenuUIState() : base()
        {

        }

        public override void OnInitialize()
        {
            enchantmentMenu = new EnchantmentMenu();
            Append(enchantmentMenu);
        }

        public override void Recalculate()
        {
            base.Recalculate();
            if (enchantmentMenu == null)
                return;

            //Resize the main panels height based on resolution
            //Recalculate size of the UI based on the resolution, so it's dynamic
            const float size = 706;
            float subHeight = Main.screenHeight - 240f;
            float targetSize = Math.Min(subHeight, size);
            enchantmentMenu.Height.Pixels = targetSize;
            enchantmentMenu.Width.Pixels = targetSize;
            Console.WriteLine(subHeight);
         
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            Recalculate();
        }
    }
}
