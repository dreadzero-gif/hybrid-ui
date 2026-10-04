namespace HybridUI.Core
{
    public static class HybridUI
    {
        public static void Initialize()
        {
            ThemeManager.LoadBuiltInThemes();
            PresetManager.LoadBuiltInPresets();
            AnimationManager.Initialize();
        }
    }
}
