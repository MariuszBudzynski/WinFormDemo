namespace WinFormsDemoApp.Common.Interfaces
{
    public interface IAPIHelper
    {
        Task<string> CallApiAsync(string endpoint, bool formatOutput = true, HttpAction action = HttpAction.GET);
		Task<string> CallApiAsync(string endpoint, string body, HttpAction action = HttpAction.POST);
		Task<string> CallApiAsync(string endpoint, HttpAction action = HttpAction.DELETE);
	}
}