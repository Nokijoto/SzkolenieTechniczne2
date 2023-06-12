using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Service.Command;
using SzkolenieTechniczne2.Cinema.Service.Query;

namespace SzkolenieTechniczne2.Cinema.Service.Mediator
{
    public interface IMediator
    {
        Result Command<TCommand>(TCommand command) where TCommand : ICommand;

        TResponse Query<TResponse>(IQuery<TResponse> query);

        TResponse Query<TQuery, TResponse>(TQuery query) where TQuery : IQuery<TResponse>;
    }
}
