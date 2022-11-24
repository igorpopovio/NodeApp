using System.Collections.ObjectModel;
using NodeApp.Core;

namespace NodeApp.Nodify
{
    class NodeViewModel : ViewModel
    {
        public string Title { get; set; } = string.Empty;

        public ObservableCollection<ConnectorViewModel> Input { get; set; } = new();
        public ObservableCollection<ConnectorViewModel> Output { get; set; } = new();
    }
}
