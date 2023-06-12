using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Service.Command;

namespace SzkolenieTechniczne3.Cinema.Service.Command.Movie
{
    public sealed class UpdateMovieCommand :ICommand 
    {
        public UpdateMovieCommand(Guid id, string name, int year, int sceneTime)
        {
            Id = id;
            Name = name;
            Year = year;
            SceneTime = sceneTime;
        }
        public Guid Id { get; }
        public string Name { get; }
        public int Year { get; }
        public int SceneTime { get; }
        
    }
}
