namespace MoonlightFlows;

public class FlowInterpreter
{
    private readonly Flow Flow;
    
    public FlowInterpreter(Flow flow)
    {
        Flow = flow;
    }

    public async Task Execute()
    {
        if (Flow.StartNode == null)
            throw new Exception("No start node specified");

        await Flow.StartNode.DispatchExecution(0);
    }
}