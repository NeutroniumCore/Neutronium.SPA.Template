using System;
using Microsoft.Practices.ServiceLocation;

namespace Neutronium.SPA 
{
    public interface IDependencyInjectionConfiguration 
    {
        Lazy<IServiceLocator> GetServiceLocator();

        void Register<T>(T implementation);
    }
}