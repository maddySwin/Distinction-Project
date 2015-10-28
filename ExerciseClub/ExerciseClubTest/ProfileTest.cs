using System;
using NUnit.Framework;
using ExerciseClub;

namespace ExerciseClubTest
{
    [TestFixture]
    public class ProfileTest
    {
        [Test]
        public void TestCreation()
        {
            string testName = "Steve";
            string testUsername = "sJones";
            Profile myProfile = new Profile(testUsername, testName);

            StringAssert.AreEqualIgnoringCase(testName, myProfile.Name, "Name not the same");
        }

        [Test]
        public void TestAge()
        {
            string testName = "Steve";
            string testUsername = "sJones";
            DateTime testDate = new DateTime(2000,01,01);
            Profile myProfile = new Profile(testUsername, testName, testDate);

            Assert.AreEqual(DateTime.Now.Year - 2000, myProfile.Age);
        }

        [Test]
        public void TestToString()
        {
            string testName = "Steve";
            string testUsername = "sJones";
            DateTime testDate = new DateTime(2000, 01, 01);
            Profile myProfile = new Profile(testUsername, testName, testDate);

            StringAssert.AreEqualIgnoringCase("sJones,Steve,20000101,Hawthorn,About Me", myProfile.ToString);
        }


    }
}
