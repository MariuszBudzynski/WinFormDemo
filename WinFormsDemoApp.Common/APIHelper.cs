using System.Text;

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

		public async Task<string> CallApiAsync(string endpoint,string body, bool formatOutput = true, Httpaction action = Httpaction.POST)
		{
			HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
			HttpResponseMessage response = await _client.PostAsync(endpoint, content);
			if (response.IsSuccessStatusCode)
			{
				return response.StatusCode.ToString();
			}
			else return "An Error Occured";
			
		}

	}
}
