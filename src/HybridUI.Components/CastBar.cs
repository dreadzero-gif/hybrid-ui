using Microsoft.Xna.Framework;
using HybridUI.Core.Themes;

namespace HybridUI.Components
{
    public class CastBar : IHUDComponent
    {
        public Vector2 Position = new(400, 120);
        public float CastProgress = 0f;
        public Color BarColor = Color.White;

        public void ApplyTheme(ITheme theme)
        {
            BarColor = theme.SecondaryColor;
        }

        public void Update(GameTime time)
        {
            // Future: cast progress updates
        }

        public void Render()
        {
            // Placeholder render
        }
    }
}
