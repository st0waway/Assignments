using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_6
{
	internal class One
	{
		public static int[] OneOne(int[] numbers)
		{
			var oddNumbers = new List<int>();
			foreach (var number in numbers)
			{
				if (number % 2 != 0)
				{
					oddNumbers.Add(number);
				}
			}

			return oddNumbers.ToArray();
		}

		public static int[] OneTwo(int[] numbers, int digit, int elementToInsert)
		{
			var list = new List<int>();
			list.AddRange(numbers);
			var addedIndex = 1;
			foreach (var number in numbers)
			{
				if (number.ToString().Substring(0, 1) == digit.ToString())
				{
					int index = Array.IndexOf(numbers, number);
					list.Insert(index + addedIndex++, elementToInsert);
				}
			}

			return list.ToArray();
		}

		public static int[] OneThree(int[] numbers)
		{
			return numbers.Distinct().ToArray();
		}

		public static int[] OneFour(int[] numbers, int elementToInsert)
		{
			var list = new List<int>();
			list.AddRange(numbers);
			var addedIndex = 1;

			for (int i = 0; i < numbers.Length - 1; i++)
			{
				if (numbers[i] > 0 && numbers[i + 1] < 0 || numbers[i] < 0 && numbers[i + 1] > 0)
				{
					int index = Array.IndexOf(numbers, numbers[i]);
					list.Insert(index + addedIndex++, elementToInsert);
				}
			}

			return list.ToArray();
		}

		public static int[] OneFive(int[] numbers)
		{
			return numbers.Where(e => e != 0).ToArray();

		}
	}
}
