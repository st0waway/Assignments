using System.Text;

namespace Assignment_6
{
	internal class Four
	{

		public static string FourOne(string words, string substring)
		{
			var stringBuilder = new StringBuilder();
			var splitWords = words.Split(' ');
			foreach (var splitWord in splitWords)
			{
				if (splitWord.Contains(substring))
				{
					stringBuilder.Append(splitWord + " ");
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FourTwo(string words, int n)
		{
			var stringBuilder = new StringBuilder();
			var splitWords = words.Split(' ');
			foreach (var splitWord in splitWords)
			{
				if (splitWord.Length <= n)
				{
					stringBuilder.Append(splitWord + " ");
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FourThree(string words)
		{
			var stringBuilder = new StringBuilder();
			var splitWords = words.Split(" ");
			foreach (var splitWord in splitWords)
			{
				if (Char.IsUpper(splitWord[0]))
				{
					stringBuilder.Append(splitWord + " ");
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FourFour(string words)
		{
			var stringBuilder = new StringBuilder();
			var splitWords = words.Split(" ");
			foreach (var splitWord in splitWords)
			{
				if (splitWord.Any(Char.IsDigit))
				{
					stringBuilder.Append(splitWord + " ");
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FourFive(string words, char x)
		{
			var stringBuilder = new StringBuilder();
			var splitWords = words.Split(" ");
			foreach (var splitWord in splitWords)
			{
				if (splitWord[splitWord.Length - 1].Equals(x))
				{
					stringBuilder.Append(splitWord + " ");
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FourSix(string words, char x)
		{
			var stringBuilder = new StringBuilder();
			var splitWords = words.Split(" ");
			foreach (var splitWord in splitWords)
			{
				if (!splitWord.Contains(x))
				{
					stringBuilder.Append(splitWord + " ");
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FourSeven(string words)
		{
			var stringBuilder = new StringBuilder();
			var splitWords = words.Split(" ");
			foreach (var splitWord in splitWords)
			{
				if (splitWord.Length > 1)
				{
					stringBuilder.Append(splitWord + " ");
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FourEight(string words)
		{
			var output = string.Join(" ", words.Split(" ").Distinct());
			return output.Trim();
		}

		public static string FourNine(string words, string indicatedWord)
		{
			var splitWords = words.Split(" ");
			var number = splitWords.Count(e => e == indicatedWord);
			return $"The word {indicatedWord} occurs {number} times";
		}

		public static string FourTen(string words)
		{
			var counter = 0;
			var splitWords = words.Split();
			foreach (var splitWord in splitWords)
			{
				if (Char.IsUpper(splitWord[0]))
				{
					counter++;
				}
			}

			return counter.ToString();
		}
	}
}
