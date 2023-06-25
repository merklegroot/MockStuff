using FluentAssertions;
using Moq;
using SomeLib;

namespace SomeLibTests;

public class SomeWorkflowTests
{
    [Fact]
    public void Should_use_some_nice_decimals()
    {
        var someLogic = new Mock<SomeLogic>();
        someLogic.Setup(mock => mock.DoStuff(It.IsAny<int>()))
            .Returns((int source) => 3 * source);

        new SomeWorkflow(someLogic.Object)
            .BetterWithDecimalPoints(5)
            .Should()
            .Be("15.00");
    }
}
