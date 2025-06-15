using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.GameContent.UI.Elements;

namespace ScarletSun.Common.MagicSystem.UI
{
    internal class EnchantmentMenu : UIPanel
    {
        private StaffEditingContext _ctx;
        public void UseContext(StaffEditingContext ctx)
        {
            _ctx = ctx;
        }
    }
}
