using System;
using System.Collections.Generic;
using System.Linq;

using CommandLine;

using LettersCounter.Analyzer;
using LettersCounter.CommandLine;
using LettersCounter.Comparers;
using LettersCounter.Readers.Factory;

namespace LettersCounter
{
	class Program
	{
		static int Main(string[] args) 
			=> Parser.Default.ParseArguments<CommandLineOptions>(args)
				.MapResult(
					(CommandLineOptions opts) =>
					{
						try
						{
							return AnalyzeData(opts);
						}
						catch
						{
							return Error("Unhandled error!", -3);
						}
					},
					errs => Error("Invalid arguments!", -1));

		private static int AnalyzeData(CommandLineOptions options)
		{
			if(!options.Option.HasValue)
				return Error("Invalid arguments!", -1);

			var reader = ReaderFactory.GetReader(options.Option.Value);
			var text = reader.Read(options);

			try
			{
				var data = TextAnalyzer.Analyze(text)
					.OrderBy(key => key, new DictionaryComparer())
					.ToDictionary(
						k => k.Key, 
						v => v.Value);

				DrawResult(data);
			}
			catch (Exception ex)
			{
				Error(ex.Message);
			}

			return 0;
		}

		private static void DrawResult(Dictionary<string, int> data)
		{
			Console.WriteLine("---------");

			foreach (var pair in data)
			{
				Console.Write($"\"{pair.Key}\":\t");

				if (pair.Key.Length < 5)
					Console.Write("\t");

				Console.Write($"{pair.Value}\n");
			}

			Console.WriteLine("---------");
		}

		private static int Error(string message, int exitCode = -2)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ResetColor();
			return exitCode;
		}
	}
}
