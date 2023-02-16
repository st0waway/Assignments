using System.Collections.Generic;
using System.ComponentModel;

using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

using Console = System.Console;

namespace Assignment_6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var OddNumbers = One.OneOne(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
			foreach (var oddNumber in OddNumbers)
			{
				//Console.WriteLine(oddNumber);
			}

			var newArray = One.OneTwo(new int[] { 10, 20, 30, 34, 37, 45 }, 3, 1);

			var distinctNumbers = One.OneThree(new int[] { 1, 1, 2, 3, 4, 4, 5, 5, 5, 5, 5, 5, 3, 2, 1, 4, 8 });
			foreach (var distinctNumber in distinctNumbers)
			{
				//Console.WriteLine(distinctNumber);
			}

			var noZeroNumbers = One.OneFive(new int[] { 1, 1, 2, 3, 4, 4, 5, 5, 5, 0, 0, 5, 5, 5, 3, 2, 1, 4, 8, 0, 0, 0 });
			foreach (var noZeroNumber in noZeroNumbers)
			{
				//Console.WriteLine(noZeroNumber);
			}



			var resultThreeOne = Three.ThreeOne("aaaaaaaaaaaaaaaabbbcccc", 'b', 'a');
			//Console.WriteLine(resultThreeOne);

			var resultThreeTwo = Three.ThreeTwo("abcdefghijklmnopqrstuvwxyz");
			//Console.WriteLine(resultThreeTwo);

			var resultThreeThree = Three.ThreeThree("aaaaaaaaaaaaaaaabbbccccccccccccccccccccccccccccccccccccc", 'a', 'c');
			//Console.WriteLine(resultThreeThree);

			var resultThreeFour = Three.ThreeFour("aaaaaaaaaaaaaaaabbbcccc", 'a', 'c');
			//Console.WriteLine(resultThreeFour);

			var resultThreeFive = Three.ThreeFive("aaaaaaaaaaaaaaaabbbccccd");
			//Console.WriteLine(resultThreeFive);

			var resultThreeSix = Three.ThreeSix("asdfghjklasdfghjkl;11");
			//Console.WriteLine(resultThreeSix);

			var resultThreeSeven = Three.ThreeSeven("aaaabbcccc");
			//Console.WriteLine(resultThreeSeven);

			var resultThreeEight = Three.ThreeEight("abababababa", 'a');
			//Console.WriteLine(resultThreeEight);

			var resultThreeNine = Three.ThreeNine("aaaaaaaaaaaaaaaaaaaaaaaaaaawoobnmdsabdnmsd", 'a');
			//Console.WriteLine(resultThreeNine);

			var resultThreeTen = Three.ThreeTen("aaaaaaaaaaaaaaaaaaaaaaaaaaawoobnmdsabdnmsd", "awoo");
			//Console.WriteLine(resultThreeTen);

			var resultThreeEleven = Three.ThreeEleven("awooawooawoo", "awoo", "no");
			//Console.WriteLine(resultThreeEleven);

			var resultThreeTwelve = Three.ThreeTwelve("10 20 30 54 4");
			//Console.WriteLine(resultThreeTwelve);

			var reusltThreeThirteen = Three.ThreeThirteen("123456798");
			//Console.WriteLine(reusltThreeThirteen);

			var resultThreeFourteen = Three.ThreeFourteen("asdasdasdasdasda", 'a');
			//Console.WriteLine(resultThreeFourteen);

			var resultThreeFifteen = Three.ThreeFifteen("and...this...is...how...it...went...");
			//Console.WriteLine(resultThreeFifteen);

			var resultThreeSixteen = Three.ThreeSixteen("aaaaaaaaaaaaaaaaaaaaaaaaaaq:wbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb");
			//Console.WriteLine(resultThreeSixteen);

			var resultThreeSeventeen = Three.ThreeSeventeen("aaaaaaaaaaaaaaaaaaaaaaaaaaq:wbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb");
			//Console.WriteLine(resultThreeSeventeen);

			var resultThreeEighteen = Three.ThreeEighteen("aaaaaaaaaaaaaaaaa(12345)aaaaaaaaaaaaaaa");
			//Console.WriteLine(resultThreeEighteen);

			var resultThreeNineteen = Three.ThreeNineteen("aaaaaaaaaaaaaaaaaaaaaf{qwerty}gbbbbbbbbbbbbbbb");
			//Console.WriteLine(resultThreeNineteen);

			var resultThreeTwenty = Three.ThreeTwenty("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabb");
			//Console.WriteLine(resultThreeTwenty);


			var resultFourOne = Four.FourOne("this is a test please pay the lease", "eas");
			//Console.WriteLine(resultFourOne + "!");

			var resultFourTwo = Four.FourTwo("this is a test please pay the lease", 4);
			//Console.WriteLine(resultFourTwo);

			var resultFourThree = Four.FourThree("This is a Test please Be Polite");
			//Console.WriteLine(resultFourThree);

			var resultFourFour = Four.FourFour("asdf1 asdf2 sadf aggdf dsffsa reewer3 dsadsa2");
			//Console.WriteLine(resultFourFour);

			var resultFourFive = Four.FourFive("asdfx asdf gffgdg fdsadsad terwerzx dsadasx", 'x');
			//Console.WriteLine(resultFourFive);

			var resultFourSix = Four.FourSix("awoo bazooka hello no", 'a');
			//Console.WriteLine(resultFourSix);

			var resultFourSeven = Four.FourSeven("a b c das vcd dsadf f e w q dsa");
			//Console.WriteLine(resultFourSeven);

			var resultFourEight = Four.FourEight(" bad bad dsd dsd hello yes");
			//Console.WriteLine(resultFourEight);

			var resultFourNine = Four.FourNine("asd asd sad das asd", "asd");
			//Console.WriteLine(resultFourNine);

			var resultFourTen = Four.FourTen("Asd asd rfd tffd ASD");
			//Console.WriteLine(resultFourTen);

			var resultFourEleven = Four.FourEleven("the longest word is it probably is dinosaur but that's impossible and yet it can be");
			//Console.WriteLine(resultFourEleven);

			var resultFourTwelve = Four.FourTwelve("asdfghj asdf asdfgh asdfgh qwertyuiop");
			//Console.WriteLine(resultFourTwelve);

			var resultFourThirteen = Four.FourThirteen("qwe asdfg qw fgfd dsdsas a df g");
			//Console.WriteLine(resultFourThirteen);

			var resultFourFourteen = Four.FourFourteen("asd as sd fd gf df asd we qwe asdf");
			//Console.WriteLine(resultFourFourteen);

			var resultFourFifteen = Four.FourFifteen("asdsa asdfgdsas asdfghjhgfdsa asdfcvx");
			Console.WriteLine(resultFourFifteen);

		}
	}
}