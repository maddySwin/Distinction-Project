using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseClubTest
{
    public class Profile
    {
        //Fields
        private DateTime _dateOfBirth;

        //Auto properties
        /// <summary>
        /// Profile name
        /// </summary>
        public string Name { get; private set; }
        
        //Properties
        /// <summary>
        /// Returns current age of profile user
        /// </summary>
        public int Age
        {
            get
            {
                DateTime zeroTime = new DateTime(1, 1, 1); //Get a zero
                TimeSpan span = DateTime.Now - _dateOfBirth; //Get difference between dates
                int age = (zeroTime + span).Year - 1; //Subtract one for gregorian calendar
                return age;
            }
        }

        //Constructors
        /// <summary>
        /// Constructor with name for Profile
        /// </summary>
        /// <param name="name">Name for the profile</param>
        public Profile(string name)
        {
            Name = name;
        }

        public Profile(string name, DateTime dateOfBirth) : this(name)
        {
            _dateOfBirth = dateOfBirth;
        }
    }
}
