using LettersCounter.CommandLine;
using LettersCounter.Validators.Factory;

using System;
using System.IO;

namespace LettersCounter.Readers
{
	public class FileReader : IReader
	{
		public string Read(CommandLineOptions options)
		{
			var path = options.FilePath;
			var validator = ValidatorFactory.GetFileValidator();

			return validator.Validate(path) 
				? File.ReadAllText(path) 
				: throw new InvalidOperationException("File not founded");
		}
	}
}
