using System.Text.RegularExpressions;

namespace WinFormsDemoApp.Common
{
	public class APIValidator
	{
		public bool ValidateEndpoint(string endpoint)
		{
			string urlPattern = @"^(http(s)?://)?([\w-]+.)+[\w-]+(/[\w- ;,./?%&=]*)?$";

			return Regex.IsMatch(endpoint, urlPattern, RegexOptions.IgnoreCase);
		}
	}
}
