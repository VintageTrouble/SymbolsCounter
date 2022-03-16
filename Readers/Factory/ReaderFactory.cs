using System;

using static LettersCounter.Enums.ArgumentsReader;

namespace LettersCounter.Readers.Factory
{
	public static class ReaderFactory
	{
		public static IReader GetReader(Options option) 
			=> option switch
			{
				Options.String => GetTextReader(),
				Options.File => GetFileReader(),
				_ => throw new InvalidOperationException("Selected option is incorrect"),
			};

		public static IReader GetFileReader() => new FileReader();
		public static IReader GetTextReader() => new TextReader();
	}
}
