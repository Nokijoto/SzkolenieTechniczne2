using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Service.Query.Dtos;
using SzkolenieTechniczne2.Cinema.Storage.Repositories;

namespace SzkolenieTechniczne2.Cinema.Service.Query.Movies
{
    public sealed class GetAllMoviesQueryHandler : IQueryHandler<GetAllMoviesQuery, List<MovieDto>>
    {
        private readonly IMovieRepository _repository;

        public GetAllMoviesQueryHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public List<MovieDto> Handle(GetAllMoviesQuery query)
        {
            var movies = _repository.GetAll();

            return movies.Select(item => new MovieDto(item.Name, item.Id)).ToList();
        }
    }
}
