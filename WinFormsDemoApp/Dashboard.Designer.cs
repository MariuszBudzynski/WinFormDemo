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
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// DisplaytextBox
			// 
			DisplaytextBox.BackColor = Color.White;
			DisplaytextBox.BorderStyle = BorderStyle.FixedSingle;
			DisplaytextBox.ForeColor = Color.Black;
			DisplaytextBox.Location = new Point(12, 136);
			DisplaytextBox.Multiline = true;
			DisplaytextBox.Name = "DisplaytextBox";
			DisplaytextBox.ReadOnly = true;
			DisplaytextBox.ScrollBars = ScrollBars.Both;
			DisplaytextBox.Size = new Size(801, 220);
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
			statusStrip.Location = new Point(0, 409);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(845, 22);
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
			ResponseLabel.Location = new Point(12, 108);
			ResponseLabel.Name = "ResponseLabel";
			ResponseLabel.Size = new Size(91, 25);
			ResponseLabel.TabIndex = 6;
			ResponseLabel.Text = "Response";
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(845, 431);
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
	}
}
