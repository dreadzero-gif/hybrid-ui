using System.IO;
using System.Text.Json;
using HybridUI.Core.Presets;

namespace HybridUI.Presets
{
    public static class FF14Preset
    {
        public static UIPreset Load()
        {
            var json = File.ReadAllText("src/HybridUI.Presets/FF14Preset.json");
            return JsonSerializer.Deserialize<UIPreset>(json);
        }
    }
}
