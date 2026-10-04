using Blish_HUD;
using Microsoft.Xna.Framework;
using HybridUI.Components;

namespace HybridUI.BlishHUD
{
    public class BlishHUDAdapter
    {
        public static void AttachComponent(IHUDComponent component)
        {
            GameService.Graphics.SpriteScreen.AddDrawCallback((spriteBatch) =>
            {
                component.Render();
            });

            GameService.Graphics.SpriteScreen.AddUpdateCallback((gameTime) =>
            {
                component.Update(gameTime);
            });
        }
    }
}
