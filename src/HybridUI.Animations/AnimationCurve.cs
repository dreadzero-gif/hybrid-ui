namespace HybridUI.Animations
{
    public static class AnimationCurve
    {
        public static float EaseIn(float t)
        {
            return t * t;
        }

        public static float EaseOut(float t)
        {
            return 1f - (1f - t) * (1f - t);
        }

        public static float EaseInOut(float t)
        {
            return t < 0.5f
                ? 2f * t * t
                : 1f - Mathf.Pow(-2f * t + 2f, 2f) / 2f;
        }
    }

    public static class Mathf
    {
        public static float Pow(float f, float p)
        {
            return (float)System.Math.Pow(f, p);
        }
    }
}
