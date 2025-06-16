using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ScarletSun.Common.Helpers;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace ScarletSun.Common.MagicSystem.UI
{
    internal class EnchantingPanelBackground : UIElement
    {
        private readonly float _scale;
        internal EnchantingPanelBackground(float scale = 1f)
        {
            _scale = scale;

            string texturePath = GetType().DirectoryHere() + "/EnchantingMenu";
            BackgroundAsset = ModContent.Request<Texture2D>(texturePath, ReLogic.Content.AssetRequestMode.ImmediateLoad);

            texturePath = GetType().DirectoryHere() + "/EnchantingBackground";
            FullBackgroundAsset = ModContent.Request<Texture2D>(texturePath, ReLogic.Content.AssetRequestMode.ImmediateLoad);
            Width.Set(BackgroundAsset.Width() * scale, 0f);
            Height.Set(BackgroundAsset.Height() * scale, 0f);
        }
        public Asset<Texture2D> FullBackgroundAsset { get; private set; }
        public Asset<Texture2D> BackgroundAsset { get; private set; }
        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            float oldScale = Main.inventoryScale;
            Main.inventoryScale = _scale;
            Rectangle rectangle = GetDimensions().ToRectangle();

            //Draw Backing
            Vector2 pos = rectangle.TopLeft();

            //Draw the background and then draw the item icon
            Texture2D value = BackgroundAsset.Value;
            Vector2 centerPos = pos + rectangle.Size() / 2f;

            Vector2 drawOrigin = FullBackgroundAsset.Size() * 0.5f;
    
            spriteBatch.Draw(FullBackgroundAsset.Value, centerPos, null, Color.Lerp(Color.White, Color.Black,0.5f), 0f, drawOrigin, _scale, SpriteEffects.None, 0f);
            spriteBatch.Draw(value, rectangle.TopLeft(), null, Color.White, 0f, default(Vector2), _scale, SpriteEffects.None, 0f);
            Main.inventoryScale = oldScale;
        }
    }
}
