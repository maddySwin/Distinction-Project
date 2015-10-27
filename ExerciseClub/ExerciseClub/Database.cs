using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ExerciseClub
{
    public class Database
    {
        //Fields
        private string _fileLocation;
        private List<string[]> _data = new List<string[]>();


        //Constructor
        public Database(string fileLocation)
        {
            _fileLocation = fileLocation;
        }
        public Database() : this(@"info/save.txt")
        {
        }

        

        //Methods
        private void LoadData()
        {
            _data.Clear();
            int counter = 0;
            string line;

            StreamReader sr = new StreamReader(_fileLocation);

            while ((line = sr.ReadLine()) != null)
            {
                _data.Add(line.Split(','));
                counter++;
            }
            sr.Close();
        }

        private void SaveData()
        {
            StreamWriter sw = new StreamWriter(_fileLocation);

            foreach (string[] line in _data)
            {
                sw.WriteLine(String.Join(",",line));
            }
        }
    }
}
