using System.IO;
using System.Text.Json;
using HybridUI.Core.Presets;

namespace HybridUI.Presets
{
    public static class ESOPreset
    {
        public static UIPreset Load()
        {
            var json = File.ReadAllText("src/HybridUI.Presets/ESOPreset.json");
            return JsonSerializer.Deserialize<UIPreset>(json);
        }
    }
}
