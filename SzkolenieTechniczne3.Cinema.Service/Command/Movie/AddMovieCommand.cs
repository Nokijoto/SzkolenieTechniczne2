using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne3.Cinema.Service.Command.Movie
{
    public sealed class AddMovieCommand: ICommand
    {
        public string Name{get; set;}
        
        public int Year { get; set; }
        public int SceneTime { get; set; }
    }
}
