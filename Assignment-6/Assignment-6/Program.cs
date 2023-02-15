﻿using System.Collections.Generic;
using System.ComponentModel;

namespace Assignment_6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//1.	In one-dimensional array of integers perform the following operations: 
			//1.	+Delete all even numbers. 
			var OddNumbers = One.OneOne(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
			foreach (var oddNumber in OddNumbers)
			{
				//Console.WriteLine(oddNumber);
			}

			//2.  + Insert new element after all elements beginning with the indicated digit. 
			var newArray = One.OneTwo(new int[] { 10, 20, 30, 34, 37, 45 }, 3, 1);

			//3.	+Delete from array all repeating elements except of their first occurrence. 
			var distinctNumbers = One.OneThree(new int[] { 1, 1, 2, 3, 4, 4, 5, 5, 5, 5, 5, 5, 3, 2, 1, 4, 8 });
			foreach (var distinctNumber in distinctNumbers)
			{
				//Console.WriteLine(distinctNumber);
			}

			//5.	+Compress array by deleting all zero-value elements. 
			var noZeroNumbers = One.OneFive(new int[] { 1, 1, 2, 3, 4, 4, 5, 5, 5, 0, 0, 5, 5, 5, 3, 2, 1, 4, 8, 0, 0, 0 });
			foreach (var noZeroNumber in noZeroNumbers)
			{
				//Console.WriteLine(noZeroNumber);
			}


			
			//3.Write an application that provides the following operations with strings:

			//1.	insert  character <x> after every occurrence of character <y>; 
			var insertedString = Three.ThreeOne("aaaaaaaaaaaaaaaabbbcccc", 'b', 'a');
			//Console.WriteLine(insertedString);

			//2.	mix up the first character with the second one, the third character with the fourth one etc. 
			var mixedCharacters = Three.ThreeTwo("abcdefghijklmnopqrstuvwxyz");
			//Console.WriteLine(mixedCharacters);

			//3.find, which of two indicated characters is occurred in the string more often;
			var moreOften = Three.ThreeThree("aaaaaaaaaaaaaaaabbbcccc", 'a', 'b');
			//Console.WriteLine($"{moreOften} occurs more often");

			//4.count full number of occurrences of<x> and<y> characters;
			var occurencies = Three.ThreeFour("aaaaaaaaaaaaaaaabbbcccc", 'a', 'b');
			foreach (var occurency in occurencies)
			{
				//Console.WriteLine(occurency);
			}

			//5.  + count number of different characters in the string;
			var numberOfDifferentCharacters = Three.ThreeFive("aaaaaaaaaaaaaaaabbbccccd");
			//Console.WriteLine(numberOfDifferentCharacters);

			//6.find out if the string has two adjacent identical characters;
			var hasTwoAdjacent = Three.ThreeSix("asdfghjklasdfghjkl;11");
			//Console.WriteLine(hasTwoAdjacent);

			//7.	delete the middle character if string length is odd or two middle characters if string length is even
			var noMiddle = Three.ThreeSeven("qwertyuiop[");
			//Console.WriteLine(noMiddle);

			//8.	double every occurrence of the indicated character <x>; 
			var doubledOccurence = Three.ThreeEight("asdfgasdfgasdfg", 'a');
			//Console.WriteLine(doubledOccurence);

			//9.delete all occurrences of the character<x>;
			var stringWithRemovedCharacter = Three.ThreeNine("aaaaaaaaaaaaaaaaaaaaaaaaaaawoobnmdsabdnmsd", 'a');
			//Console.WriteLine(stringWithRemovedCharacter);

			//10.	delete all occurrences of the substring <substr>; 
			var stringWithReplacedSubstring = Three.ThreeTen("aaaaaaaaaaaaaaaaaaaaaaaaaaawoobnmdsabdnmsd", "awoo");
			//Console.WriteLine(stringWithReplacedSubstring);

			//11. + replace all occurrences of the substring<substr1> on the substring<substr2>;
			var replacedText = Three.ThreeEleven("awooawooawoo", "awoo", "no");
			//Console.WriteLine(replacedText);

			//12.count the sum of all numbers occurred in the string;
			var numbersSum = Three.ThreeTwelve("10 20 30 54 4");
			//Console.WriteLine(numbersSum);

			//13.	count the sum of all digits occurred in the string; 
			var digitsSum = Three.ThreeThirteen("123456798");
			//Console.WriteLine(digitsSum);

			//14.find indexes of the first and the last occurrences of the character<x>;
			var indexes = Three.ThreeFourteen("asdasdasdasdasda", 'a');
			foreach (var index in indexes)
			{
				//Console.WriteLine(index);
			}

			//15.replace all groups of adjacent dots with ellipsis;
			var textWithEllipsis = Three.ThreeFifteen("and...this...is...how...it...went...");
			//Console.WriteLine(textWithEllipsis);

			//16.	display all characters before the first colon occurrence in the string; 
			var textBeforeColon = Three.ThreeSixteen("aaaaaaaaaaaaaaaaaaaaaaaaaaq:wbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb");
			//Console.WriteLine(textBeforeColon);

			//17.	display all characters after the first colon occurrence in the string; 
			var textAfterColon = Three.ThreeSeventeen("aaaaaaaaaaaaaaaaaaaaaaaaaaq:wbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb");
			//Console.WriteLine(textAfterColon);

			//18.delete all characters inside the parenthesize.
			var deleteInsideParanthesize = Three.ThreeEighteen("aaaaaaaaaaaaaaaaa(12345)aaaaaaaaaaaaaaa");
			//Console.WriteLine(deleteInsideParanthesize);

			//19.delete all characters inside the curly braces;
			var deleteInsideCurlyBraces = Three.ThreeNineteen("aaaaaaaaaaaaaaaaaaaaaf{qwerty}gbbbbbbbbbbbbbbb");
			//Console.WriteLine(deleteInsideCurlyBraces);

			//20.	count and display statistics of character occurrences in the string.
			var lettersCount = Three.ThreeTwenty("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabb");
			//Console.WriteLine(lettersCount);
		}
	}
}