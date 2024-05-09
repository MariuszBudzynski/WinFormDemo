using System.Text.Json;
using WinFormsDemoApp.Common.Interfaces;

namespace WinFormsDemoApp.Common
{
    public class APIHelper : IAPIHelper
	{
		private readonly HttpClient _client = new();

		public async Task<string> CallApiAsync(string endpoint, bool formatOutput = true, Httpaction action = Httpaction.GET)
		{
			HttpResponseMessage response = await _client.GetAsync(endpoint);

			if (response.IsSuccessStatusCode)
			{
				var json = await response.Content.ReadAsStringAsync();

				if (formatOutput)
				{
					var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
					var prettyJson = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
					return prettyJson;
				}
				else return json;
			}
			else
			{
				return $"Error: {response.StatusCode}";
			}
		}
	}
}
