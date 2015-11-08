using System;

namespace ExerciseClub
{
    public class MenuController
    {
        /*//Fields Unnessary to store these inputs
        private string _code;
        private string _back;*/

        //Constructor
        public MenuController()
        {
        }

        //Methods
        /// <summary>
        /// Runs login menu and collects login data from the user
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
        /// Runs the main menu
        /// </summary>
        public string MainMenu()
        {
            //Display intial menu
            Console.Clear();
            Display();
            string input = Console.ReadLine();
            string output = "";
            //Loop until valid input
            do
            {
                switch (input.ToLower())
                {
                    case "1":
                    case "activity":
                        output = "Activity";
                        break;
                    case "2":
                    case "profile":
                        output = "Profile";
                        break;
                    case "3":
                    case "logout":
                        output = "logout";
                        break;
                    case "q":
                        output = "quit";
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        Display();
                        input = Console.ReadLine();
                        break;
                }
            } while (output == "");
            return output;
        }

        public string ActivityMenu()
        {

            return "";
        }


        //Private Methods
        private void Display()
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