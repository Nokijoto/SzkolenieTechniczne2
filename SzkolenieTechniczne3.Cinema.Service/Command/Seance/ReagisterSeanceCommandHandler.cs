using System;
using SzkolenieTechniczne2.Cinema.Storage.Entities;
using SzkolenieTechniczne2.Cinema.Storage.Repositories;

namespace SzkolenieTechniczne2.Cinema.Service.Command.Seances
{
    public  sealed class RegisterSeanceCommandHandler : ICommandHandler<RegisterSeanceCommand>
    {
        private readonly IMovieRepository _repository;

        public RegisterSeanceCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }
        public Result Handle(RegisterSeanceCommand command)
        {
            var validationResult = new RegisterSeanceCommandValidator().Validate(command);
            if (validationResult.IsValid == false)
            {
                return Result.Fail(validationResult);
            }

            var isSeanceExist = _repository.IsSeanceExist(command.SeanceDate);
            if (isSeanceExist)
            {
                return Result.Fail("This seance already exist");

            }
            var movie = _repository.GetById(command.MovieId);
            if (movie == null)
            {
                return Result.Fail("This movie does not exist");
            }

            var seance = new Seance(command.SeanceDate, command.MovieId);
            movie.Seances.Add(seance);

            return Result.Ok();

        }

    }
}

