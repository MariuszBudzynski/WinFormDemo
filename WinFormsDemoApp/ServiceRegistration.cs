using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms.Design;
using WinFormsDemoApp.Common;

namespace WinFormsDemoApp
{
	public static class ServiceRegistration
	{
		public static IServiceProvider ConfigureServices()
		{
			var services = new ServiceCollection();

			// Register services here
			services.AddScoped<IAPIHelper,APIHelper>();
			services.AddScoped<IAPIValidator,APIValidator>();
			services.AddScoped<Dashboard>();


			// Add other services

			return services.BuildServiceProvider();
		}
	}
}
