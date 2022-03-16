using LettersCounter.CommandLine;

namespace LettersCounter.Readers
{
	public interface IReader
	{
		string Read(CommandLineOptions options);
	}
}
