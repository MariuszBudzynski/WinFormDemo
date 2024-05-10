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
