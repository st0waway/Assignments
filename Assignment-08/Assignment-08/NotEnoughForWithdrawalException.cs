namespace Assignment_08
{
	public class NotEnoughForWithdrawalException : Exception
	{
		public NotEnoughForWithdrawalException()
		{
		}

		public NotEnoughForWithdrawalException(string message) : base(message)
		{
		}

		public NotEnoughForWithdrawalException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}
