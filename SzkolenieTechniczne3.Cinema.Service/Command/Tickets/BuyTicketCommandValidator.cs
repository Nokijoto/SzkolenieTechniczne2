using System;
using FluentValidation;

namespace SzkolenieTechniczne2.Cinema.Service.Command.Tickets
{
	public class BuyTicketCommandValidator:AbstractValidator<BuyTicketCommand>
	{
		public BuyTicketCommandValidator()
		{
			RuleFor(x => x.MovieId).NotEmpty();
			RuleFor(x => x.SeanceDate).NotEmpty();
			RuleFor(x => x.Email).NotEmpty();
			RuleFor(x => x.Quentity).GreaterThan(0);
		}
	}
}

