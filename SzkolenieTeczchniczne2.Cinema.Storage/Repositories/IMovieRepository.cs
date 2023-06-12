using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Storage.Entities;

namespace SzkolenieTechniczne2.Cinema.Storage.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(Guid id);
        void Add(Movie movie);
        void Update(Movie movie);
        void Remove(Guid id);
        bool IsMovieExist(string name, int year);
        bool IsSeanceExist(DateTime seanceDate);
        Movie GetSeanceDetails(Guid movieId);
        List<Seance> GetSeancesByMovieId(Guid movieId);

    }
}
