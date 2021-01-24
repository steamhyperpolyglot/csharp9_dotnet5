using System;

using static System.Console;

namespace GetUserInput
{
	class Program
	{
		static void Main ( string [] args )
		{
			Write ("Type your first name and press ENTER: ");
			string firstName = Console.ReadLine ();

			Write ( "Type your age and press ENTER: " );
			string age = Console.ReadLine ();

			WriteLine ( $"Hello {firstName}, you look good for {age}." );
		}
	}
}