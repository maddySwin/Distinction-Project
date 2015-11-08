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
            string testActivity = "Running";
            DateTime testDate = new DateTime(2000, 01, 01);
            Profile myProfile = new Profile();
            
            Activity myActivity = new Activity();

            StringAssert.AreEqualIgnoringCase(testActivity, myActivity.Name, "Name the same");
        }

        [Test()]
        public void TestCreateCustomActivity()
        {
            string testActivity = "Tennis";
            string testLocation = "Rodlaver Arena";
            string testDescription = "TEST";
            DateTime testDate = new DateTime(2000, 01, 01);
            Profile myProfile = new Profile();

            Activity activity = new Activity(myProfile, "Tennis", "7:30", testDate, "Rodlaver Arena", "TEST");

            Assert.AreSame(testActivity, activity.Name);
            Assert.AreSame(testLocation, activity.Location);
            Assert.AreSame(testDescription, activity.Description);
        }

//        [Test()]
//        public void TestEditActivity()
//        {
//            Activity activity = new Activity();

//            EditActivity(1, "Jog");

//            Assert.AreSame("Jog", activity.Name);
//        }

//        [Test()]
//        public void TestFindActivity()
//        {
//            User user = new User();
//            Activity activity = new Activity();

//            Assert.AreSame(activity, user.FindActivity("Run"));
//            Assert.AreSame(activity, user.FindActivity("Go for a 5k run"));
//        }
    }
}
