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
            Profile myProfile = new Profile(testName);

            StringAssert.AreEqualIgnoringCase(testName, myProfile.Name, "Name not the same");
        }

        [Test]
        public void TestAge()
        {
            string testName = "Steve";
            DateTime testDate = new DateTime(2000,01,01);
            Profile myProfile = new Profile(testName,testDate);

            Assert.AreEqual(15, myProfile.Age);
        }
    }
}
