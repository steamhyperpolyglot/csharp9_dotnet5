using System;
using System.Collections;
using static System.Console;

namespace IterationStatements{
	class Program{
		static void Main ( string [] args ) {
			
		}

		static void UsingIterators() {
			string [] names = { "Adam", "Barry", "Charlie" };

			IEnumerator e = names.GetEnumerator ();

			while ( e.MoveNext () ) {
				string name = ( string ) e.Current; // Current is read-only!
				WriteLine ( $"{name} has {name.Length} characters." );
			}
		}

		static void UsingForEach() {
			string [] names = { "Adam", "Barry", "Charlie" };

			foreach ( string name in names ) {
				WriteLine ( $"{name} has {name.Length} characters." );
			}
		}

		static void UsingForLoop() {
			for ( int y = 1; y <= 10; y++ ) {
				WriteLine ( y );
			}
		}

		static void UsingBasicWhileLoop() {
			int x = 0;

			while ( x < 10 ) {
				WriteLine ( x );
				x++;
			}
		}

		static void UsingDoWhile() {
			string password = string.Empty;

			do {
				Write ( "Enter your password: " );
				password = ReadLine ();
			} while ( password != "Pa$$w0rd" );

			WriteLine ( "Correct!" );
		}
	}
}