using System.Collections.Generic;

namespace LettersCounter.Comparers
{
	public class DictionaryComparer : IComparer<KeyValuePair<string, int>>
	{
		private readonly List<string> _orderedLetters = new () 
		{ 
			"Enter", "Tab",  "Space", "Return",	//Invisible symbols
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
			"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
			"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
		};

		public int Compare(KeyValuePair<string, int> str1, KeyValuePair<string, int> str2) 
			=> _orderedLetters.IndexOf(str1.Key) - _orderedLetters.IndexOf(str2.Key);
	}
}
