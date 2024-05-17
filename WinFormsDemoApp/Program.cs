namespace WinFormsDemoApp
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			var serviceProvider = ServiceRegistration.ConfigureServices();
			
			ApplicationConfiguration.Initialize();
			var dashboard = serviceProvider.GetRequiredService<Dashboard>();
			Application.Run(dashboard);
		}
	}
}