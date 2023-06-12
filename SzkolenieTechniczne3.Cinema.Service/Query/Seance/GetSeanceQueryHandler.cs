using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Service.Query.Dtos;
using SzkolenieTechniczne2.Cinema.Service.Query;
using SzkolenieTechniczne2.Cinema.Storage.Repositories;

namespace SzkolenieTechniczne2.Cinema.Service.Query.Seance
{
    public class GetSeanceQueryHanlder : IQueryHandler<GetSeanceQuery, MovieSeanceDetails>
    {
        private readonly IMovieRepository _repository;

        public GetSeanceQueryHanlder(IMovieRepository repository)
        {
            _repository = repository;
        }

        public MovieSeanceDetails Handle(GetSeanceQuery query)
        {
            var movie = _repository.GetSeanceDetails(query.MovieId);
            if (movie == null)
            {
                throw new NullReferenceException("Given movie does not exist.");
            }

            var seance = movie.Seances.SingleOrDefault(x => x.Id == query.SeanceId);
            if (seance == null)
            {
                throw new NullReferenceException("Given seance does not exist.");
            }

            return new MovieSeanceDetails(movie, seance);
        }
    }
}
