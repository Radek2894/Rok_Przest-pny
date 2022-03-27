using System;
using System.ComponentModel.DataAnnotations;
using Formularz.Models;
namespace Formularz.Models
{
	public class FizzBuzz
	{

		[Display(Name = "Podaj rok z przedziału 1899 - 2022")]
		[Required]
		[Range(1899, 2022, ErrorMessage = "Oczekiwana wartość z zakresu {1} i {2}.")]
		[UserDataValidation(divider1: 4, divider2: 100, divider3: 400)]
		public int? Number { get; set; }

	

		[Display(Name = "Podaj imię")]
		[Required]
		[StringLength(maximumLength: 100, ErrorMessage = "Imię może mieć maksymalnie 100 znaków")]


		public string? Name { get; set; }


		public bool doesStringExists()
		{
			if (Name != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool doesNumberExists()
		{
			if (Number != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

