using System;
using Terraria;

namespace ScarletSun.Common.MagicSystem.UI
{
    internal class StaffEditingContext
    {
        public readonly Staff staffToEdit;
        public StaffEditingContext(Staff staff)
        {
            this.staffToEdit = staff;
        }

        internal void SetElement(Item item)
        {
         //   throw new NotImplementedException();
        }

        internal void SetEnchantment(Item item, int index)
        {
            //throw new NotImplementedException();
        }
    }
}
