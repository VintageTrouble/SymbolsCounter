using LettersCounter.Extensions;

using System.Collections.Generic;

namespace LettersCounter.Analyzer
{
	public static class TextAnalyzer
	{
		public static Dictionary<string, int> Analyze(string text)
		{
			var result = new Dictionary<string, int>();

			foreach(var symbol in text)
			{
				var key = symbol.ToString().ToKey();

				if (!result.ContainsKey(key))
					result.Add(key, 0);

				result[key]++;
			}

			return result;
		}
	}
}