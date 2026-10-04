using System.Collections.Generic;
using HybridUI.Core.Presets;

namespace HybridUI.Core
{
    public static class PresetManager
    {
        private static readonly Dictionary<string, UIPreset> _presets = new();

        public static void RegisterPreset(UIPreset preset)
        {
            if (!_presets.ContainsKey(preset.Name))
                _presets.Add(preset.Name, preset);
        }

        public static UIPreset GetPreset(string name)
        {
            return _presets.TryGetValue(name, out var preset) ? preset : null;
        }

        public static void LoadBuiltInPresets()
        {
            RegisterPreset(FF14Preset.Load());
            RegisterPreset(ESOPreset.Load());
            RegisterPreset(MinimalistPreset.Load());
            RegisterPreset(HybridPreset.Load());
            RegisterPreset(RebornPreset.Load());
        }
    }
}
