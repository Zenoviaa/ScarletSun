using ScarletSun.Common.MagicSystem;
using ScarletSun.Items.Elements;

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
