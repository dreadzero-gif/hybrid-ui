using Microsoft.Xna.Framework;

namespace HybridUI.Core.Themes
{
    public interface ITheme
    {
        string Name { get; }
        Color PrimaryColor { get; }
        Color SecondaryColor { get; }
        Color AccentColor { get; }
        Color BackgroundColor { get; }
    }
}
