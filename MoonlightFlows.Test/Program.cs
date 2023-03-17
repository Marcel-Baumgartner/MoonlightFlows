using MoonlightFlows;
using MoonlightFlows.Nodes;

var flow = new Flow();

var startNode = new StartNode()
{
    Inputs =
    {
        new PrintNode()
        {
            Inputs =
            {
                new AddNode()
                {
                    Inputs =
                    {
                        new NumberNode()
                        {
                            Data = 1
                        },
                        new AddNode()
                        {
                            Inputs =
                            {
                                new NumberNode()
                                {
                                    Data = 1
                                },
                                new NumberNode()
                                {
                                    Data = 2
                                }
                            }
                        }
                    }
                }
            }
        }
    }
};

flow.StartNode = startNode;

var interpreter = new FlowInterpreter(flow);

await interpreter.Execute();