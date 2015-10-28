using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using ExerciseClub;

namespace ExerciseClubTest
{
    [TestFixture]
    public class DatabaseTest
    {
        [Test]
        public void TestLoad()
        {
            DatabaseController dc = new DatabaseController("testData/input.txt");
            string[] expected = { "1", "2", "3", "4", "5" };
            List<string[]> actual = dc.LoadData();
            for (int i = 0; i < 5; i++)
            {
                StringAssert.AreEqualIgnoringCase(expected[i], actual[0][i]);
            }
        }

        [Test]
        public void TestSave()
        {
            string testPath = "testData/output.txt";
            File.WriteAllText(testPath, ""); //Ensure file exists and is blank

            DatabaseController dc = new DatabaseController(testPath);
            string toSaveLine = "1,2,3,4,5";
            List<string> toSave = new List<string>();
            toSave.Add(toSaveLine);
            dc.SaveData(toSave);

            string actual = File.ReadAllText(testPath);

            StringAssert.AreEqualIgnoringCase(toSaveLine + "\r\n", actual);

        }
    }
}
