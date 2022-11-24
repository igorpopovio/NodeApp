using System.Collections.ObjectModel;

namespace NodeApp
{
    class MainViewModel : ViewModel
    {
        public string Message { get; set; } = "Hello, world!";

        public ObservableCollection<NodeViewModel> Nodes { get; set; } = new();

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
        }
    }
}
