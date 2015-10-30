using System;

namespace ExerciseClub
{
    public class Menu
    {
        //Fields
        private string _code;
        private string _back;

        //Constructor
        public Menu()
        {
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

        /// <summary>
        /// Run the menu to create a user
        /// </summary>
        /// <returns>Returns a profile in string form</returns>
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
            string name = Console.ReadLine();
            Console.Write("Date of Birth (yyyymmdd): ");
            string dob = Console.ReadLine();
            Console.Write("Location: ");
            string location = Console.ReadLine();
            Console.Write("Description: ");
            string desc = Console.ReadLine();
            profileString = username + "," + password + "," + name + "," + dob + "," + location + "," + desc;
            return profileString;
        }

        /// <summary>
        /// Runs the menu to create activity
        /// </summary>
        /// <returns>Returns an activity in string form</returns>
        public string CreateActivity()
        {
            string activityString = "";
            Console.Clear();
            Console.WriteLine("Create Activity. Please enter all data");
            Console.Write("Activity Name: ");
            string name = Console.ReadLine();
            Console.Write("Time: ");
            string time = Console.ReadLine();
            Console.Write("Activity Date (yyyymmdd): ");
            string activitydate = Console.ReadLine();
            Console.Write("Location: ");
            string location = Console.ReadLine();
            Console.Write("Description: ");
            string desc = Console.ReadLine();
            activityString = name + "," + time + "," + activitydate + "," + location + "," + desc;
            return activityString;
        }

        /// <summary>
        /// Checks the input from the user and does something depending on input
        /// </summary>
        public string CheckInput()
        {
            Console.Clear();
            Display();
            _code = Console.ReadLine();
            _back = "0. Return to main menu";
            string c1 = "new Activity";
            string c2 = "editProfile";
            string c3 = "logout";
            string c0 = "back";
            string cd = "default";
            string quit = "quit";

            switch (_code)
            {
                case "1":
                    
                    Console.Clear();
                    Console.WriteLine("Here you can create an activity!");
                    Console.WriteLine(_back);
                    Console.WriteLine("q. Quit the program");
                    Console.Write("Option: ");
                    return c1;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Here you can edit your user profile! (to be implemented)");
                    Console.WriteLine(_back);
                    Console.WriteLine("q. Quit the program");
                    Console.Write("Option: ");
                    return c2;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Here you can logout!");
                    Console.WriteLine(_back);
                    Console.WriteLine("q. Quit the program");
                    Console.Write("Option: ");
                    return c3;
                case "0":
                    Console.Clear();
                    Display();
                    return c0;
                case "q":
                    return quit;
                default:
                    Console.WriteLine("Please enter one of the numbers that corresponds with the option you want.");
                    return cd;
            }
        }

        /// <summary>
        /// Runs the menu.
        /// </summary>
        //public void RunMenu()
        //{
         //   Display();
         //   do
         //   {
          //      CheckInput();
         //   } while (_code != "0");
        //    Console.Clear();
        //    Display();
        //}


        /// <summary>
        /// This is the initial menu display showing the options available
        /// </summary>
        public void Display()
        {
            Console.WriteLine("This is the main menu. Please press the key that corresponds with the option you want.");
            Console.WriteLine("1. Create activity");
            Console.WriteLine("2. Edit user profile");
            Console.WriteLine("3. Logout");
            Console.WriteLine("q. Quit the program");
            Console.Write("Option: ");
        }

    }
}