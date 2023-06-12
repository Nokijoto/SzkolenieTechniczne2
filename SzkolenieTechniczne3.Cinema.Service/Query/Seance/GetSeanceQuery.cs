using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Service.Query.Dtos;

namespace SzkolenieTechniczne2.Cinema.Service.Query.Seance
{
    public class GetSeanceQuery : IQuery<MovieSeanceDetails>
    {
        public GetSeanceQuery(Guid movieId, Guid seanceId)
        {
            MovieId = movieId;
            SeanceId = seanceId;
        }

        public Guid MovieId { get; }
        public Guid SeanceId { get; }
    }
}
