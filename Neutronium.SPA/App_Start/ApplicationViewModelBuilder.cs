using System.Windows;
using Microsoft.Practices.ServiceLocation;
using Neutronium.SPA.Application.LifeCycleHook;
using Neutronium.SPA.Application.Navigation;
using Neutronium.SPA.Application.WindowServices;
using Neutronium.SPA.ViewModel;
using Neutronium.WPF.ViewModel;

namespace Neutronium.SPA
{
    public class ApplicationViewModelBuilder
    {
        public ApplicationViewModel ApplicationViewModel { get; }
        private readonly LifeCycleEventsRegistror _LifeCycleEventsRegistror;

        public ApplicationViewModelBuilder(Window wpfWindow)
        {
            var window = new WindowViewModel(wpfWindow);
            var routeSolver = RoutingConfiguration.Register();
            var serviceLocatorBuilder = new DependencyInjectionConfiguration();
            var serviceLocator = serviceLocatorBuilder.GetServiceLocator();

            var navigation = NavigationViewModel.Create(serviceLocator, routeSolver);

            serviceLocatorBuilder.Register<IWindowViewModel>(window);
            serviceLocatorBuilder.Register<INavigator>(navigation);
            serviceLocatorBuilder.Register(navigation);

            ApplicationViewModel = serviceLocator.GetInstance<ApplicationViewModel>();
            serviceLocatorBuilder.Register<IMessageBox>(ApplicationViewModel);
            serviceLocatorBuilder.Register<INotificationSender>(ApplicationViewModel);

            _LifeCycleEventsRegistror = RegisterLifeCycleEvents(serviceLocator);
        }

        private static LifeCycleEventsRegistror RegisterLifeCycleEvents(IServiceLocator serviceLocator)
        {
            var registor = serviceLocator.GetInstance<LifeCycleEventsRegistror>();
            return registor.Register();
        }
    }
}
