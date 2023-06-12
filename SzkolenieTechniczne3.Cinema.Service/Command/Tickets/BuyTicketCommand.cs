using System;
namespace SzkolenieTechniczne2.Cinema.Service.Command.Tickets
{
	public class BuyTicketCommand:ICommand
	{
		public BuyTicketCommand( Guid movieId, DateTime seanceDate, string email, int quentity)
		{
			SeanceDate = seanceDate;
			Email = email;
			Quentity = quentity;
			MovieId = movieId;

		}
		public Guid MovieId { get; }
		public DateTime SeanceDate { get; }
		public string Email { get; }
		public int Quentity { get; }
	}
}

