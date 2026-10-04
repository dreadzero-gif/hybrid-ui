using Microsoft.Xna.Framework;

namespace HybridUI.Utils
{
    public static class LayoutUtils
    {
        public static Vector2 Center(Vector2 parentSize, Vector2 childSize)
        {
            return new Vector2(
                (parentSize.X - childSize.X) / 2f,
                (parentSize.Y - childSize.Y) / 2f
            );
        }

        public static Vector2 Offset(Vector2 basePos, float x, float y)
        {
            return new Vector2(basePos.X + x, basePos.Y + y);
        }
    }
}
