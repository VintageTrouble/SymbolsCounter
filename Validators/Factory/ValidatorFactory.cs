namespace LettersCounter.Validators.Factory
{
	public static class ValidatorFactory
	{
		public static IValidator GetFileValidator() => new FileValidator();
	}
}
