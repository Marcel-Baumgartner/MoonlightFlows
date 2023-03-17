namespace MoonlightFlows.Nodes;

public class StartNode : ExecNode
{
    public override Task<ExecValue?> Execute(object?[] values)
    {
        return Task.FromResult<ExecValue?>(null);
    }
}