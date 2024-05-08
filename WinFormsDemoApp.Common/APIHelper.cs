namespace WinFormsDemoApp.Common
{
	public class APIHelper
	{
		private HttpClient _client;
		public APIHelper() 
		{
			_client = new HttpClient();
		}

		public async Task<string> SendRequestAsync(string endpoint)
		{
			HttpResponseMessage response = await _client.GetAsync(endpoint);
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}
	}
}
