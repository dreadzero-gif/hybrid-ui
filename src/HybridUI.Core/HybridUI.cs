using HybridUI.Core.Themes;
using HybridUI.Core.Presets;
using HybridUI.Core.Animations;

namespace HybridUI.Core
{
    public static class HybridUI
    {
        public static bool Initialized { get; private set; }

        public static void Initialize()
        {
            if (Initialized)
                return;

            ThemeManager.LoadBuiltInThemes();
            PresetManager.LoadBuiltInPresets();
            AnimationManager.Initialize();

            Initialized = true;
        }
    }
}
