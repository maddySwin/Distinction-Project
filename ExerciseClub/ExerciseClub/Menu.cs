using System;

namespace ExerciseClub
{
	public class Menu
	{
		private string _code;
		private string _back;

		public Menu ()
		{
		}

		public void CheckInput()
		{
			_code = Console.ReadLine ();
			_back = "0. Return to main menu";

			switch (_code) 
			{
			case "1":
				Console.Clear ();
				Console.WriteLine (Option1 ());
				Console.WriteLine (_back);
				Console.Write ("Option: ");
				break;
			case "2":
				Console.Clear ();
				Console.WriteLine (Option2 ());
				Console.WriteLine (_back);
				Console.Write ("Option: ");
				break;
			case "3":
				Console.Clear ();
				Console.WriteLine (Option3 ());
				Console.WriteLine (_back);
				Console.Write ("Option: ");
				break;	
			default:
				Console.WriteLine ("Please enter one of the numbers that corresponds with the option you want.");
				break;
			}
		}
	
		public void RunMenu()
		{
			Console.Clear ();
			Display ();
			do
			{
				CheckInput ();
			} while (_code != "0");
			Console.Clear ();
			Display ();
		}

		public void Display()
		{
			Console.WriteLine ("This is the menu. Please press the key that corresponds with the option you want.");
			Console.WriteLine ("1. Create user profile");
			Console.WriteLine ("2. Edit user profile");
			Console.WriteLine ("3. Create activity");
			Console.WriteLine ("q. Quit the program");
			Console.Write ("Option: ");
		}
	
		public string Option1()
		{
			return "Here you can create a user profile!";
			//placeholder - replace with actual function when working on that section later
		}
	
		public string Option2()
		{
			return "Here you can edit your user profile!";
			//placeholder - replace with actual function when working on that section later
		}

		public string Option3()
		{
			return "Here you can create an activity!";
			//placeholder - replace with actual function when working on that section later
		}
	}
}

