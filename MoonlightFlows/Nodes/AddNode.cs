using MoonlightFlows.Values;

namespace MoonlightFlows.Nodes;

public class AddNode : ExecNode
{
    public override Task<ExecValue?> Execute(object?[] values)
    {
        if (values.Length != 2)
            throw new Exception("Provide two numbers");

        if (values[0] is NumberValue value1 && values[1] is NumberValue value2)
        {
            return Task.FromResult<ExecValue?>(new NumberValue()
            {
                Data = value1.Data + value2.Data
            });
        }

        return Task.FromResult<ExecValue?>(null);
    }
}