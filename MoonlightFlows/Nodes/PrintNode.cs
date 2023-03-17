using MoonlightFlows.Values;

namespace MoonlightFlows.Nodes;

public class PrintNode : ExecNode
{
    public override Task<ExecValue?> Execute(object?[] values)
    {
        if (values.Length != 1)
            throw new Exception("One argument has to be passed");

        if (values[0] is NumberValue value)
        {
            Console.WriteLine("Output: " + value.Data);
        }

        return Task.FromResult<ExecValue?>(null);
    }
}