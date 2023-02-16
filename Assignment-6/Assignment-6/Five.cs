using System.Text;

namespace Assignment_6
{
	internal class Five
	{
		public static string FiveOneFive(int input)
		{
			var numbers = input.ToString().ToCharArray();
			var biggest = numbers[0];
			foreach (var number in numbers)
			{
				if (number > biggest)
				{
					biggest = number;
				}
			}

			return biggest.ToString();
		}

		public static string FiveOneSix(string input)
		{
			var numbers = input.Split(" ");
			var stringBuilder = new StringBuilder();
			foreach (var number in numbers)
			{
				if (number.Length == 2)
				{
					if (number[0] != number[1])
					{
						stringBuilder.Append(number + " ");
					}
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}

		public static string FiveOneSeven(string input)
		{
			var numbers = input.Split(" ");
			var stringBuilder = new StringBuilder();
			foreach (var number in numbers)
			{
				if (number.Length == 3)
				{
					if (number[0] == number[2])
					{
						stringBuilder.Append(number + " ");
					}
				}
			}

			return stringBuilder.ToString().TrimEnd();
		}
	}
}
