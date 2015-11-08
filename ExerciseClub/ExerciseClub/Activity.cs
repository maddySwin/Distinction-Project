using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClub
{
    public class Activity
    {
        //Fields
        public Profile Owner;
        private DateTime _dateOfActivity;

        //Auto-Properties
        public string Name { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        //Properties
        public string ToActivityString
        {
            get
            {
                return Owner.Username + "," + Name + "," + Time + "," + _dateOfActivity.ToString("yyyyMMdd") + "," + Location + "," + Description;
            }
        }

        //Constructors
        public Activity(Profile owner, string name, string time, DateTime dateOfActivity, string location, string description)
        {
            Owner = owner;
            Name = name;
            Time = time;
            _dateOfActivity = dateOfActivity;
            Location = location;
            Description = description;
        }
        /// <summary>
        /// Default constructor for activity
        /// </summary>
        public Activity() : this(new Profile(), "Running", "12:00pm", DateTime.Today, "Hawthorn", "A fun run in the park") { }


        

        




    }
}
