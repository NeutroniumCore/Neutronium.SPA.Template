using Neutronium.Core.Navigation.Routing;
using Vm.Tools.Application.Navigation;

namespace Neutronium.SPA
{
    public class RoutingConfiguration
    {
        public static IRouterSolver Register()
        {
            var router = new Router();
            BuildRoutes(router);
            return router;
        }

        private static void BuildRoutes(IRouterBuilder routeBuilder) 
        {
            var convention = routeBuilder.GetTemplateConvention("{vm}");
            typeof(RoutingConfiguration).GetTypesFromSameAssembly()
                .InNamespace("Neutronium.SPA.ViewModel")
                .Register(convention);
        }
    }
}
