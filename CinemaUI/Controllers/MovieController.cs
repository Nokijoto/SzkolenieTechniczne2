using CinemaUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SzkolenieTechniczne2.Cinema.Service.Command.Movie;
using SzkolenieTechniczne2.Cinema.Service.Query.Dtos;

namespace CinemaUI.Controllers
{
    public class MovieController : Controller
    {
        private readonly ILogger<MovieController> _logger;
       
        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
            
        }

        
        public IActionResult Index()
        {
            
            
            return View(RepositoryMovie._movieList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddMovieCommand command)
        {
            RepositoryMovie._movieList.Add(new MovieDto(command.Name, Guid.NewGuid()));


            return RedirectToAction("Index");
        }
    }
}