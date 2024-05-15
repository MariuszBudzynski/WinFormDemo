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
			POST_PATCHInputBox = new TextBox();
			SendPost_PatchButton = new Button();
			JSON_BodyLabel = new Label();
			JSON_Input = new TextBox();
			SendDeleteButton = new Button();
			DELETEInputBox = new TextBox();
			DeleteLabel = new Label();
			POST_PATCH = new ComboBox();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// DisplaytextBox
			// 
			DisplaytextBox.BackColor = Color.White;
			DisplaytextBox.BorderStyle = BorderStyle.FixedSingle;
			DisplaytextBox.ForeColor = Color.Black;
			DisplaytextBox.Location = new Point(25, 363);
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
			GETInputBox.Location = new Point(111, 42);
			GETInputBox.Name = "GETInputBox";
			GETInputBox.PlaceholderText = "Enter Endpoint";
			GETInputBox.Size = new Size(566, 33);
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
			ResponseLabel.Location = new Point(25, 326);
			ResponseLabel.Name = "ResponseLabel";
			ResponseLabel.Size = new Size(91, 25);
			ResponseLabel.TabIndex = 6;
			ResponseLabel.Text = "Response";
			// 
			// POST_PATCHInputBox
			// 
			POST_PATCHInputBox.Location = new Point(111, 93);
			POST_PATCHInputBox.Name = "POST_PATCHInputBox";
			POST_PATCHInputBox.PlaceholderText = "Enter Endpoint";
			POST_PATCHInputBox.Size = new Size(566, 33);
			POST_PATCHInputBox.TabIndex = 8;
			// 
			// SendPost_PatchButton
			// 
			SendPost_PatchButton.Location = new Point(716, 93);
			SendPost_PatchButton.Name = "SendPost_PatchButton";
			SendPost_PatchButton.Size = new Size(97, 34);
			SendPost_PatchButton.TabIndex = 9;
			SendPost_PatchButton.Text = "Send";
			SendPost_PatchButton.UseVisualStyleBackColor = true;
			SendPost_PatchButton.Click += SendPost_PatchButton_Click;
			// 
			// JSON_BodyLabel
			// 
			JSON_BodyLabel.AutoSize = true;
			JSON_BodyLabel.Location = new Point(25, 241);
			JSON_BodyLabel.Name = "JSON_BodyLabel";
			JSON_BodyLabel.Size = new Size(104, 25);
			JSON_BodyLabel.TabIndex = 10;
			JSON_BodyLabel.Text = "JSON Body";
			// 
			// JSON_Input
			// 
			JSON_Input.Location = new Point(135, 241);
			JSON_Input.Multiline = true;
			JSON_Input.Name = "JSON_Input";
			JSON_Input.ScrollBars = ScrollBars.Both;
			JSON_Input.Size = new Size(683, 82);
			JSON_Input.TabIndex = 11;
			JSON_Input.Text = "{\"name\":value}";
			// 
			// SendDeleteButton
			// 
			SendDeleteButton.Location = new Point(716, 153);
			SendDeleteButton.Name = "SendDeleteButton";
			SendDeleteButton.Size = new Size(97, 34);
			SendDeleteButton.TabIndex = 14;
			SendDeleteButton.Text = "Send";
			SendDeleteButton.UseVisualStyleBackColor = true;
			SendDeleteButton.Click += SendDeleteButton_Click;
			// 
			// DELETEInputBox
			// 
			DELETEInputBox.Location = new Point(111, 153);
			DELETEInputBox.Name = "DELETEInputBox";
			DELETEInputBox.PlaceholderText = "Enter Endpoint";
			DELETEInputBox.Size = new Size(566, 33);
			DELETEInputBox.TabIndex = 13;
			// 
			// DeleteLabel
			// 
			DeleteLabel.AutoSize = true;
			DeleteLabel.Location = new Point(25, 156);
			DeleteLabel.Name = "DeleteLabel";
			DeleteLabel.Size = new Size(74, 25);
			DeleteLabel.TabIndex = 12;
			DeleteLabel.Text = "DELETE";
			// 
			// POST_PATCH
			// 
			POST_PATCH.DropDownStyle = ComboBoxStyle.DropDownList;
			POST_PATCH.FormattingEnabled = true;
			POST_PATCH.Items.AddRange(new object[] { "POST", "PATCH" });
			POST_PATCH.Location = new Point(25, 93);
			POST_PATCH.Name = "POST_PATCH";
			POST_PATCH.Size = new Size(74, 33);
			POST_PATCH.TabIndex = 15;
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(856, 539);
			Controls.Add(POST_PATCH);
			Controls.Add(SendDeleteButton);
			Controls.Add(DELETEInputBox);
			Controls.Add(DeleteLabel);
			Controls.Add(JSON_Input);
			Controls.Add(JSON_BodyLabel);
			Controls.Add(SendPost_PatchButton);
			Controls.Add(POST_PATCHInputBox);
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
		private TextBox POST_PATCHInputBox;
		private Button SendPost_PatchButton;
		private Label JSON_BodyLabel;
		private TextBox JSON_Input;
		private Button SendDeleteButton;
		private TextBox DELETEInputBox;
		private Label DeleteLabel;
		private ComboBox POST_PATCH;
	}
}
