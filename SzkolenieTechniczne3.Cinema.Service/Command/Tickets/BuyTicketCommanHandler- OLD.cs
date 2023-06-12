using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Service;
using SzkolenieTechniczne2.Cinema.Service.Command;
using SzkolenieTechniczne2.Cinema.Service.Command.Tickets;
using SzkolenieTechniczne2.Cinema.Storage.Repositories;

/*
namespace SzkolenieTechniczne3.Cinema.Service.Command.Tickets
{
    public sealed class BuyTicketCommandHandler : ICommandHandler<BuyTicketCommand>
    {
        private readonly IMovieRepository _repository;

        public BuyTicketCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public Result Handle(BuyTicketCommand command)
        {
            var validationResult = new BuyTicketCommandValidator().Validate(command);
            if (!validationResult.IsValid)
            {
                return Result.Fail(validationResult);
            }




            var ticket = new Ticket(command.Email, command.Quantity);
            var movie = _repository.GetById(command.MovieId);
            var seance = movie.GetSeanceByDateAndRoomId(command.SeanceDate);

            seance.Add(ticket);

        }

        public Result Handler(BuyTicketCommand command)
        {
            throw new NotImplementedException();
        }

        Result ICommandHandler<BuyTicketCommand>.Handler(BuyTicketCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
*/