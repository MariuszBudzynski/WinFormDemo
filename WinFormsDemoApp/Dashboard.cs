using WinFormsDemoApp.Common;

namespace WinFormsDemoApp
{
	public partial class Dashboard : Form
	{
		private APIValidator _validator;
		private APIHelper _helper;
		public Dashboard()
		{
			InitializeComponent();
		
		}

		private async void SendGetButton_Click(object sender, EventArgs e)
		{
			_validator = new APIValidator();

			if (!_validator.ValidateEndpoint(GETInputBox.Text))
			{
				SystemStatus.Text = "Error";
				DisplaytextBox.Text = "Enter proper Endpoint";
				return;
			}

			try
			{
				SystemStatus.Text = "Calling API...";

				_helper = new APIHelper();

				var result = await _helper.SendRequestAsync(GETInputBox.Text);
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
