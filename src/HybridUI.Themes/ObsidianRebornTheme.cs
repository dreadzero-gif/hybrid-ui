using Microsoft.Xna.Framework;
using HybridUI.Core.Themes;

namespace HybridUI.Themes
{
    public class ObsidianRebornTheme : ITheme
    {
        public string Name => "Obsidian Reborn";

        public Color PrimaryColor => new(40, 40, 48);
        public Color SecondaryColor => new(60, 60, 70);
        public Color AccentColor => new(120, 120, 140);
        public Color BackgroundColor => new(10, 10, 12);
    }
}
