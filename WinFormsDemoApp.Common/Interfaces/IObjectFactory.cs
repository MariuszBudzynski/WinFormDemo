namespace WinFormsDemoApp.Common.Interfaces
{
    public interface IObjectFactory
    {
        IAPIHelper CreateHelper();
        IAPIValidator CreateValidator();
    }
}