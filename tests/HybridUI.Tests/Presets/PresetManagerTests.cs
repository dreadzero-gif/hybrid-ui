using Xunit;

public class PresetManagerTests
{
    [Fact]
    public void CanLoadPreset()
    {
        PresetManager.Load("Default");
        Assert.NotNull(PresetManager.CurrentPreset);
    }
}
