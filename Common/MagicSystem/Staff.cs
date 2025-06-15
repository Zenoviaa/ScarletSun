using ScarletSun.Common.MagicSystem.UI;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScarletSun.Common.MagicSystem
{
    internal abstract class Staff : ModItem
    {
        private Element _element;
        private List<Enchantment> _enchantments;
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

        public List<Enchantment> Enchantments
        {
            get
            {
                if (_enchantments == null)
                    _enchantments = new List<Enchantment>();
                return _enchantments;
            }
        }
        public override void SetDefaults()
        {
            base.SetDefaults();

            //Set some defaults for the staff
            Item.damage = 9;
            Item.DamageType = DamageClass.Magic;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.useStyle = ItemUseStyleID.Thrust;
            Item.autoReuse = true;

            //Shoot magic projectile of course
            Item.mana = 10;
            Item.shootSpeed = 10;
            Item.shoot = ModContent.ProjectileType<MagicProjectile>();
        }
        public virtual int GetNormalSlotCount()
        {
            return 5;
        }

        public virtual int GetTimedSlotCount()
        {
            return 2;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override bool ConsumeItem(Player player) => false;

        public override void RightClick(Player player)
        {
            base.RightClick(player);
            ModContent.GetInstance<MagicUISystem>().OpenUI(this);
        }
    }
}
