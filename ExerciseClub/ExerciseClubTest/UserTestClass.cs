using NUnit.Framework;
using System;

namespace ExerciseClub
{
	[TestFixture ()]
	public class UserTestClass
	{
		[Test ()]
		public void TestCreateDefaultUser ()
		{
			User user = new User ();

			Assert.AreSame ("John Smith", user.Name);
			Assert.AreSame ("jsmith", user.Username);
			Assert.AreSame ("password", user.Password);
			Assert.AreSame ("Melbourne", user.Location);
			Assert.AreSame ("Keen to exercise!", user.Description);
		}

		[Test()]
		public void TestCreateCustomUser()
		{
			User user = new User ("Mary Williams", "mwilliams", "abcdef", "Melbourne, Australia", "I love running!");

			Assert.AreSame ("Mary Williams", user.Name);
			Assert.AreSame ("mwilliams", user.Username);
			Assert.AreSame ("abcdef", user.Password);
			Assert.AreSame ("Melbourne, Australia", user.Location);
			Assert.AreSame ("I love running!", user.Description);
		}

		[Test()]
		public void TestEditUserInformation()
		{
			User user = new User ();

			user.EditInformation (1, "Jane Smith");

			Assert.AreSame ("Jane Smith", user.Name);
		}

		[Test()]
		public void TestFindUser()
		{
			User user1 = new User ();
			User user2 = new User ("Mary Williams", "mwilliams", "abcdef", "Melbourne, Australia", "I love running!");

			Assert.AreSame(user2, user1.FindUser ("Mary Williams"));
			Assert.AreSame(user2, user1.FindUser ("Mary"));
		}


	}
}

