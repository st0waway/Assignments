using System.Threading.Channels;

namespace Assignment_07
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var angleOne = new Angle(3, 36, 53);
			var angleTwo = new Angle(4, 27, 45);

			var angleThree = angleOne + angleTwo;
			var angleFour = angleTwo - angleOne;
			var angleFive = angleOne - angleOne;
			Console.WriteLine($"{angleThree.Degree}, {angleThree.Minutes}, {angleThree.Seconds}");
			Console.WriteLine($"{angleFour.Degree}, {angleFour.Minutes}, {angleFour.Seconds}");
			Console.WriteLine($"{angleFive.Degree}, {angleFive.Minutes}, {angleFive.Seconds}");
		}
	}
}