using LettersCounter.CommandLine;

namespace LettersCounter.Readers
{
	public class TextReader : IReader
	{
		public string Read(CommandLineOptions options) => options.Text;
	}
}
