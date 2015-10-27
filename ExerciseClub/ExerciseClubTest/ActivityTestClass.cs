using NUnit.Framework;
using System;

namespace Application
{
	[TestFixture ()]
	public class ActivityTestClass
	{
		[Test ()]
		public void TestCreateNewActivity ()
		{
			Activity activity = new Activity ();

			Assert.AreSame ("Run", activity.Name);
			Assert.AreSame ("12:00", activity.Time);
			Assert.AreSame (DateTime (2015, 1, 1), activity.Date);
			Assert.AreSame ("Melbourne", activity.Location);
			Assert.AreSame ("Go for a 5k run", activity.Description);
		}

		[Test()]
		public void TestCreateCustomActivity()
		{
			Activity activity = new Activity ("Basketball", "11:00", DateTime(2015, 10, 27), "Hawthorn", "Play a game of basketball");

			Assert.AreSame ("Basketball", activity.Name);
			Assert.AreSame ("11:00", activity.Time);
			Assert.AreSame (DateTime (2015, 10, 27), activity.Date);
			Assert.AreSame ("Hawthorn", activity.Location);
			Assert.AreSame ("Play a game of basketball", activity.Description);
		}

		[Test()]
		public void TestEditActivity()
		{
			Activity activity = new Activity ();

			EditActivity (1, "Jog");

			Assert.AreSame ("Jog", activity.Name);
		}

		[Test()]
		public void TestFindActivity()
		{
			User user = new User ();
			Activity activity = new Activity ();

			Assert.AreSame (activity, user.FindActivity ("Run"));
			Assert.AreSame (activity, user.FindActivity ("Go for a 5k run"));
		}
	}
}

