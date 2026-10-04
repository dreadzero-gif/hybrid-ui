namespace HybridUI.Utils
{
    public static class TextureUtils
    {
        public static string Resolve(string textureName)
        {
            // Future: resolve texture paths from theme or asset folder
            return $"assets/textures/{textureName}.png";
        }
    }
}
