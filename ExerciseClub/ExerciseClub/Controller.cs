﻿using System;
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
        private DatabaseController _datebase;
        private Menu _mainMenu;
        private Profile currentLogin;
        private Activity currentActivity;

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
            _datebase = new DatabaseController();
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
            List<string[]> temp = new List<string[]>();
            temp = _datebase.LoadData();
            foreach(string[] line in temp)
            {
                _users.Add(MakeProfileFromStringArray(line));
            }
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

        public void StartActivity()
        {
            do
            {
                string input = _mainMenu.CheckInput();
                if (input == "case1")
                {
                    //Create new activity and add to _users
                    Activity newActivity = MakeActivityFromStringArray(_mainMenu.CreateUser().Split(','));
                    _activities.Add(newActivity);
                    currentActivity = newActivity;
                }
            } while (currentActivity == null);
        }



        /// <summary>
        /// Run the app. Do the next thing. 
        /// </summary>
        public void RunApp()
        {
            //_mainMenu.RunMenu();
            //if (_mainMenu.Quit) Quit = true;

            //Show account details
            Console.Clear();
            Console.WriteLine("Welcome user: " + currentLogin.Username + " (" + currentLogin.Name + ", " + currentLogin.Age + ", " + currentLogin.Location + ")");
            _mainMenu.Display();
            while (_mainMenu.CheckInput() != "quit")
            {
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
            foreach (Profile p in _users)
            {
                temp.Add(p.ToString);
            }
            _datebase.SaveData(temp);
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
                //Datetime not set for user
                activitydate = default(DateTime);
            }
            return new Activity(activityString[0], activityString[1], activitydate, activityString[3], activityString[4]);
        }
    }
}
