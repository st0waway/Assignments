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
			var newList = new List<int>();


			var output = newList.ToArray();
			return output;
		}

		public static int[] OneThree(int[] numbers)
		{
			return numbers.Distinct().ToArray();

		}

		public static int[] OneFive(int[] numbers)
		{
			return numbers.Where(e => e != 0).ToArray();

		}
	}
}
