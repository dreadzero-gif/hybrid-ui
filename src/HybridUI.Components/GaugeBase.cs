using Microsoft.Xna.Framework;
using HybridUI.Core.Themes;

namespace HybridUI.Components
{
    public abstract class GaugeBase : IHUDComponent
    {
        public Vector2 Position;
        public float Value;
        public Color GaugeColor = Color.White;

        public virtual void ApplyTheme(ITheme theme)
        {
            GaugeColor = theme.AccentColor;
        }

        public abstract void Update(GameTime time);
        public abstract void Render();
    }
}
