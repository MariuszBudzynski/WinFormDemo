namespace WinFormsDemoApp
{
	public partial class Dashboard : Form
	{
		private readonly IAPIValidator _validator;
		private readonly IAPIHelper _helper;
		public Dashboard(IAPIHelper apiHelper, IAPIValidator apiValidator)
		{
			InitializeComponent();
			POST_PATCH.Text = POST_PATCH.Items[0].ToString();

			_validator = apiValidator;
			_helper = apiHelper;

		}


		private async void SendGetButton_Click(object sender, EventArgs e)
		{
			await CallApiInternalAsync(GETInputBox.Text,HttpAction.GET,true);
		}

		private async void SendPost_PatchButton_Click(object sender, EventArgs e)
		{
			HttpAction selectedOption = POST_PATCH.Text == "POST" ? HttpAction.POST : HttpAction.PATCH;

			await CallApiInternalAsync(POST_PATCHInputBox.Text, selectedOption, false, JSON_Input.Text);
		}

		private async void SendDeleteButton_Click(object sender, EventArgs e)
		{
			await CallApiInternalAsync(DELETEInputBox.Text, HttpAction.DELETE);
		}



		private async Task CallApiInternalAsync(string endpoint, HttpAction action, bool formatOutput = false, string body = null)
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
							 action == HttpAction.POST ? await _helper.CallApiAsync(POST_PATCHInputBox.Text, JSON_Input.Text, HttpAction.POST) :
							 action == HttpAction.PATCH ? await _helper.CallApiAsync(POST_PATCHInputBox.Text, JSON_Input.Text, HttpAction.PATCH) :
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