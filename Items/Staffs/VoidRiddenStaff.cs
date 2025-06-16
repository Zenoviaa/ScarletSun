using ScarletSun.Common.MagicSystem;
using ScarletSun.Items.Elements;

namespace ScarletSun.Items.Staffs
{
    internal class VoidRiddenStaff : Staff
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            //For testing purposes
            Element = new Radiant();
        }
    }
}
