using System;

using SzkolenieTechniczne2.Cinema.Storage.Repositories;

namespace SzkolenieTechniczne2.Cinema.Service.Command.Movie
{
    public sealed class AddMovieCommandHandler : ICommandHandler<AddMovieCommand>
    {
        private readonly IMovieRepository _repository;

        public AddMovieCommandHandler(IMovieRepository repository)
		{
            _repository = repository;
        }
        public Result Handle(AddMovieCommand command)
        {
            var validationResult = new AddMovieCommandValidator().Validate(command);
            if (validationResult.IsValid == false)
            {
                return Result.Fail(validationResult);
            }
            var isExist = _repository.IsMovieExist(command.Name, command.Year);
            if (isExist)
            {
                return Result.Fail("This movie alredy exist");

            }
            var movie = new SzkolenieTechniczne2.Cinema.Storage.Entities.Movie(command.Name, command.Year, command.SeanceTime, command.Descritpion);
            _repository.Add(movie);
            return Result.Ok();
        }

	}
}

