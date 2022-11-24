using NodeApp.Core;

namespace NodeApp.Nodify
{
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
