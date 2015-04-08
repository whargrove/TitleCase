using System;
using System.Linq;
using System.Text;

namespace TitleCase
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(string.Format("Converted to Title Case: {0}.", ConvertToTitleCase(args[0])));
		}

		public static string ConvertToTitleCase(string s)
		{
			if (string.IsNullOrEmpty(s))
				return string.Empty;

			var titleCased = new StringBuilder();
			var chars = s.ToArray();
			for (var i = 0; i < chars.Length; i++)
			{
				var c = chars[i];

				// If the character is whitespace, then skip
				if (char.IsWhiteSpace(c))
				{
					titleCased.Append(c);
					continue;
				}

				// If first character
				if (i == 0)
				{
					titleCased.Append(
							char.IsUpper(c) ? c : char.ToUpper(c)
						);
					continue;
				}

				// If last character
				if (i == (chars.Length - 1))
				{
					titleCased.Append(
							char.IsLower(c) ? c : char.ToLower(c)
						);
					continue;
				}

				// If the preceding character AND next character is whitespace
				// then convert to upper case
				if (char.IsWhiteSpace(chars[i - 1]) && char.IsWhiteSpace(chars[i + 1]))
				{
					titleCased.Append(
							char.IsUpper(c) ? c : char.ToUpper(c)
						);
					continue;
				}

				// If the preceding character is whitespace AND next character is a letter character
				// then convert to upper case
				if (char.IsWhiteSpace(chars[i - 1]) && char.IsLetter(chars[i + 1]))
				{
					titleCased.Append(
							char.IsUpper(c) ? c : char.ToUpper(c)
						);
					continue;
				}

				// Everything else should be lower case
				titleCased.Append(
						char.IsLower(c) ? c : char.ToLower(c)
					);
			}

			return titleCased.ToString();
		}
	}
}
