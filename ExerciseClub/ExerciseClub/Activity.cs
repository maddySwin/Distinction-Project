using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClub
{
    class Activity
    {
        //Fields
        private string _time;
        //private Profile _profile;
        private DateTime _dateOfActivity;

        //Auto-Properties
        public string Name { get; private set; }
        public string Location { get; set; }
        public string Description { get; set; }

        //Properties
        public string ToActivityString
        {
            get
            {
                return Name + "," + _time + "," + _dateOfActivity.ToString("yyyyMMdd") + "," + Location + "," + Description;
            }
        }

        //Constructors
        public Activity(string name, string time, DateTime dateOfActivity, string location, string description)
        {
            Name = name;
            _time = time;
            _dateOfActivity = dateOfActivity;
            Location = location;
            Description = description;
        }
        /// <summary>
        /// Default constructor for activity
        /// </summary>
        public Activity() : this("Running", "12:00pm", DateTime.Today, "Hawthorn", "A fun run in the park") { }


        

        




    }
}
