using ScarletSun.Common.MagicSystem;
using ScarletSun.Items.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScarletSun.Items.Staffs
{
    internal class CelestiaWand : Staff
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            //For testing purposes
            Element = new Radiant();
        }
    }
}
