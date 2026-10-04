using Microsoft.Xna.Framework;
using HybridUI.Core.Themes;

namespace HybridUI.Themes
{
    public class AzureRebornTheme : ITheme
    {
        public string Name => "Azure Reborn";

        public Color PrimaryColor => new(78, 168, 222);
        public Color SecondaryColor => new(120, 200, 255);
        public Color AccentColor => new(160, 220, 255);
        public Color BackgroundColor => new(15, 18, 24);
    }
}
