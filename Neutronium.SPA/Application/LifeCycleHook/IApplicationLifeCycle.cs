using System.ComponentModel;
using Neutronium.SPA.Application.Navigation;

namespace Neutronium.SPA.Application.LifeCycleHook
{
    public interface IApplicationLifeCycle
    {
        void OnNavigating(RoutingEventArgs routingEvent);

        void OnNavigated(RoutedEventArgs routedEvent);

        void OnClosing(CancelEventArgs cancelEvent);

        void OnSessionEnding(CancelEventArgs cancelEvent);

        void OnClosed();
    }
}
