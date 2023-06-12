using SzkolenieTechniczne2.Cinema.Service.Query.Dtos;

namespace CinemaUI.Models
{
    public static class RepositoryMovie
    {
        public static List<MovieDto> _movieList = new List<MovieDto>(){
        new MovieDto("AntMan Quantumania", Guid.NewGuid()),
        new MovieDto("The Marvels", Guid.NewGuid())};
    }
}
