using Terraria.UI;

namespace ScarletSun.Common.MagicSystem.UI
{
    internal class InventoryMenu : UIElement
    {
        private InventoryBackground _inventoryBackground;
        public InventoryMenu()
        {
            _inventoryBackground = new InventoryBackground();
        }


        public override void OnInitialize()
        {
            base.OnInitialize();
            Width.Pixels = 428;
            Height.Pixels = 236;
            Append(_inventoryBackground);
        }
    }
}
