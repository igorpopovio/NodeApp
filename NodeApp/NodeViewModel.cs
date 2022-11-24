using System.Collections.ObjectModel;

namespace NodeApp
{
    class NodeViewModel : ViewModel
    {
        public string Title { get; set; } = string.Empty;

        public ObservableCollection<ConnectorViewModel> Input { get; set; } = new();
        public ObservableCollection<ConnectorViewModel> Output { get; set; } = new();
    }
}
