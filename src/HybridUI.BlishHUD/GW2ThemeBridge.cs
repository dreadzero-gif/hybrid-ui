using Blish_HUD;
using HybridUI.Core.Themes;

namespace HybridUI.BlishHUD
{
    public static class GW2ThemeBridge
    {
        public static void ApplyTheme(ITheme theme)
        {
            // Example: apply theme colors to Blish HUD UI elements
            GameService.Graphics.SpriteScreen.BackgroundColor = theme.BackgroundColor;
        }
    }
}
