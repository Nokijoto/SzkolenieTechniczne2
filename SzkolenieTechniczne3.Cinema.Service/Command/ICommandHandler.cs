using System;
namespace SzkolenieTechniczne2.Cinema.Service.Command
{
    public interface ICommandHandler<in TCommand>
        where TCommand : ICommand
    {
        Result Handle(TCommand command);
    }
}

