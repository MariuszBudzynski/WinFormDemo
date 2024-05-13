namespace WinFormsDemoApp
{
	partial class Dashboard
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			// do something
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DisplaytextBox = new TextBox();
			ReguestTypesLabel = new Label();
			GetLabel = new Label();
			GETInputBox = new TextBox();
			SendGetButton = new Button();
			statusStrip = new StatusStrip();
			SystemStatus = new ToolStripStatusLabel();
			ResponseLabel = new Label();
			POSTInputBox = new TextBox();
			PostLabel = new Label();
			SendPostButton = new Button();
			JSON_BodyLabel = new Label();
			JSON_Input = new TextBox();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// DisplaytextBox
			// 
			DisplaytextBox.BackColor = Color.White;
			DisplaytextBox.BorderStyle = BorderStyle.FixedSingle;
			DisplaytextBox.ForeColor = Color.Black;
			DisplaytextBox.Location = new Point(12, 271);
			DisplaytextBox.Multiline = true;
			DisplaytextBox.Name = "DisplaytextBox";
			DisplaytextBox.ReadOnly = true;
			DisplaytextBox.ScrollBars = ScrollBars.Both;
			DisplaytextBox.Size = new Size(801, 136);
			DisplaytextBox.TabIndex = 0;
			// 
			// ReguestTypesLabel
			// 
			ReguestTypesLabel.AutoSize = true;
			ReguestTypesLabel.Location = new Point(25, 7);
			ReguestTypesLabel.Name = "ReguestTypesLabel";
			ReguestTypesLabel.Size = new Size(130, 25);
			ReguestTypesLabel.TabIndex = 1;
			ReguestTypesLabel.Text = "Reguest Types";
			// 
			// GetLabel
			// 
			GetLabel.AutoSize = true;
			GetLabel.Location = new Point(25, 45);
			GetLabel.Name = "GetLabel";
			GetLabel.Size = new Size(41, 25);
			GetLabel.TabIndex = 2;
			GetLabel.Text = "Get";
			// 
			// GETInputBox
			// 
			GETInputBox.Location = new Point(92, 42);
			GETInputBox.Name = "GETInputBox";
			GETInputBox.PlaceholderText = "Enter Endpoint";
			GETInputBox.Size = new Size(585, 33);
			GETInputBox.TabIndex = 3;
			// 
			// SendGetButton
			// 
			SendGetButton.Location = new Point(716, 42);
			SendGetButton.Name = "SendGetButton";
			SendGetButton.Size = new Size(97, 36);
			SendGetButton.TabIndex = 4;
			SendGetButton.Text = "Send";
			SendGetButton.UseVisualStyleBackColor = true;
			SendGetButton.Click += SendGetButton_Click;
			// 
			// statusStrip
			// 
			statusStrip.Items.AddRange(new ToolStripItem[] { SystemStatus });
			statusStrip.Location = new Point(0, 517);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(856, 22);
			statusStrip.TabIndex = 5;
			statusStrip.Text = "statusStrip1";
			// 
			// SystemStatus
			// 
			SystemStatus.Name = "SystemStatus";
			SystemStatus.Size = new Size(39, 17);
			SystemStatus.Text = "Ready";
			// 
			// ResponseLabel
			// 
			ResponseLabel.AutoSize = true;
			ResponseLabel.Location = new Point(12, 234);
			ResponseLabel.Name = "ResponseLabel";
			ResponseLabel.Size = new Size(91, 25);
			ResponseLabel.TabIndex = 6;
			ResponseLabel.Text = "Response";
			// 
			// POSTInputBox
			// 
			POSTInputBox.Location = new Point(92, 93);
			POSTInputBox.Name = "POSTInputBox";
			POSTInputBox.PlaceholderText = "Enter Endpoint";
			POSTInputBox.Size = new Size(585, 33);
			POSTInputBox.TabIndex = 8;
			// 
			// PostLabel
			// 
			PostLabel.AutoSize = true;
			PostLabel.Location = new Point(25, 96);
			PostLabel.Name = "PostLabel";
			PostLabel.Size = new Size(57, 25);
			PostLabel.TabIndex = 7;
			PostLabel.Text = "POST";
			// 
			// SendPostButton
			// 
			SendPostButton.Location = new Point(716, 93);
			SendPostButton.Name = "SendPostButton";
			SendPostButton.Size = new Size(97, 34);
			SendPostButton.TabIndex = 9;
			SendPostButton.Text = "Send";
			SendPostButton.UseVisualStyleBackColor = true;
			SendPostButton.Click += SendPostButton_Click;
			// 
			// JSON_BodyLabel
			// 
			JSON_BodyLabel.AutoSize = true;
			JSON_BodyLabel.Location = new Point(12, 149);
			JSON_BodyLabel.Name = "JSON_BodyLabel";
			JSON_BodyLabel.Size = new Size(104, 25);
			JSON_BodyLabel.TabIndex = 10;
			JSON_BodyLabel.Text = "JSON Body";
			// 
			// JSON_Input
			// 
			JSON_Input.Location = new Point(122, 149);
			JSON_Input.Multiline = true;
			JSON_Input.Name = "JSON_Input";
			JSON_Input.ScrollBars = ScrollBars.Both;
			JSON_Input.Size = new Size(683, 82);
			JSON_Input.TabIndex = 11;
			JSON_Input.Text = "{\"name\":value}";
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(856, 539);
			Controls.Add(JSON_Input);
			Controls.Add(JSON_BodyLabel);
			Controls.Add(SendPostButton);
			Controls.Add(POSTInputBox);
			Controls.Add(PostLabel);
			Controls.Add(ResponseLabel);
			Controls.Add(statusStrip);
			Controls.Add(SendGetButton);
			Controls.Add(GETInputBox);
			Controls.Add(GetLabel);
			Controls.Add(ReguestTypesLabel);
			Controls.Add(DisplaytextBox);
			Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			Margin = new Padding(5);
			Name = "Dashboard";
			Text = "DemoApp";
			Load += Dashboard_Load;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox DisplaytextBox;
		private Label ReguestTypesLabel;
		private Label GetLabel;
		private TextBox GETInputBox;
		private Button SendGetButton;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel SystemStatus;
		private Label ResponseLabel;
		private TextBox POSTInputBox;
		private Label PostLabel;
		private Button SendPostButton;
		private Label JSON_BodyLabel;
		private TextBox JSON_Input;
	}
}
