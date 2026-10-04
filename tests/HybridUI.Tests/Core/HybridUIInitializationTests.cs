using Xunit;

public class HybridUIInitializationTests
{
    [Fact]
    public void FrameworkInitializesWithoutError()
    {
        HybridUI.Initialize();
        Assert.True(HybridUI.IsInitialized);
    }
}
