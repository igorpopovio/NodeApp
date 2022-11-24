using System.Windows;

namespace NodeApp
{
    class ConnectorViewModel : ViewModel
    {
        public string Title { get; set; } = string.Empty;

        public Point Anchor { get; set; }

        public bool IsConnected { get; set; }
    }
}
