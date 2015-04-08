using NUnit.Framework;

namespace TitleCase
{
	[TestFixture]
	class ProgramTest
	{
		[Test]
		[TestCase("")]
		[TestCase(null)]
		public void ConvertToTitleCase_ShouldReturnEmptyString(string s)
		{
			// Given an empty string (see TestCases)
			var expected = string.Empty;
			// When ConvertToTitleCase is called
			var actual = Program.ConvertToTitleCase(s);
			// Then the result is an empty string
			Assert.AreEqual(expected, actual);
		}

		[Test]
		[TestCase("a MesSEd uP stRiNG")]
		public void ConvertToTitleCase_ShoudlReturnTitleCasedString(string s)
		{
			// Given a string (see TestCases)
			var expected = "A Messed Up String";
			// When ConvertToTitleCase is called
			var actual = Program.ConvertToTitleCase(s);
			// Then the result is a title-cased string
			Assert.AreEqual(expected, actual);
		}
	}
}
