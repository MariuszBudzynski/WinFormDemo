namespace WinFormsDemoApp.Common.Interfaces
{
    public interface IAPIHelper
    {
        Task<string> CallApiAsync(string endpoint, bool formatOutput = true, Httpaction action = Httpaction.GET);
    }
}