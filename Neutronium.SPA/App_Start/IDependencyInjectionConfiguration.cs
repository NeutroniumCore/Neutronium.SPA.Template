using Microsoft.Practices.ServiceLocation;

namespace Neutronium.SPA 
{
    public interface IDependencyInjectionConfiguration 
    {
        IServiceLocator GetServiceLocator();

        void Register<T>(T implementation);
    }
}