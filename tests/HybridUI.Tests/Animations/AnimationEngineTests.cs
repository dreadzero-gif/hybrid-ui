using Xunit;

public class AnimationEngineTests
{
    [Fact]
    public void CanAddAnimation()
    {
        AnimationEngine.Add(new PulseAnimation(0.5f));
        Assert.True(AnimationEngine.ActiveAnimations.Count > 0);
    }
}
