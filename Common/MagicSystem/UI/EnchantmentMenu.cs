using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Audio;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.UI.Elements;
using Terraria.ModLoader;
using ScarletSun.Common.Helpers;
using System.Collections;

namespace ScarletSun.Common.MagicSystem.UI
{
    internal class EnchantmentMenu : UIPanel
    {
        private Texture2D _enchantmentPanel;
        private StaffEditingContext _ctx;
        private UIGrid _grid;
        private EnchantingPanelBackground _background;

        private StaffSlot _staffSlot;
        private ElementSlot _elementSlot;
        internal EnchantmentMenu() : base()
        {
            _grid = new UIGrid();
         
            _background = new EnchantingPanelBackground();
            _elementSlot = new ElementSlot();   
            _staffSlot = new StaffSlot();
        }

        internal int RelativeLeft => Main.screenWidth / 2 - (int)Width.Pixels / 2;
        internal int RelativeTop => Main.screenHeight / 2 - (int)Height.Pixels / 2;

        public void UseContext(StaffEditingContext ctx)
        {
            _ctx = ctx;
            _grid.Clear();
            for (int i = 0; i < ctx.staffToEdit.GetNormalSlotCount(); i++)
            {
                var slot = new EnchantmentSlot(index: _grid._items.Count, isTimedSlot: false);
                slot.SetContext(ctx);
                _grid.Add(slot);
            }

            for (int i = 0; i < ctx.staffToEdit.GetTimedSlotCount(); i++)
            {
                var slot = new EnchantmentSlot(index: _grid._items.Count, isTimedSlot: true);
                slot.SetContext(ctx);
       
                _grid.Add(slot);
            }
            _grid.Recalculate();

            _staffSlot.SetContext(ctx);
            _elementSlot.SetContext(ctx);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _enchantmentPanel = ModContent.Request<Texture2D>(GetType().DirectoryHere() + $"/EnchantingMenu", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value;

        }

        public override void OnInitialize()
        {
            base.OnInitialize();
            Width.Pixels = 704;
            Height.Pixels = 704;
            Left.Pixels = RelativeLeft;
            Top.Pixels = RelativeTop;
            BackgroundColor = Color.Transparent;
            BorderColor = Color.Transparent;


            Append(_background);

            _grid.Width.Set(0, 0.9f);
            _grid.Height.Set(0, 0.4f);
            _grid.HAlign = 0.5f;
            _grid.VAlign = 0.9f;
            _grid.ListPadding = 2f;   
            Append(_grid);

            _staffSlot.HAlign = 0.05f;
            _staffSlot.VAlign = 0.05f;
            Append(_staffSlot);

            _elementSlot.HAlign = 0.25f;
            _elementSlot.VAlign = 0.38f;
            Append(_elementSlot);

            SetPos();
        }


        public override void OnDeactivate()
        {
            base.OnDeactivate();
            if (!Main.gameMenu)
            {
                SoundEngine.PlaySound(SoundID.MenuClose);
            }
        }


        private void SetPos()
        {
            Left.Pixels = RelativeLeft;
            Top.Pixels = RelativeTop;



        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            //Constantly lock the UI in the position regardless of resolution changes
            SetPos();
        }
    }
}
