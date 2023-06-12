using System;
namespace SzkolenieTechniczne2.Cinema.Service.Command.Movie
{
    public sealed class AddMovieCommand : ICommand
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int SeanceTime { get; set; }
        public string Descritpion { get; internal set; }
    }
}

