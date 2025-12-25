/*
**	3. Write a C# Sharp program that takes userid and password as input (string type). 
** 	After 3 unsuccessful attempts, the user will be rejected.
*/

namespace ThreeAttemptsReject
{
	class Program
	{
		static string _userId = "";
		static string _password = "";

		static void Main(string[] args)
		{
			Console.Write("Enter userId: ");
			string userId = Console.ReadLine() ?? "";

			Console.Write("Enter password: ");
			string password = Console.ReadLine() ?? "";

			Register(userId, password);

			Console.WriteLine("\nLogin many times. Ctrl C/V to stop.");

			int loginFails = 0;
			while(true)
			{
				Console.Write("Enter userId: ");
				string loginUserId = Console.ReadLine() ?? "";

				Console.Write("Enter password: ");
				string loginPassword = Console.ReadLine() ?? "";

				if (!Login(loginUserId, loginPassword))
				{
					loginFails++;
				}

				Console.WriteLine();

				if (loginFails >= 3)
				{
					Console.WriteLine("3 failed attempts! Shutting down system.");
					return;
				}
				
			}

		}

		static bool Register(string userId, string password)
		{
			if (
				_userId == userId ||
				_password == password)
			{
				Console.WriteLine("Credentials set are the same.");
				return false;
			}

			_userId = userId;
			_password = password;

			Console.WriteLine("Credentials registered.");
			return true;
		}

		static bool Login(string userId, string password)
		{
			if (
				_userId != userId &&
				_password != password)
			{
				Console.WriteLine("Invalid credentials.");
				return false;
			}

			Console.WriteLine("Login successfully.");
			return true;
		}
	}
}