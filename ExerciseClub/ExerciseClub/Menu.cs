using System;

namespace ExerciseClub
{
	public class Interaction
	{
		private string _code;

		public Interaction ()
		{
			_code = "empty";
		}

		public void CheckInput()
		{
			string back = "Press 0 to return to main menu";
			_code = Console.ReadLine ();

			if (_code == "1") 
			{
				Console.Clear ();
				Option1 ();
				Console.WriteLine (back);
			} 
			else if (_code == "2") 
			{
				Console.Clear ();
				Option2 ();
				Console.WriteLine (back);
			}
			else if (_code == "3") 
			{
				Console.Clear ();
				Option3 ();
				Console.WriteLine (back);
			}
			else
			{
				Console.WriteLine ("Please enter one of the numbers that corresponds with the option you want.");
			}
		}

		public void Display()
		{
			Console.WriteLine ("This is the menu. Please press the number that corresponds with the option you want.");
			Console.WriteLine ("1. Create user profile");
			Console.WriteLine ("2. Edit user profile");
			Console.WriteLine ("3. Create activity");
			Console.Write ("Option: ");
		}

		public void Option1()
		{
			//placeholder - replace with actual function when working on that section later
			Console.WriteLine ("Here you can create a user profile!");
		}

		public void Option2()
		{
			//placeholder - replace with actual function when working on that section later
			Console.WriteLine ("Here you can edit your user profile!");
		}

		public void Option3()
		{
			//placeholder - replace with actual function when working on that section later
			Console.WriteLine ("Here you can create an activity!");
		}
	}
}

