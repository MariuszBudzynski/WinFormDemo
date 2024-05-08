namespace WinFormsDemoApp
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		private async void SendGetButton_Click(object sender, EventArgs e)
		{

			try
			{
				SystemStatus.Text = "Calling API...";

				//Testing - replace with API call when ready
				await Task.Delay(2000);

				SystemStatus.Text = "Ready";
			}
			catch (Exception ex)
			{
				DisplaytextBox.Text = "Error: " + ex.Message;
				SystemStatus.Text = "Error";
			}
		}
	}
}
