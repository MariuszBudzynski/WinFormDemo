using WinFormsDemoApp.Common.Interfaces;

namespace WinFormsDemoApp.Common
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
