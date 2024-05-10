namespace WinFormsDemoApp.Common
{
	public class APIValidator : IAPIValidator
	{
		public bool ValidateEndpoint(string endpoint)
		{
			string urlPattern = @"^(http(s)?://)?([\w-]+.)+[\w-]+(/[\w- ;,./?%&=]*)?$";

			return Regex.IsMatch(endpoint, urlPattern, RegexOptions.IgnoreCase);
		}
	}
}
