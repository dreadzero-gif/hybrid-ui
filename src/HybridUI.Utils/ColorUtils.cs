using Microsoft.Xna.Framework;

namespace HybridUI.Utils
{
    public static class ColorUtils
    {
        public static Color Lerp(Color a, Color b, float t)
        {
            return new Color(
                (byte)(a.R + (b.R - a.R) * t),
                (byte)(a.G + (b.G - a.G) * t),
                (byte)(a.B + (b.B - a.B) * t),
                (byte)(a.A + (b.A - a.A) * t)
            );
        }

        public static Color WithAlpha(Color color, float alpha)
        {
            return new Color(color.R, color.G, color.B, (byte)(alpha * 255));
        }
    }
}
