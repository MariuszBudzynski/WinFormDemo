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
			label1 = new Label();
			label2 = new Label();
			GET = new TextBox();
			SendGet = new Button();
			SuspendLayout();
			// 
			// DisplaytextBox
			// 
			DisplaytextBox.Location = new Point(12, 279);
			DisplaytextBox.Multiline = true;
			DisplaytextBox.Name = "DisplaytextBox";
			DisplaytextBox.Size = new Size(801, 253);
			DisplaytextBox.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(25, 7);
			label1.Name = "label1";
			label1.Size = new Size(130, 25);
			label1.TabIndex = 1;
			label1.Text = "Reguest Types";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(25, 45);
			label2.Name = "label2";
			label2.Size = new Size(41, 25);
			label2.TabIndex = 2;
			label2.Text = "Get";
			// 
			// GET
			// 
			GET.Location = new Point(92, 42);
			GET.Name = "GET";
			GET.PlaceholderText = "Enter Get Endpoint";
			GET.Size = new Size(585, 33);
			GET.TabIndex = 3;
			// 
			// SendGet
			// 
			SendGet.Location = new Point(716, 42);
			SendGet.Name = "SendGet";
			SendGet.Size = new Size(97, 36);
			SendGet.TabIndex = 4;
			SendGet.Text = "Send";
			SendGet.UseVisualStyleBackColor = true;
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(845, 750);
			Controls.Add(SendGet);
			Controls.Add(GET);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(DisplaytextBox);
			Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			Margin = new Padding(5, 5, 5, 5);
			Name = "Dashboard";
			Text = "DemoApp";
			Load += this.Dashboard_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox DisplaytextBox;
		private Label label1;
		private Label label2;
		private TextBox GET;
		private Button SendGet;
	}
}
