using Microsoft.Xna.Framework;
using HybridUI.Core.Themes;

namespace HybridUI.Components
{
    public class PartyFrame : IHUDComponent
    {
        public Vector2 Position = new(50, 200);
        public Color FrameColor = Color.White;

        public void ApplyTheme(ITheme theme)
        {
            FrameColor = theme.AccentColor;
        }

        public void Update(GameTime time)
        {
            // Future: party list updates
        }

        public void Render()
        {
            // Placeholder render
        }
    }
}
