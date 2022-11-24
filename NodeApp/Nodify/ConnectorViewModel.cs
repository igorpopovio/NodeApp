using System.Windows;
using NodeApp.Core;

namespace NodeApp.Nodify
{
    class ConnectorViewModel : ViewModel
    {
        public string Title { get; set; } = string.Empty;

        public Point Anchor { get; set; }

        public bool IsConnected { get; set; }
    }
}
