using System;

namespace ExerciseClub
{
	public class Menu
	{
        //Fields
		private string _code;
		private string _back;

        //Auto Properties
        public bool Quit { get; private set; }

        //Constructor
		public Menu ()
		{
            Quit = false;
		}

        //Methods
        /// <summary>
        /// Runs login menu and collects login data
        /// </summary>
        /// <returns>Username and Password concatinated string</returns>
        public string Login()
        {
            string username = "", password = "";
            bool valid = false;
            string option = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Exercise Club\n1. Login\n2. Create New Profile");
                Console.Write("Option: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        //Get login information
                        Console.Clear();
                        Console.Write("Username: ");
                        username = Console.ReadLine();
                        Console.Write("Password: ");
                        password = Console.ReadLine();
                        valid = true;
                        break;
                    case "2":
                        //Create new profile
                        valid = true;
                        return "new";
                    default:
                        Console.WriteLine("Please enter a valid option");
                        Console.ReadLine();
                        break;
                }
            } while (!valid);


            return (username + "," + password);
        }

        public string CreateUser()
        {
            string profileString = "";
            Console.Clear();
            Console.WriteLine("Create Account. Please enter all data");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Name: ");
            string name  = Console.ReadLine();
            Console.Write("Date of Birth (yyyymmdd): ");
            string dob = Console.ReadLine();
            Console.Write("Location: ");
            string location = Console.ReadLine();
            Console.Write("Description: ");
            string desc = Console.ReadLine();
            profileString = username + "," + password + "," + name + "," + dob + "," + location + "," + desc;
            return profileString;
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

