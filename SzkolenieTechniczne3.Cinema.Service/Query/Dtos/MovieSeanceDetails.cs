using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Storage.Entities;

namespace SzkolenieTechniczne2.Cinema.Service.Query.Dtos
{
    public class MovieSeanceDetails
    {
        public MovieSeanceDetails(Movie movie, Storage.Entities.Seance seance)
        {
            MovieName = movie.Name;
            MovieId = movie.Id;
            SeanceId = seance.Id;
            SeanceDate = seance.Date;
        }


        public Guid MovieId { get; }

        public Guid SeanceId { get; }

        public string MovieName { get; }

        public DateTime SeanceDate { get; }
        public Movie Movie { get; }
        public Storage.Entities.Seance Seance { get; }
    }
}
