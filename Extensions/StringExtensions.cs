namespace LettersCounter.Extensions
{
	public static class StringExtensions
	{
		public static string ToKey(this string value)
		{
			return value
				.Replace(" ", "Space")
				.Replace("\t", "Tab")
				.Replace("\n", "Enter")
				.Replace("\r", "Return");
		}
	}
}
