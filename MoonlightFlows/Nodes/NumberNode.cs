using MoonlightFlows.Values;

namespace MoonlightFlows.Nodes;

public class NumberNode : ExecNode
{
    public int Data { get; set; }
    
    public override Task<ExecValue?> Execute(object?[] values)
    {
        return Task.FromResult<ExecValue>(new NumberValue()
        {
            Data = Data
        })!;
    }
}