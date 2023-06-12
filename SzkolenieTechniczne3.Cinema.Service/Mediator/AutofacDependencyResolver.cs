using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne2.Cinema.Service.Mediator
{
    public class AutofacDependencyResolver : IDependencyResolver
    {
        private readonly ILifetimeScope _lifetimeScope;

        public AutofacDependencyResolver(ILifetimeScope lifetimeScope)
        {
            this._lifetimeScope = lifetimeScope;
        }

        public T ResolveOrDefault<T>() where T : class
            => _lifetimeScope.ResolveOptional<T>();
    }
}
