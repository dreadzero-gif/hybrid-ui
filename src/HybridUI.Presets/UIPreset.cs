using System.Collections.Generic;

namespace HybridUI.Core.Presets
{
    public class UIPreset : IPreset
    {
        public string Name { get; set; }
        public Dictionary<string, PresetComponentConfig> Components { get; set; }

        public void Apply()
        {
            // In Blish HUD: apply positions to components
            // In standalone: apply layout to renderer
        }
    }

    public class PresetComponentConfig
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Scale { get; set; } = 1f;
        public bool Visible { get; set; } = true;
    }
}
