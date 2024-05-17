namespace WinFormsDemoApp.Common.Factory
{
    public class ObjectFactory : IObjectFactory
    {
		// "Since I have implemented DI, the Factory is no longer needed, but I will leave it as a reference."
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
