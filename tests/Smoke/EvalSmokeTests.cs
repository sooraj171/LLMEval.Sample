using LLMEval;

namespace Smoke;

public class EvalSmokeTests
{
    [Fact]
    public async Task Exact_Passes()
    {
        var result = await Eval.Direct()
            .Exact(actual: "Paris", expected: "Paris")
            .WithThreshold(1.0)
            .EvaluateAsync();

        result.ShouldPass();
    }

    [Fact]
    public async Task Keyword_Passes()
    {
        var result = await Eval.Direct()
            .Keyword(actual: "Paris is the capital of France", expected: "Paris France")
            .WithThreshold(0.5)
            .EvaluateAsync();

        result.ShouldPass();
    }

    [Fact]
    public async Task Semantic_TfIdf_RunsWithoutApiKey()
    {
        var result = await Eval.Direct()
            .Semantic(actual: "Paris", expected: "Paris")
            .WithThreshold(0.3)
            .EvaluateAsync();

        result.ShouldPass();
        Assert.Equal("semantic", result.MetricName);
    }
}
