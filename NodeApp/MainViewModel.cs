using System.Collections.ObjectModel;
using System.Windows;

using NodeApp.Core;
using NodeApp.Nodify;

namespace NodeApp
{
    class MainViewModel : ViewModel
    {
        public ObservableCollection<NodeViewModel> Nodes { get; set; } = new();

        public ObservableCollection<ConnectionViewModel> Connections { get; } = new();

        public MainViewModel()
        {
            var node1 = new NodeViewModel { Title = "Node 1", Location = new Point(100, 100) };
            node1.Input.Add(new ConnectorViewModel { Title = "In 1" });
            node1.Input.Add(new ConnectorViewModel { Title = "In 2" });
            node1.Output.Add(new ConnectorViewModel { Title = "Out 1" });
            node1.Output.Add(new ConnectorViewModel { Title = "Out 2" });
            Nodes.Add(node1);

            var node2 = new NodeViewModel { Title = "Node 2", Location = new Point(500, 100) };
            node2.Input.Add(new ConnectorViewModel { Title = "In 1" });
            node2.Input.Add(new ConnectorViewModel { Title = "In 2" });
            node2.Output.Add(new ConnectorViewModel { Title = "Out 1" });
            node2.Output.Add(new ConnectorViewModel { Title = "Out 2" });
            Nodes.Add(node2);

            var connection1 = new ConnectionViewModel(source: node1.Output[0], target: node2.Input[0]);
            Connections.Add(connection1);

            var connection2 = new ConnectionViewModel(source: node1.Output[1], target: node2.Input[1]);
            Connections.Add(connection2);
        }
    }
}
