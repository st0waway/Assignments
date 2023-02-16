using System.Text;
using System.Text.RegularExpressions;

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

		public static string FourEleven(string words)
		{
			var longestWord = string.Empty;
			var longestWordLength = 0;
			var splitWords = words.Split(" ");
			foreach (var splitWord in splitWords)
			{
				if (splitWord.Length > longestWordLength)
				{
					longestWordLength = splitWord.Length;
					longestWord = splitWord;
				}
			}

			return longestWord;
		}

		public static string FourTwelve(string words)
		{
			var splitWords = words.Split(" ");
			var stringBuilder = new StringBuilder();
			foreach (var splitWord in splitWords)
			{
				if (splitWord.Length >= 7)
				{
					stringBuilder.Append(splitWord + " ");
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FourThirteen(string words)
		{
			var splitWords = words.Split(" ");
			var shortestWord = splitWords[0];
			var shortestLength = splitWords[0].Length;

			foreach (var splitWord in splitWords)
			{
				if (splitWord.Length <= shortestLength)
				{
					shortestLength = splitWord.Length;
					shortestWord = splitWord;
				}
			}

			return shortestWord;
		}

		public static string FourFourteen(string words)
		{
			var splitWords = words.Split(" ");
			var stringBuilder = new StringBuilder();
			foreach (var splitWord in splitWords)
			{
				if (splitWord.Length < 3)
				{
					stringBuilder.Append(splitWord + " ");
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FourFifteen(string words)
		{
			var splitWords = words.Split(" ");
			var stringBuilder = new StringBuilder();
			foreach (var splitWord in splitWords)
			{
				if (splitWord.SequenceEqual(splitWord.Reverse()))
				{
					stringBuilder.Append(splitWord + " ");
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FourSixteen(string words)
		{
			words = Regex.Replace(words, " *, *", ", ");
			return words;
		}

		public static string FourSeventeen(string words)
		{
			var output = string.Join(" ", words.Split(" ").Distinct());
			return output;
		}

		public static string FourEighteen(string words, int times)
		{
			var stringBuilder = new StringBuilder();
			
			var splitWords = words.Split(" ");
			var counter = 0;
			foreach (var splitWord in splitWords)
			{
				counter = splitWords.Where(e => e == splitWord).Count();
				if (counter > times)
				{
					stringBuilder.Append(splitWord + " ");
				}

				counter = 0;
			}

			var filteredWords = string.Join(" ", stringBuilder.ToString().Split(" ").Distinct());
			return filteredWords;
		}

		public static string FourNineteen(string words)
		{
			var splitWords = words.Split(" ");
			Array.Sort(splitWords);
			return string.Join(" ", splitWords);
		}

		public static string FourTwenty(string words)
		{
			var splitWords = words.Split(" ");
			Array.Sort(splitWords, (x, y) => x.Length.CompareTo(y.Length));
			return string.Join(" ", splitWords);
		}

	}
}
