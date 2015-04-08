using NUnit.Framework;

namespace TitleCase
{
	[TestFixture]
	class ProgramTest
	{
		[Test]
		public void ConvertToTitleCase_ShouldReturnEmptyString()
		{
			// Given an empty string
			var s = string.Empty;
			var expected = string.Empty;
			// When ConvertToTitleCase is called
			var actual = Program.ConvertToTitleCase(s);
			// Then the result is an empty string
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void ConvertToTitleCase_ShoudlReturnTitleCasedString()
		{
			// Given a string
			var s = "a MesSEd uP stRiNG";
			var expected = "A Messed Up String";
			// When ConvertToTitleCase is called
			var actual = Program.ConvertToTitleCase(s);
			// Then the result is a title-cased string
			Assert.AreEqual(expected, actual);
		}
	}
}
