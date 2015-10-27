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
        public DatabaseController(string fileLocation)
        {
            _fileLocation = fileLocation;
        }
        public DatabaseController() : this(@"info/profiles.txt")
        {
        }

        

        //Methods
        public List<string[]> LoadData()
        {
            List<string[]> result = new List<string[]>();
            result.Clear();
            int counter = 0;
            string line;

            StreamReader sr = new StreamReader(_fileLocation);

            while ((line = sr.ReadLine()) != null)
            {
                result.Add(line.Split(','));
                counter++;
            }
            sr.Close();

            return result;
        }

        public void SaveData(List<string> data)
        {
            StreamWriter sw = new StreamWriter(_fileLocation);

            foreach (string line in data)
            {
                sw.WriteLine(line);
            }
        }
    }
}
