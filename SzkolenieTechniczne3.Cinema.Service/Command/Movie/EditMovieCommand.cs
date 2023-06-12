using System;
namespace SzkolenieTechniczne2.Cinema.Service.Command.Movie
{
	public class EditMovieCommand
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int Year { get; set; }
		public int SeanceTime { get; set; }
	}
}

