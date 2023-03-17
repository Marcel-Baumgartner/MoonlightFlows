namespace MoonlightFlows;

public abstract class ExecNode
{
    public List<ExecNode> Inputs { get; private set; }

    public ExecNode()
    {
        Inputs = new();
    }

    public abstract Task<ExecValue?> Execute(object?[] values);

    public async Task<ExecValue?> DispatchExecution(int stackId)
    {
        Console.Write($"[{stackId}] {this} -> ");
        
        List<ExecValue?> values = new();

        foreach (var execNode in Inputs)
        {
            values.Add(await execNode.DispatchExecution(stackId + 1));
        }

        return await Execute(values.ToArray());
    }
}