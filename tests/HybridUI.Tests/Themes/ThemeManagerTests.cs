using Xunit;

public class ThemeManagerTests
{
    [Fact]
    public void CanSetTheme()
    {
        ThemeManager.SetTheme(new GoldRebornTheme());
        Assert.NotNull(ThemeManager.CurrentTheme);
    }
}
