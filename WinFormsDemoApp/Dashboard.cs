using WinFormsDemoApp.Common;

namespace WinFormsDemoApp
{
	public partial class Dashboard : Form
	{
		private readonly IAPIValidator _validator;
		private readonly IAPIHelper _helper;
		public Dashboard()
		{
			InitializeComponent();
			IObjectFactory factory = new ObjectFactory();

			_validator = factory.CreateValidator();
			_helper = factory.CreateHelper();

		}


		private async void SendGetButton_Click(object sender, EventArgs e)
		{
			await CallApiAsync(GETInputBox.Text,HttpAction.GET,true);
		}

		private async void SendPostButton_Click(object sender, EventArgs e)
		{
			await CallApiAsync(POSTInputBox.Text,HttpAction.POST,false, JSON_Input.Text);
		}

		private async void SendDeleteButton_Click(object sender, EventArgs e)
		{
			await CallApiAsync(DELETEInputBox.Text, HttpAction.DELETE);
		}



		private async Task CallApiAsync(string endpoint, HttpAction action, bool formatOutput = false, string body = null)
		{
			if (!_validator.ValidateEndpoint(endpoint))
			{
				SystemStatus.Text = "Error";
				DisplaytextBox.Text = "Enter proper Endpoint";
				return;
			}

			try
			{
				SystemStatus.Text = "Calling API...";

				var result = action == HttpAction.GET ? await _helper.CallApiAsync(GETInputBox.Text, true, HttpAction.GET) :
							 action == HttpAction.POST ? await _helper.CallApiAsync(POSTInputBox.Text, JSON_Input.Text, HttpAction.POST) :
							 action == HttpAction.DELETE ? await _helper.CallApiAsync(DELETEInputBox.Text, HttpAction.DELETE) : null;


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