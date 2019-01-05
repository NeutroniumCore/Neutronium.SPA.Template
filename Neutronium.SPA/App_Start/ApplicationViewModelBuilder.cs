using System.Windows;
using CommonServiceLocator;
using Neutronium.MVVMComponents;
using Neutronium.WPF.ViewModel;
using Vm.Tools.Application.LifeCycleHook;
using Vm.Tools.Application.Navigation;
using Vm.Tools.Application.ViewModel;
using Vm.Tools.Application.WindowServices;

namespace Neutronium.SPA
{
    public class ApplicationViewModelBuilder
    {
        public ApplicationViewModel<ApplicationInformation> ApplicationViewModel { get; }
        private readonly LifeCycleEventsRegistror _LifeCycleEventsRegistror;

        public ApplicationViewModelBuilder(Window wpfWindow)
        {
            var window = new WindowViewModel(wpfWindow);
            var routeSolver = RoutingConfiguration.Register();
            var serviceLocatorBuilder = new DependencyInjectionConfiguration();
            var serviceLocatorLazy = serviceLocatorBuilder.GetServiceLocator();

            var navigation = new NavigationViewModel(serviceLocatorLazy, routeSolver);

            serviceLocatorBuilder.Register<IWindowViewModel>(window);
            serviceLocatorBuilder.Register<INavigator>(navigation);
            serviceLocatorBuilder.Register(navigation);

            ApplicationViewModel = new ApplicationViewModel<ApplicationInformation>(window, navigation, new ApplicationInformation("Neutronium Demo", "David Desmaisons"));
            serviceLocatorBuilder.Register<IMessageBox>(ApplicationViewModel);
            serviceLocatorBuilder.Register<INotificationSender>(ApplicationViewModel);

            var serviceLocator = serviceLocatorLazy.Value;
            _LifeCycleEventsRegistror = RegisterLifeCycleEvents(serviceLocator);
        }

        private static LifeCycleEventsRegistror RegisterLifeCycleEvents(IServiceLocator serviceLocator)
        {
            var register = serviceLocator.GetInstance<LifeCycleEventsRegistror>();
            return register.Register();
        }
    }
}
