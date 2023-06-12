using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Service;
using SzkolenieTechniczne2.Cinema.Service.Command.Seances;
using SzkolenieTechniczne2.Cinema.Storage.Entities;
using SzkolenieTechniczne2.Cinema.Storage.Repositories;


namespace SzkolenieTechniczne3.Cinema.Service.Command.Seance
{
    public sealed class RegisterSeanceCommandHandler
    {
        private readonly IMovieRepository _repository;

        public RegisterSeanceCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public Result Handle(RegisterSeanceCommand command)
        {
            var validationResult = new RegisterSeanceCommandValidator().Validate(command);
            if (!validationResult.IsValid)
            {
                return Result.Fail(validationResult);
            }

            var isSeanceExist = _repository.IsSeanceExist(command.SeanceDate);
            if (isSeanceExist)
            {
                return Result.Fail("Seance already Exists");
            }

            var movie = _repository.GetById(command.MovieId);
            if (movie == null)
            {
                return Result.Fail("This movie does not exist");
            }

            var seance = new SzkolenieTechniczne2.Cinema.Storage.Entities.Seance(command.SeanceDate, command.MovieId);

            movie.Seances.Add(seance);

            return Result.Ok();

        }
    }
}
