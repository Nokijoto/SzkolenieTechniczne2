using System;
using SzkolenieTechniczne2.Cinema.Storage.Repositories;

namespace SzkolenieTechniczne2.Cinema.Service.Command.Movie
{
    internal class EditMovieCommandHandler
    {
        private readonly IMovieRepository _repository;

        public EditMovieCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public Result Handle(EditMovieCommand command)
        {
            var validationResult = new EditMovieCommandValidator().Validate(command);
            if (validationResult.IsValid == false)
            {
                return Result.Fail(validationResult);
            }

            var movie = _repository.GetById(command.Id);
            if (movie == null)
            {
                return Result.Fail("Movie does not exist.");
            }

            movie.SetName(command.Name);
            movie.SetYear(command.Year);
            movie.SetSeanceTime(command.SeanceTime);

            _repository.Update(movie);
            return Result.Ok();
        }
    }
}

