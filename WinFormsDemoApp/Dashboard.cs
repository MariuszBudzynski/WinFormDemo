using WinFormsDemoApp.Common;
using WinFormsDemoApp.Common.Interfaces;

namespace WinFormsDemoApp
{
    public partial class Dashboard : Form
	{
		private readonly IAPIValidator _validator = new APIValidator();
		private readonly IAPIHelper _helper = new APIHelper();
		public Dashboard()
		{
			InitializeComponent();
		
		}

		private async void SendGetButton_Click(object sender, EventArgs e)
		{

			if (!_validator.ValidateEndpoint(GETInputBox.Text))
			{
				SystemStatus.Text = "Error";
				DisplaytextBox.Text = "Enter proper Endpoint";
				return;
			}

			try
			{
				SystemStatus.Text = "Calling API...";

				var result = await _helper.CallApiAsync(GETInputBox.Text);
				DisplaytextBox.Text = result;

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
