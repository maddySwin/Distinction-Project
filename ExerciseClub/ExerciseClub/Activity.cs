using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClub
{
    class Activity
    {
        private string _time;
        //private Profile _profile;
        private DateTime _dateOfActivity;

        public string Name { get; private set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public Activity()
        {

        }

        public Activity(string name, string time, DateTime dateOfActivity, string location, string description)
        {
            Name = name;
            _time = time;
            _dateOfActivity = dateOfActivity;
            Location = location;
            Description = description;
        }

        public string ToString
        {
            get
            {
                return Name + "," + _time + "," + _dateOfActivity.ToString("yyyMMdd") + "," + Location + "," + Description;
            }
        }

        




    }
}
