namespace HybridUI.Core.Presets
{
    public interface IPreset
    {
        string Name { get; }
        void Apply();
    }
}
