using System.Collections.ObjectModel;

namespace NodeApp
{
    class MainViewModel : ViewModel
    {
        public string Message { get; set; } = "Hello, world!";

        public ObservableCollection<NodeViewModel> Nodes { get; set; } = new();

        public ObservableCollection<ConnectionViewModel> Connections { get; } = new();

        public MainViewModel()
        {
            var node1 = new NodeViewModel { Title = "Node 1" };
            node1.Input.Add(new ConnectorViewModel { Title = "In 1" });
            node1.Input.Add(new ConnectorViewModel { Title = "In 2" });
            node1.Output.Add(new ConnectorViewModel { Title = "Out 1" });

            Nodes.Add(node1);

            var node2 = new NodeViewModel { Title = "Node 2" };
            node2.Input.Add(new ConnectorViewModel { Title = "In 1" });
            node2.Output.Add(new ConnectorViewModel { Title = "Out 1" });
            node2.Output.Add(new ConnectorViewModel { Title = "Out 2" });

            Nodes.Add(node2);

            var connection = new ConnectionViewModel(source: node1.Output[0], target: node2.Input[0]);
            Connections.Add(connection);
        }
    }
}
