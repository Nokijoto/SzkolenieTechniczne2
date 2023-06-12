using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne2.Cinema.Service.Mediator
{
    public interface IDependencyResolver
    {
        T ResolveOrDefault<T>() where T : class;
    }
}
