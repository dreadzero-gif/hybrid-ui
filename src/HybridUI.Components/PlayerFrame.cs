using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using HybridUI.Core.Themes;

namespace HybridUI.Components
{
    public class PlayerFrame : IHUDComponent
    {
        public Vector2 Position = new(50, 50);
        public Color FrameColor = Color.White;

        public void ApplyTheme(ITheme theme)
        {
            FrameColor = theme.PrimaryColor;
        }

        public void Update(GameTime time)
        {
            // Future: HP updates, animations, etc.
        }

        public void Render()
        {
            // Placeholder render — real rendering will use Blish HUD or standalone renderer
        }
    }
}
