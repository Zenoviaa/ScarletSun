using ScarletSun.Common.MagicSystem.UI;
using System;
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
        private List<Item> _enchantmentItems;
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

        public List<Item> EnchantmentItems
        {
            get
            {
                if (_enchantmentItems == null)
                    _enchantmentItems = new List<Item>();
                return _enchantmentItems;
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
        internal void SetEnchantmentAtIndex(Item item, int index)
        {
            if (EnchantmentItems.Count > index)
            {
                EnchantmentItems[index] = item;
            }
            else
            {
                EnchantmentItems.Insert(index, item);
            }
        }

        internal Item GetEnchantmentAtIndex(int index)
        {          
            if(EnchantmentItems.Count > index)
            {
                Item item = EnchantmentItems[index];
                if(item == null)
                {
                    Item airItem = new Item();
                    airItem.SetDefaults(0);
                    EnchantmentItems[index] = airItem;
                    return airItem;
                }
                else
                {
                    return item;
                }
            }
            Item airItem2 = new Item();
            airItem2.SetDefaults(0);
            EnchantmentItems.Insert(index, airItem2);
            return airItem2;
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
