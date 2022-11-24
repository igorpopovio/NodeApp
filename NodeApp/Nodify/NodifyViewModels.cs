using NodeApp.Core;

using System.Collections.ObjectModel;
using System.Windows;

namespace NodeApp.Nodify
{
    class NodeViewModel : ViewModel
    {
        public string Title { get; set; } = string.Empty;
        public Point Location { get; set; }

        public ObservableCollection<ConnectorViewModel> Input { get; set; } = new();
        public ObservableCollection<ConnectorViewModel> Output { get; set; } = new();
    }
    class ConnectorViewModel : ViewModel
    {
        public string Title { get; set; } = string.Empty;
        public Point Anchor { get; set; }
        public bool IsConnected { get; set; }
    }

    class ConnectionViewModel : ViewModel
    {
        public ConnectorViewModel? Source { get; set; }
        public ConnectorViewModel? Target { get; set; }

        public ConnectionViewModel(ConnectorViewModel source, ConnectorViewModel target)
        {
            Source = source;
            Source.IsConnected = true;

            Target = target;
            Target.IsConnected = true;
        }
    }
}
