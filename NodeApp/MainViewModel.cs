namespace NodeApp;

using NodeApp.Core;
using NodeApp.Nodify;

using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

class MainViewModel : ViewModel
{
    public ObservableCollection<NodeViewModel> Nodes { get; set; } = new();

    public ObservableCollection<ConnectionViewModel> Connections { get; } = new();

    public ICommand AddNodeCommand { get; set; }

    public MainViewModel()
    {
        AddNodeCommand = new Command(() => AddNode());
        AddDefaultNodes();
    }

    private void AddDefaultNodes()
    {
        var node1 = AddNode();
        var node2 = AddNode();

        var connection1 = new ConnectionViewModel(source: node1.Output[0], target: node2.Input[0]);
        Connections.Add(connection1);

        var connection2 = new ConnectionViewModel(source: node1.Output[1], target: node2.Input[1]);
        Connections.Add(connection2);
    }

    public NodeViewModel AddNode()
    {
        var xPosition = 200 * Nodes.Count;
        var yPosition = 200;
        var node = new NodeViewModel
        {
            Title = $"Node {Nodes.Count}",
            Location = new Point(xPosition, yPosition),
        };

        node.Input.Add(new ConnectorViewModel { Title = "In 1" });
        node.Input.Add(new ConnectorViewModel { Title = "In 2" });

        node.Output.Add(new ConnectorViewModel { Title = "Out 1" });
        node.Output.Add(new ConnectorViewModel { Title = "Out 2" });

        Nodes.Add(node);

        return node;
    }
}
