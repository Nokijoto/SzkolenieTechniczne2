using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Service.Command.Movie;
using SzkolenieTechniczne2.Cinema.Service.Command;
using SzkolenieTechniczne2.Cinema.Service.Query;
using Autofac;

namespace SzkolenieTechniczne2.Cinema.Service.Mediator
{
    public static class MediatorConfiguration
    {
        public static void ConfigureMediator(this ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();

            containerBuilder
                .Register(factory =>
                {
                    var lifetimeScope = factory.Resolve<ILifetimeScope>();
                    return new AutofacDependencyResolver(lifetimeScope.BeginLifetimeScope());
                })
                .As<IDependencyResolver>()
                .InstancePerLifetimeScope();

            var handlersAssembly = typeof(AddMovieCommandHandler).Assembly;

            containerBuilder
                .RegisterAssemblyTypes(handlersAssembly)
                .AsClosedTypesOf(typeof(ICommandHandler<>))
                .InstancePerLifetimeScope();

            containerBuilder
                .RegisterAssemblyTypes(handlersAssembly)
                .AsClosedTypesOf(typeof(IQueryHandler<,>))
                .InstancePerLifetimeScope();
        }
    }
}
