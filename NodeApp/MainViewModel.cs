using System.Collections.ObjectModel;

namespace NodeApp
{
    class MainViewModel : ViewModel
    {
        public string Message { get; set; } = "Hello, world!";

        public ObservableCollection<NodeViewModel> Nodes { get; set; } = new();

        public MainViewModel()
        {
            Nodes.Add(new NodeViewModel { Title = "lol" });
        }
    }
}
