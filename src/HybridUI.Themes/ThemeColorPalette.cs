using Microsoft.Xna.Framework;

namespace HybridUI.Themes
{
    public struct ThemeColorPalette
    {
        public Color Primary;
        public Color Secondary;
        public Color Accent;
        public Color Background;

        public ThemeColorPalette(Color primary, Color secondary, Color accent, Color background)
        {
            Primary = primary;
            Secondary = secondary;
            Accent = accent;
            Background = background;
        }
    }
}
