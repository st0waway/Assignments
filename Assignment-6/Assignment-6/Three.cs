using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_6
{
	internal class Three
	{
		public static string ThreeOne(string letters, char x, char y)
		{
			var sb = new StringBuilder();
			var output = string.Empty;
			foreach (var letter in letters)
			{
				sb.Append(letter);
				if (letter == y)
				{
					sb.Append(x);
				}
			}

			return sb.ToString();
		}

		public static string ThreeTwo(string letters)
		{
			var output = string.Empty;
			for (int i = 0; i < letters.Length; i++)
			{
				output += letters[i+1];
				output += letters[i++];
			}

			return output;
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
			var sb = new StringBuilder();
			foreach (var letter in letters)
			{
				sb.Append(letter);
				if (letter == x)
				{
					sb.Append(letter);
				}
			}
			return sb.ToString();
		}

		public static string ThreeNine(string text, char x)
		{
			var remainingCharacters = text.Where(e => e != x);
			var sb = new StringBuilder();
			foreach (var remainingCharacter in remainingCharacters)
			{
				sb.Append(remainingCharacter);
			}

			return sb.ToString();
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

		public static int[] ThreeFourteen(string letters, char x)
		{
			var first = letters.IndexOf(x);
			var last = letters.LastIndexOf(x);
			
			return new int[] { first, last };
		}

		public static string ThreeFifteen(string letters)
		{
			letters = letters.Replace("...", "…");
			return letters;
		}

		public static string ThreeSixteen(string letters)
		{
			var index = letters.IndexOf(":");
			var output = letters.Substring(0, index);
			return output;
		}

		public static string ThreeSeventeen(string letters)
		{
			var index = letters.IndexOf(":") + 1;
			var output = letters.Substring(index, letters.Length - index);
			return output;
		}

		public static string ThreeEighteen(string letters)
		{
			var output = string.Empty;
			var firstIndex = letters.IndexOf("(") + 1;
			var secondIndex = letters.IndexOf(")");
			output = letters.Substring(0, firstIndex);
			output += letters.Substring(secondIndex, letters.Length - secondIndex);
			return output;
		}

		public static string ThreeNineteen(string letters)
		{
			var output = string.Empty;
			var firstIndex = letters.IndexOf("{") + 1;
			var secondIndex = letters.IndexOf("}");
			output = letters.Substring(0, firstIndex);
			output += letters.Substring(secondIndex, letters.Length - secondIndex);
			return output;
		}

		public static string ThreeTwenty(string letters)
		{
			var aCount = letters.Where(e => e == 'a').Count();
			var bCount = letters.Where(e => e == 'b').Count();
			return $"a: {aCount}, b: {bCount}";
		}
	}
}
