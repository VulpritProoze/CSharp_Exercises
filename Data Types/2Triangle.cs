/*
** 2. Write a C# Sharp program that takes a number and 
** a width also a number. It then displays a triangle 
** of that width using that number.
**
*/

namespace Triangle
{
	class Program
	{
		static void Main(string[] args)
		{
			int displayNum, width;

			Console.Write("Enter display number: ");
			if (!int.TryParse(Console.ReadLine(), out displayNum))
			{
				Console.WriteLine("You must input a number or must not be empty.");
				return;
			}

			Console.Write("Enter width: ");
			if (!int.TryParse(Console.ReadLine(), out width))
			{
				Console.WriteLine("You must input a number or must not be empty.");
				return;
			}

			CreateTriangle(displayNum, width);
		}

		static void CreateTriangle(int displayNum, int width)
		{
			for (int i = width; i >= 0; i--)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write(displayNum);
				}
				Console.WriteLine();
			}
		}
	}
}