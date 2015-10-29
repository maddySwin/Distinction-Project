using System;
using NUnit.Framework;
using ExerciseClub;

namespace ExerciseClubTest
{
    [TestFixture()]
    public class ActivityTestClass
    {
        [Test()]
        public void TestCreateNewActivity()
        {
            string testActivity = "Tennis";
            string testTime = "7:30";
            DateTime testDate = new DateTime(2000, 01, 01);
            string testLocation = "Rodlaver Arena";
            string testDescription = "TEST";
            Activity myActivity = new Activity(testActivity, testTime, testDate, testLocation, testDescription);

            StringAssert.AreEqualIgnoringCase(testActivity, myActivity.Name, "Name not the same");
        }

        [Test()]
        public void TestCreateCustomActivity()
        {
            Activity activity = new Activity("Basketball", "11:00", DateTime(2015, 10, 27), "Hawthorn", "Play a game of basketball");

            Assert.AreSame("Basketball", activity.Name);
            Assert.AreSame("11:00", activity.Time);
            Assert.AreSame(DateTime(2015, 10, 27), activity.Date);
            Assert.AreSame("Hawthorn", activity.Location);
            Assert.AreSame("Play a game of basketball", activity.Description);
        }

        [Test()]
        public void TestEditActivity()
        {
            Activity activity = new Activity();

            EditActivity(1, "Jog");

            Assert.AreSame("Jog", activity.Name);
        }

        [Test()]
        public void TestFindActivity()
        {
            User user = new User();
            Activity activity = new Activity();

            Assert.AreSame(activity, user.FindActivity("Run"));
            Assert.AreSame(activity, user.FindActivity("Go for a 5k run"));
        }
    }
}
