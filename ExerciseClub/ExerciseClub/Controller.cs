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
        private DatabaseController _datebase;
        private Menu _mainMenu;

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
                _users.Add(new Profile(line[0]));
            }
        }

        /// <summary>
        /// Run the app. Do the next thing. 
        /// </summary>
        public void RunApp()
        {
            _mainMenu.RunMenu();
            if (_mainMenu.Quit) Quit = true;
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

    }
}
