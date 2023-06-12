using SzkolenieTechniczne2.Cinema.Storage.Repositories;

namespace SzkolenieTechniczne2.Cinema.Service.Command.Movie
{
    public sealed class DeleteMovieCommandHandler : ICommandHandler<DeleteMovieCommand>
    {
        private readonly IMovieRepository _repository;

        public DeleteMovieCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public Result Handle(DeleteMovieCommand command)
        {
            var movie = _repository.GetById(command.Id);
            if (movie == null)
            {
                return Result.Fail("Movie does not exist.");
            }
            _repository.Remove(command.Id);

            return Result.Ok();
        }
    }
}

