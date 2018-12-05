using System;
using CommonServiceLocator;

namespace Neutronium.SPA 
{
    public interface IDependencyInjectionConfiguration 
    {
        Lazy<IServiceLocator> GetServiceLocator();

        void Register<T>(T implementation);
    }
}