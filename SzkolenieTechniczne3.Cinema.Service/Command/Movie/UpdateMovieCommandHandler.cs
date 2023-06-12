using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Service;
using SzkolenieTechniczne2.Cinema.Service.Command;
using SzkolenieTechniczne2.Cinema.Storage.Repositories;

namespace SzkolenieTechniczne3.Cinema.Service.Command.Movie
{
    public class UpdateMovieCommandHandler:ICommandHandler<UpdateMovieCommand>
    {
        private readonly IMovieRepository _repository;
        public UpdateMovieCommandHandler(IMovieRepository repository)
        {
             _repository= repository;
        }
        public Result Handle(UpdateMovieCommand command)
        {
            var movie = _repository.GetById(command.Id);
            if (movie == null)
            {
                return Result.Fail("Movie not found");
            }

            _repository.Update(movie);
            return Result.Ok();
        }

        public Result Handler(UpdateMovieCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
