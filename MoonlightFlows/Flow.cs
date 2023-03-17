namespace MoonlightFlows;

public class Flow
{
    public List<ExecNode> Nodes { get; private set; }
    public ExecNode? StartNode { get; set; } = null;

    public Flow()
    {
        Nodes = new();
    }
}