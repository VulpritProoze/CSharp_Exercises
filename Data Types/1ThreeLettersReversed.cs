/*
**	1. Write a C# Sharp program that takes three letters and 
**	displays them in reverse order.
**
**	- Sorry if I coded it this way ToT. I don't know how to make lists
** 	or arrays in C# yet.
*/

namespace ThreeLettersReversed
{
	class Program
	{
		static void Main(string[] args)
		{
			string char1, char2, char3;
			char1 = char2 = char3 = "";

			Console.Write("Enter first char: ");
			char1 = Console.ReadLine() ?? "";

			if (!IsValid(char1))
			{
				Console.WriteLine("Must only input one character.");
				return;
			}

			Console.Write("Enter 2nd char: ");
			char2 = Console.ReadLine() ?? "";

			if (!IsValid(char2))
			{
				Console.WriteLine("Must only input one character.");
				return;
			}

			Console.Write("Enter 3rd char: ");
			char3 = Console.ReadLine() ?? "";

			if (!IsValid(char3))
			{
				Console.WriteLine("Must only input one character.");
				return;
			}

			Console.WriteLine("Output:");
			Console.WriteLine(char3);
			Console.WriteLine(char2);
			Console.WriteLine(char1);
		}

		static bool IsValid(string character)
		{
			if (character.Length == 0)
			{
				return false;
			}
			if (character.Length > 1)
			{
				return false;
			}
			return true;
		}
	}
}