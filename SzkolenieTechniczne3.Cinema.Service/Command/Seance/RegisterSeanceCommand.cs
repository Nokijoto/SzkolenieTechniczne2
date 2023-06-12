using System;
namespace SzkolenieTechniczne2.Cinema.Service.Command.Seances
{
	public class RegisterSeanceCommand:ICommand
	{
		public Guid MovieId { get; set; }
		public DateTime SeanceDate { set; get; }
	}
}

