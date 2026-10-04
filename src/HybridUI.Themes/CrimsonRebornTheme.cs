using Microsoft.Xna.Framework;
using HybridUI.Core.Themes;

namespace HybridUI.Themes
{
    public class CrimsonRebornTheme : ITheme
    {
        public string Name => "Crimson Reborn";

        public Color PrimaryColor => new(196, 68, 68);
        public Color SecondaryColor => new(220, 100, 100);
        public Color AccentColor => new(255, 140, 140);
        public Color BackgroundColor => new(24, 12, 12);
    }
}
