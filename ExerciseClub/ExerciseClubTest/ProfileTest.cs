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
            string testPassword = "12345";
            Profile myProfile = new Profile(testUsername, testPassword, testName);

            StringAssert.AreEqualIgnoringCase(testName, myProfile.Name, "Name not the same");
        }

        [Test]
        public void TestAge()
        {
            string testName = "Steve";
            string testUsername = "sJones";
            string testPassword = "12345";
            DateTime testDate = new DateTime(2000,01,01);
            Profile myProfile = new Profile(testUsername, testPassword, testName, testDate);

            Assert.AreEqual(DateTime.Now.Year - 2000, myProfile.Age);
        }

        [Test]
        public void TestToString()
        {
            string testName = "Steve";
            string testUsername = "sJones";
            string testPassword = "12345";
            DateTime testDate = new DateTime(2000, 01, 01);
            Profile myProfile = new Profile(testUsername, testPassword, testName, testDate);

            StringAssert.AreEqualIgnoringCase("sJones,12345,Steve,20000101,Hawthorn,About Me", myProfile.ToProfileString);
        }


    }
}
