using Microsoft.Xna.Framework;
using HybridUI.Core.Themes;

namespace HybridUI.Components
{
    public class TargetFrame : IHUDComponent
    {
        public Vector2 Position = new(50, 120);
        public Color FrameColor = Color.White;

        public void ApplyTheme(ITheme theme)
        {
            FrameColor = theme.SecondaryColor;
        }

        public void Update(GameTime time)
        {
            // Future: target HP, breakbar, etc.
        }

        public void Render()
        {
            // Placeholder render
        }
    }
}
