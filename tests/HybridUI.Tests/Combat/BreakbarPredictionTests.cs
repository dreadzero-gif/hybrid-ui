using Xunit;

public class BreakbarPredictionTests
{
    [Fact]
    public void PredictsBreakbarPhase()
    {
        var prediction = BreakbarPrediction.GetNextPhase();
        Assert.NotNull(prediction);
    }
}
