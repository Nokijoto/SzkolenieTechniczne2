using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Service.Query.Dtos;

namespace SzkolenieTechniczne2.Cinema.Service.Query.Movies
{
    public class GetMovieQuery : IQuery<MovieDetailsDto>
    {
        public GetMovieQuery(Guid movieId)
        {
            MovieId = movieId;
        }

        public Guid MovieId { get; }
    }
}
