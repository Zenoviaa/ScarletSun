using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
