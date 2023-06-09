﻿using System;
using FluentValidation;

namespace SzkolenieTechniczne2.Cinema.Service.Command.Seances
{
	public class RegisterSeanceCommandValidator:AbstractValidator<RegisterSeanceCommand>
	{
		public RegisterSeanceCommandValidator()
		{
			RuleFor(x => x.MovieId).NotEmpty();
			RuleFor(x => x.SeanceDate).NotEmpty().GreaterThan(DateTime.UtcNow);
		}
	}
}

