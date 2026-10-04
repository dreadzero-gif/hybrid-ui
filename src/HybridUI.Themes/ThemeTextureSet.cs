namespace HybridUI.Themes
{
    public class ThemeTextureSet
    {
        public string FrameTexture;
        public string BarTexture;
        public string GaugeTexture;

        public ThemeTextureSet(string frame, string bar, string gauge)
        {
            FrameTexture = frame;
            BarTexture = bar;
            GaugeTexture = gauge;
        }
    }
}
