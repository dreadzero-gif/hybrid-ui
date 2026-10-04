namespace HybridUI.Utils
{
    public static class MathUtils
    {
        public static float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public static float Lerp(float a, float b, float t)
        {
            return a + (b - a) * t;
        }

        public static float Normalize(float value, float min, float max)
        {
            return (value - min) / (max - min);
        }
    }
}
