namespace SomeLib;

public class SomeWorkflow
{
    private readonly SomeLogic _someLogic;

    public SomeWorkflow(SomeLogic someLogic) =>
        _someLogic = someLogic;

    public string BetterWithDecimalPoints(int source) =>
        _someLogic.DoStuff(source).ToString("0.00");
}