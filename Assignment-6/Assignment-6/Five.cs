using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment_6
{
	internal class Five
	{
		public static string FiveOneOne(int x1, int y1, int x2, int y2)
		{
			return $"{x1 - x2}, {y1 - y2}";
		}

		public static string FiveOneTwo(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			var length = x3 - x2;
			var height = y1 - y2;
			double area = (length * height) / 2;

			return area.ToString();
		}

		public static string FiveOneThree(int r, int R)
		{
			var area = Math.PI * ((R * R) - (r * r));
			return area.ToString();
		}

		public static string FiveOneFour(int a, int b, int c)
		{
			double d = b * b - 4 * a * c;
			if (d == 0)
			{
				double x1 = -b / (2.0 * a);
				double x2 = x1;
				return $"first root is {x1}, second root is {x2}";
			}

			if (d > 0)
			{
				double x1 = (-b + Math.Sqrt(d)) / (2 * a);
				double x2 = (-b - Math.Sqrt(d)) / (2 * a);
				return $"first root is {x1}, second root is {x2}";
			}

			return "no solution";
		}

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

		public static string FiveTwo(string input)
		{
			var stringBuilder = new StringBuilder();
			var reversedLetters = input.ToCharArray().Reverse();
			foreach (var reversedLetter in reversedLetters)
			{
				stringBuilder.Append(reversedLetter);
			}

			return stringBuilder.ToString();
		}

		public static string FiveThree(string letters)
		{
			if (letters.SequenceEqual(letters.Reverse()))
			{
				return "it is";
			}
			return "it isn't";
		}



		public static string FiveFour(params int[] numbers)
		{
			var sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
			}

			return sum.ToString();
		}

		public static string FiveFive()
		{
			var numbers = new StringBuilder();
			var result = 0;
			for (int i = 0; result < 990; i++)
			{
				result += i;
				numbers.Append(result + " ");
			}

			return numbers.ToString().TrimEnd();
		}

		public static string FiveSix(int baseNumber, int exponent)
		{
			var result = baseNumber;
			for (int i = 1; i < exponent; i++)
			{
				result *= baseNumber;
			}

			return result.ToString();
		}

	}
}
