using System;
namespace SzkolenieTechniczne2.Cinema.Service.Command.Movie
{
    public sealed class DeleteMovieCommand : ICommand
    {
        public DeleteMovieCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
