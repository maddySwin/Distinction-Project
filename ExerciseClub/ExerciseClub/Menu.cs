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
        /// Checks the input from the user and does something depending on input
        /// </summary>
        public string CheckInput()
        {
            _code = Console.ReadLine();
            _back = "0. Return to main menu";
            string c1 = "case1";
            string c2 = "case2";
            string c3 = "case3";
            string c0 = "back";
            string cd = "default";
            string quit = "quit";

            switch (_code)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(Option1());
                    Console.WriteLine(_back);
                    Console.WriteLine("q. Quit the program");
                    Console.Write("Option: ");
                    return c1;
                case "2":
                    Console.Clear();
                    Console.WriteLine(Option2());
                    Console.WriteLine(_back);
                    Console.WriteLine("q. Quit the program");
                    Console.Write("Option: ");
                    return c2;
                case "3":
                    Console.Clear();
                    Console.WriteLine(Option3());
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
        public void RunMenu()
        {
            Display();
            do
            {
                CheckInput();
            } while (_code != "0");
            Console.Clear();
            Display();
        }


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

        public string Option1()
        {
            return "Here you can create an activity!";
            //placeholder - replace with actual function when working on that section later
        }

        public string Option2()
        {
            return "Here you can edit your user profile!";
            //placeholder - replace with actual function when working on that section later
        }

        public string Option3()
        {
            return "Here you can logout!";
            //placeholder - replace with actual function when working on that section later
        }
    }
}