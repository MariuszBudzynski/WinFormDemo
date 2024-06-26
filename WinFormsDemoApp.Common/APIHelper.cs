﻿namespace WinFormsDemoApp.Common
{
    public class APIHelper : IAPIHelper
	{
		private readonly HttpClient _client = new();

		public async Task<string> CallApiAsync(string endpoint, bool formatOutput = true, HttpAction action = HttpAction.GET)
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

		public async Task<string> CallApiAsync(string endpoint,string body, HttpAction action)
		{
			HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
			HttpResponseMessage response = action == HttpAction.POST ? await _client.PostAsync(endpoint, content)
										: await _client.PatchAsync(endpoint, content);
			if (response.IsSuccessStatusCode)
			{
				return response.StatusCode.ToString();
			}
			else return "An Error Occured";
			
		}

		public async Task<string> CallApiAsync(string endpoint, HttpAction action = HttpAction.DELETE)
		{
			HttpResponseMessage response = await _client.DeleteAsync(endpoint);

			if (response.IsSuccessStatusCode)
			{
				return response.StatusCode.ToString();
			}
			else return "An Error Occured";

		}

	}
}
