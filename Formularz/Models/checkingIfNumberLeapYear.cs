using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
	public class UserDataValidation : ValidationAttribute
	{

		private int divider1, divider2, divider3;
		public UserDataValidation(int divider1, int divider2, int divider3)
		{
			this.divider1 = divider1;
			this.divider2 = divider2;
			this.divider3 = divider3;
		}
		public override bool IsValid(object? value)
		{
			if (value == null)
			{
				return true;
			}
			
			int number = (int)value;

			if (((number % divider1 == 0) && (number % divider2 != 0) || (number % divider3 == 0)))
			{
				ErrorMessage = "Rok podany przez użytkownika rok jest rokiem przestępnym.";
				return false;


			}
			else
			{
				ErrorMessage = "Podany przez użytkownika rok nie jest rokiem przestępnym.";
				return false;
			}

		}

	

	}
}



