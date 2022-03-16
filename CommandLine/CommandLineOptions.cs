using CommandLine;

using static LettersCounter.Enums.ArgumentsReader;

namespace LettersCounter.CommandLine
{
	public class CommandLineOptions
	{
		private string _filePath;
		private string _text;

		public Options? Option { get; private set; }

		[Option(shortName: 'f', longName: "file", Required = false, HelpText = "File to reading")]
		public string FilePath 
		{ 
			get => _filePath;
			set
			{
				Option = Options.File;
				_filePath = value;
			} 
		}

		[Value(0, Required = false, HelpText = "String to reading")]
		public string Text 
		{
			get => _text;
			set
			{
				Option = Options.String;
				_text = value;
			}
		}
	}
}
