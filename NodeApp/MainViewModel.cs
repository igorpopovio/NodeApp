using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

using NodeApp.Core;
using NodeApp.Nodify;

namespace NodeApp
{
    class MainViewModel : ViewModel
    {
        public ObservableCollection<NodeViewModel> Nodes { get; set; } = new();

        public ObservableCollection<ConnectionViewModel> Connections { get; } = new();

        public ICommand AddNodeCommand { get; set; }

        public MainViewModel()
        {
            AddNodeCommand = new Command(AddNode);

            AddNode();
            AddNode();

            var node1 = Nodes[0];
            var node2 = Nodes[1];

            var connection1 = new ConnectionViewModel(source: node1.Output[0], target: node2.Input[0]);
            Connections.Add(connection1);

            var connection2 = new ConnectionViewModel(source: node1.Output[1], target: node2.Input[1]);
            Connections.Add(connection2);
        }

        public void AddNode()
        {
            var node = new NodeViewModel { Title = $"Node {Nodes.Count}", Location = new Point(200 * Nodes.Count, 100) };
            node.Input.Add(new ConnectorViewModel { Title = "In 1" });
            node.Input.Add(new ConnectorViewModel { Title = "In 2" });
            node.Output.Add(new ConnectorViewModel { Title = "Out 1" });
            node.Output.Add(new ConnectorViewModel { Title = "Out 2" });
            Nodes.Add(node);
        }
    }
}
