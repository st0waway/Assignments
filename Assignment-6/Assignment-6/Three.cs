using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_6
{
	internal class Three
	{
		public static void ThreeOne(string x, string y)
		{

		}

		public static char ThreeThree(string text, char x, char y)
		{
			var xCount = text.Count(e => e.Equals(x));
			var yCount = text.Count(e => e.Equals(y));
			if (xCount > yCount)
			{
				return x;
			}

			return y;
		}

		public static int[] ThreeFour(string text, char x, char y)
		{
			var xCount = text.Count(e => e.Equals(x));
			var yCount = text.Count(e => e.Equals(y));
			return new int[] { xCount, yCount };
		}

		public static int ThreeFive(string text)
		{
			return text.Distinct().Count();
		}

		public static bool ThreeSix(string text)
		{
			for (int i = 0; i < text.Length; i++)
			{
				if (i != text.Length-1)
				{
					if (text[i] == text[i + 1])
					{
						return true;
					}
				}
			}
			return false;
		}

		public static string ThreeSeven(string text)
		{
			var output = string.Empty;
			if (text.Length % 2 == 0)
			{
				output = text.Substring(0, text.Length / 2 - 1);
				output += text.Substring(text.Length / 2 + 1, text.Length / 2 - 1);
			}
			else
			{
				output = output = text.Substring(0, text.Length / 2);
				output += text.Substring(text.Length / 2 + 1, text.Length / 2);
			}
			

			return output;
		}

		public static string ThreeEight(string letters, char x)
		{
			var output = string.Empty;
			foreach (var letter in letters)
			{
				output += letter;
				if (letter == x)
				{
					output += letter;
				}
			}
			return output;
		}

		public static string ThreeNine(string text, char x)
		{
			var remainingCharacters = text.Where(e => e != x);
			var output = string.Empty;
			foreach (var remainingCharacter in remainingCharacters)
			{
				output += remainingCharacter;
			}

			return output;
		}

		public static string ThreeTen(string text, string substr)
		{
			var remainingCharacters = text.Replace(substr, "");

			return remainingCharacters;
		}

		public static string ThreeEleven(string text, string substr1, string substr2)
		{
			var newText = text.Replace(substr1, substr2);
			return newText;
		}

		public static string ThreeTwelve(string text)
		{
			var output = 0;
			var numbers = text.Split(" ");
			foreach (var number in numbers)
			{
				output += int.Parse(number);
			}

			return output.ToString();
		}

		public static string ThreeThirteen(string letters)
		{
			var output = 0;
			foreach (var letter in letters)
			{
				output += int.Parse(letter.ToString());
			}
			return output.ToString();
		}
	}
}
