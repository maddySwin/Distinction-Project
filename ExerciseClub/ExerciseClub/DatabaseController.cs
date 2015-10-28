using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ExerciseClub
{
    public class DatabaseController
    {
        //Fields
        private string _fileLocation;

        //Constructor
        /// <summary>
        /// Custom Constructor for database controller, Can set output file path
        /// </summary>
        /// <param name="fileLocation">String file path for database</param>
        public DatabaseController(string fileLocation)
        {
            _fileLocation = fileLocation;
        }
        /// <summary>
        /// Default constructor for Database controller
        /// </summary>
        public DatabaseController() : this(@"info/profiles.txt")
        {
        }

        //Methods
        /// <summary>
        /// Reads all lines from a text file database and Returns as a list of string arrays
        /// </summary>
        /// <returns>List of string arrays representing data</returns>
        public List<string[]> LoadData()
        {
            List<string[]> result = new List<string[]>();
            result.Clear();
            int counter = 0;
            string line;

            StreamReader sr = new StreamReader(_fileLocation);

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                result.Add(line.Split(','));
                counter++;
            }
            sr.Close();

            return result;
        }

        /// <summary>
        /// Writes the given list of strings to a text file
        /// </summary>
        /// <param name="data">Data to be written</param>
        public void SaveData(List<string> data)
        {
            //StreamWriter sw = new StreamWriter(_fileLocation);
            string output = "";
            foreach (string line in data)
            {
                output += line + "\n";
            }
            File.WriteAllText(_fileLocation, output);
            //sw.Close();
        }
    }
}
