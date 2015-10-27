using System;
using NUnit.Framework;
using ExerciseClub;

namespace ExerciseClubTest
{
    [TestFixture]
    public class MenuTest
    {
        [Test]
		public void TestMenuResult ()
		{
			Menu mainMenu = new Menu();
			string option1 = mainMenu.Option1 ();
			string option2 = mainMenu.Option2 ();
			string option3 = mainMenu.Option3 ();

			Assert.IsTrue (option1 == "Here you can create a user profile!");
			Assert.IsTrue (option2 == "Here you can edit your user profile!");
			Assert.IsTrue (option3 == "Here you can create an activity!");
        }
    }
}
