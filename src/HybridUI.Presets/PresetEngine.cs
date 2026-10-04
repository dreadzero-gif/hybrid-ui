using System.Collections.Generic;
using HybridUI.Core.Presets;

namespace HybridUI.Presets
{
    public static class PresetEngine
    {
        private static readonly Dictionary<string, UIPreset> _presets = new();

        public static void Register(UIPreset preset)
        {
            if (!_presets.ContainsKey(preset.Name))
                _presets.Add(preset.Name, preset);
        }

        public static UIPreset Get(string name)
        {
            return _presets.TryGetValue(name, out var preset) ? preset : null;
        }

        public static IEnumerable<UIPreset> AllPresets => _presets.Values;
    }
}
