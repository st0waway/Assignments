namespace Assignment_09
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var genericCollection = new GenericCollection<int>();
			genericCollection.Set(0, 20);
			genericCollection.Set(1, 30);
			genericCollection.Set(2, 40);
			Console.WriteLine(genericCollection.Get(0));
			Console.WriteLine(genericCollection.Get(1));
			Console.WriteLine(genericCollection.Get(2));
		}
	}
}