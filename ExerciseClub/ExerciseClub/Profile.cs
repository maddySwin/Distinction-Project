﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseClub
{
    public class Profile
    {
        //Fields
        private DateTime _dateOfBirth;
        private string _username;
        //private string _password; May be unnessary will depend on implementation of login

        //Auto properties
        /// <summary>
        /// Profile name
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The location of the user
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Description of the user
        /// </summary>
        public string Description { get; set; }

        
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
        /// <summary>
        /// Output all data of profile as single string
        /// </summary>
        public string ToString
        {
            get
            {
                return _username + "," + Name + "," + _dateOfBirth.ToString() + "," + Location + "," + Description;
            }
        }

        //Constructors
        /// <summary>
        /// Constructor with name for Profile
        /// </summary>
        /// <param name="name">Name for the profile</param>
        public Profile(string name) : this(name, new DateTime(1990, 1, 1)) { }
        /// <summary>
        /// Constructor for Profile
        /// </summary>
        /// <param name="name">Name of the User</param>
        /// <param name="dateOfBirth">DateTime element date of birth</param>
        public Profile(string name, DateTime dateOfBirth) :this(name, dateOfBirth,"Hawthorn","About me") { }

        /// <summary>
        /// Full constructor for Profile
        /// </summary>
        /// <param name="name">Name of the user</param>
        /// <param name="dateOfBirth">DateTime element date of birth</param>
        /// <param name="Location">Home location for User</param>
        /// <param name="Description">Short profile description</param>
        public Profile(string name, DateTime dateOfBirth, string location, string description)
        {
            Name = name;
            _dateOfBirth = dateOfBirth;
            Location = location;
            Description = description;
        }
    }
}
