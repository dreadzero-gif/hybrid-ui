using Microsoft.Xna.Framework;
using HybridUI.Core.Themes;

namespace HybridUI.Components
{
    public class BuffBar : IHUDComponent
    {
        public Vector2 Position = new(400, 50);
        public Color BarColor = Color.White;

        public void ApplyTheme(ITheme theme)
        {
            BarColor = theme.PrimaryColor;
        }

        public void Update(GameTime time)
        {
            // Future: buff tracking
        }

        public void Render()
        {
            // Placeholder render
        }
    }
}
