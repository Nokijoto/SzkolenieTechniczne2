using System;
using FluentValidation;
using SzkolenieTechniczne2.Cinema.Storage.Entities;
using SzkolenieTechniczne2.Cinema.Storage.Repositories;

namespace SzkolenieTechniczne2.Cinema.Service.Command.Tickets
{
	public class BuyTicketCommandHandler:ICommandHandler<BuyTicketCommand>
	{
        private readonly IMovieRepository _repository;

        public BuyTicketCommandHandler(IMovieRepository repository)
		{
            _repository = repository;
        }

       

        public Result Handle(BuyTicketCommand command)
        {
            var validatorResult = new BuyTicketCommandValidator().Validate(command);
            if (validatorResult.IsValid == false)
            {
                return Result.Fail(validatorResult);
            }
            var ticket = new Ticket(command.Email, command.Quentity);
            var movie = _repository.GetById(command.MovieId);
            var seance= movie.GetSeanceByDateAndRoomId(command.SeanceDate);
            seance.Add(ticket);
            return Result.Ok();

        }
	}
}

