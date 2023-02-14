using static System.Net.Mime.MediaTypeNames;

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
	}
}
