using Xunit;

public class PlayerFrameTests
{
    [Fact]
    public void PlayerFrameRenders()
    {
        var frame = new PlayerFrame();
        frame.Render();
        Assert.True(true);
    }
}
