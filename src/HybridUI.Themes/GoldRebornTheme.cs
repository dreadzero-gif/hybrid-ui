using Microsoft.Xna.Framework;
using HybridUI.Core.Themes;

namespace HybridUI.Themes
{
    public class GoldRebornTheme : ITheme
    {
        public string Name => "Gold Reborn";

        public Color PrimaryColor => new(232, 196, 106);
        public Color SecondaryColor => new(255, 240, 180);
        public Color AccentColor => new(255, 220, 140);
        public Color BackgroundColor => new(20, 20, 24);
    }
}
