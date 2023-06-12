using System;
using FluentValidation;

namespace SzkolenieTechniczne2.Cinema.Service.Command.Movie
{
	internal class AddMovieCommandValidator: AbstractValidator<AddMovieCommand>
	{
		public AddMovieCommandValidator()
		{
			RuleFor(x => x.Name).NotEmpty();
			RuleFor(x => x.Year).InclusiveBetween(1990, 2040);
			RuleFor(x => x.SeanceTime).InclusiveBetween(30, 300);
		}
	}
}

