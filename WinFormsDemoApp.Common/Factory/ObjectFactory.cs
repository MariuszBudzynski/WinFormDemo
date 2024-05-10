namespace WinFormsDemoApp.Common.Factory
{
    public class ObjectFactory : IObjectFactory
    {
        public IAPIValidator CreateValidator()
        {
            return new APIValidator();
        }

        public IAPIHelper CreateHelper()
        {
            return new APIHelper();
        }
    }
}
