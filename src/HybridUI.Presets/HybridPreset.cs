using System.IO;
using System.Text.Json;
using HybridUI.Core.Presets;

namespace HybridUI.Presets
{
    public static class HybridPreset
    {
        public static UIPreset Load()
        {
            var json = File.ReadAllText("src/HybridUI.Presets/HybridPreset.json");
            return JsonSerializer.Deserialize<UIPreset>(json);
        }
    }
}
