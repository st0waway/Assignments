using System.Diagnostics;

namespace Assignment_08
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if RELEASE_COMP_SYMBOLS
			PrintText("asd");
			Greet("Victor");
			WithdrawMoney(50, 100);
			Divide("100", "2");
#endif

#if DEBUG_COMP_SYMBOLS
			//PrintText("");
			//Greet("");
			//WithdrawMoney(100, 50);
			//Divide("100", "0");
			//Divide("1000000000000000000000000000000000", "1");
#endif

			Debug.WriteLine("test");
			var text = "once upon a time..";
			var number = 2;
			var floatingPointNumber = 2.4;
			var isAlive = true;
			var letter = 'R';


		}

		public static void Greet(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException(nameof(name));
			}
			Console.WriteLine("Hello, " + name);
		}

		public static void PrintText(string text) 
		{
			ArgumentNullException.ThrowIfNullOrEmpty(text);

			Console.WriteLine(text);
		}

		public static void WithdrawMoney(int amountToWithdraw, int balance)
		{
			if (amountToWithdraw > balance)
			{
				throw new NotEnoughForWithdrawalException(
					$"You have {balance} on your balance and you wanted to withdraw {amountToWithdraw}");
			}
			else
			{
				Console.WriteLine($"new balance is {balance - amountToWithdraw} ");
			}
		}

		public static int Divide(string a, string b)
		{
			try
			{
				var numerator = Convert.ToInt32(a);
				var denominator = Convert.ToInt32(b);
				Console.WriteLine(numerator / denominator);
				return numerator / denominator;
			}
			catch (DivideByZeroException exception)
			{
				throw new DivideByZeroException("You cannot divide by zero", exception.InnerException);
			}

			catch (OverflowException exception)
			{
				throw new OverflowException("the number was too high", exception.InnerException);
			}
			finally
			{

			}

			
		}
	}
}