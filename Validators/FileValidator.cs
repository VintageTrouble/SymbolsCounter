using System.IO;

namespace LettersCounter.Validators
{
	public class FileValidator : IValidator
	{
		public bool Validate(object data)
		{
			var path = data.ToString();

			return File.Exists(path);
		}
	}
}
