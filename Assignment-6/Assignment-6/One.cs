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
			var uniqueNumbers = new List<int>();
			foreach (var number in numbers)
			{
				if (uniqueNumbers.Contains(number) == false)
				{
					uniqueNumbers.Add(number);
				}
			}

			return uniqueNumbers.ToArray();
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
			int[] sortedNumbers = new int[numbers.Length];

			var zeroCounter = 0;
			var i = 0;
			
			foreach (var number in numbers)
			{
				if (number != 0)
				{
					sortedNumbers[i++] = number;
				}
				else
				{
					zeroCounter++;
				}
			}

			var finalNumbers = new int[numbers.Length - zeroCounter];
			for (int j = 0; j < numbers.Length - zeroCounter; j++)
			{
				finalNumbers[j] = sortedNumbers[j];
			}
			
			return finalNumbers;
		}
	}
}
