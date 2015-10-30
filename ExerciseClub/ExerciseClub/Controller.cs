using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClub
{
    class Controller
    {
        //Fields
        private List<Profile> _users;
        private List<Activity> _activities;
        private DatabaseController _profileDatabase; //Save/load profiles
        private DatabaseController _activityDatabase; //Save/load activities
        private Menu _mainMenu;
        private Profile currentLogin;
        private Activity currentActivity; //Probably unnessecary 

        //Properties
        /// <summary>
        /// Quit property to end main loop
        /// </summary>
        public bool Quit { get; private set; }

        //Constructor
        /// <summary>
        /// Default Constructor for Controller
        /// </summary>
        public Controller()
        {
            _users = new List<Profile>();
            _activities = new List<Activity>();
            _profileDatabase = new DatabaseController("info/profiles.txt");
            _activityDatabase = new DatabaseController("info/activities.txt");
            _mainMenu = new Menu();
            Quit = false;
            currentLogin = null;
            currentActivity = null;
        }
        
        //Methods
        /// <summary>
        /// Run initial set up for app
        /// </summary>
        public void StartApp()
        {
            //Load users
            List<string[]> temp = new List<string[]>();
            temp = _profileDatabase.LoadData();
            foreach(string[] line in temp)
            {
                _users.Add(MakeProfileFromStringArray(line));
            }
            //Load activities
            temp.Clear();
            temp = _activityDatabase.LoadData();
            foreach (string[] line in temp)
            {
                _activities.Add(MakeActivityFromStringArray(line));
                //TO DO: Link activities to users
            }
        }

        /// <summary>
        /// Run the app. Do the next thing. 
        /// </summary>
        public void RunApp()
        {
            string input = "";
            while (input != "quit")
            {
                if (currentLogin == null)
                {
                    LoginCreation();
                }
                else
                {
                    //Show account details
                    Console.Clear();
                    Console.WriteLine("Welcome user: " + currentLogin.Username + " (" + currentLogin.Name + ", " + currentLogin.Age + ", " + currentLogin.Location + ")");
                    //_mainMenu.Display();
                    input = _mainMenu.CheckInput();
                    if (input == "new Activity")
                    {
                        //Create new activity and add to _activities
                        string[] temp = _mainMenu.CreateActivity().Split(',');
                        var make = new String[temp.Length + 1];
                        temp.CopyTo(make, 1);
                        make[0] = currentLogin.Username;
                        Activity newActivity = MakeActivityFromStringArray(make);
                        _activities.Add(newActivity);
                        currentActivity = newActivity;
                        input = "";
                    }
                    else if (input == "logout")
                    {
                        currentLogin = null;
                    }
                    else
                    {
                        Console.ReadLine();//Force wait for input, will display submenus not yet implemented, causes double enter on quit
                    }
                }
                //Add code for edit profile
                Quit = false;
            }
            Quit = true;
        }

        /// <summary>
        /// Correctly close the app saving all data
        /// </summary>
        public void CloseApp()
        {
            List<string> temp = new List<string>();
            //Save Profiles
            foreach (Profile p in _users)
            {
                temp.Add(p.ToProfileString);
            }
            _profileDatabase.SaveData(temp);
            temp.Clear();
            //Save Activities
            foreach (Activity a in _activities)
            {
                temp.Add(a.ToActivityString);
            }
            _activityDatabase.SaveData(temp);
        }

        //Private methods
        private Profile MakeProfileFromStringArray(string[] profileString)
        {
            DateTime dob = default(DateTime);
            try
            {
                string year = profileString[3].Substring(0, 4);
                string month = profileString[3].Substring(4, 2);
                string day = profileString[3].Substring(6, 2);
                dob = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            }
            catch (ArgumentOutOfRangeException)
            {
                //Datetime not set for user
                dob = default(DateTime);
            }
            return new Profile(profileString[0], profileString[1], profileString[2], dob, profileString[4], profileString[5]);
        }

        private Activity MakeActivityFromStringArray(string[] activityString)
        {
            Profile owner = new Profile();
            foreach (Profile p in _users)
            {
                if (p.Username == activityString[0])
                {
                    owner = p;
                }
            }
            DateTime activitydate = default(DateTime);
            try
            {
                string year = activityString[3].Substring(0, 4);
                string month = activityString[3].Substring(4, 2);
                string day = activityString[3].Substring(6, 2);
                activitydate = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            }
            catch (ArgumentOutOfRangeException)
            {
                //Datetime not set for activity
                activitydate = default(DateTime);
            }
            return new Activity(owner, activityString[1], activityString[2], activitydate, activityString[4], activityString[5]);
        }

        private void LoginCreation()
        {
            //User login / Creation
            do
            {
                string input = _mainMenu.Login();
                if (input == "new")
                {
                    //Create new user and add to _users
                    Profile newProfile = MakeProfileFromStringArray(_mainMenu.CreateUser().Split(','));
                    _users.Add(newProfile);
                    currentLogin = newProfile;
                }
                else
                {
                    string[] inputs = input.Split(',');
                    foreach (Profile p in _users)
                    {
                        if (p.Username == inputs[0]) //Username matches profile
                        {
                            if (p.Login(inputs[1])) //Password matches
                            {
                                currentLogin = p;
                            }
                        }
                    }
                    if (currentLogin == null)
                    {
                        Console.WriteLine("Invalid Login");
                        Console.ReadLine();
                    }
                }
            } while (currentLogin == null);
        }
    }
}
