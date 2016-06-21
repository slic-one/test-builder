namespace TestClient
{
	partial class TestClient
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
			this.buttonBeginTest = new System.Windows.Forms.Button();
			this.buttonEndTest = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.labelTimer = new System.Windows.Forms.Label();
			this.labelQuestion = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.labelSubjectError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBoxSubjects
			// 
			this.comboBoxSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSubjects.FormattingEnabled = true;
			this.comboBoxSubjects.Items.AddRange(new object[] {
            "C++",
            "C#"});
			this.comboBoxSubjects.Location = new System.Drawing.Point(84, 3);
			this.comboBoxSubjects.MinimumSize = new System.Drawing.Size(50, 0);
			this.comboBoxSubjects.Name = "comboBoxSubjects";
			this.comboBoxSubjects.Size = new System.Drawing.Size(206, 21);
			this.comboBoxSubjects.TabIndex = 0;
			this.comboBoxSubjects.Text = " subject list";
			// 
			// buttonBeginTest
			// 
			this.buttonBeginTest.Location = new System.Drawing.Point(3, 1);
			this.buttonBeginTest.Name = "buttonBeginTest";
			this.buttonBeginTest.Size = new System.Drawing.Size(75, 23);
			this.buttonBeginTest.TabIndex = 1;
			this.buttonBeginTest.Text = "Begin test";
			this.buttonBeginTest.UseVisualStyleBackColor = true;
			this.buttonBeginTest.Click += new System.EventHandler(this.buttonBeginTest_Click);
			// 
			// buttonEndTest
			// 
			this.buttonEndTest.Location = new System.Drawing.Point(3, 1);
			this.buttonEndTest.MinimumSize = new System.Drawing.Size(50, 0);
			this.buttonEndTest.Name = "buttonEndTest";
			this.buttonEndTest.Size = new System.Drawing.Size(75, 23);
			this.buttonEndTest.TabIndex = 2;
			this.buttonEndTest.Text = "End test";
			this.buttonEndTest.UseVisualStyleBackColor = true;
			this.buttonEndTest.Visible = false;
			this.buttonEndTest.Click += new System.EventHandler(this.buttonEndTest_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// labelTimer
			// 
			this.labelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTimer.AutoSize = true;
			this.labelTimer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTimer.Location = new System.Drawing.Point(393, 6);
			this.labelTimer.Name = "labelTimer";
			this.labelTimer.Size = new System.Drawing.Size(42, 14);
			this.labelTimer.TabIndex = 3;
			this.labelTimer.Text = "00:00";
			// 
			// labelQuestion
			// 
			this.labelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelQuestion.AutoSize = true;
			this.labelQuestion.Location = new System.Drawing.Point(12, 38);
			this.labelQuestion.Name = "labelQuestion";
			this.labelQuestion.Size = new System.Drawing.Size(53, 13);
			this.labelQuestion.TabIndex = 0;
			this.labelQuestion.Text = "[question]";
			this.labelQuestion.Visible = false;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Location = new System.Drawing.Point(3, 157);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(432, 317);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// labelSubjectError
			// 
			this.labelSubjectError.AutoSize = true;
			this.labelSubjectError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelSubjectError.Location = new System.Drawing.Point(0, 25);
			this.labelSubjectError.Name = "labelSubjectError";
			this.labelSubjectError.Size = new System.Drawing.Size(93, 13);
			this.labelSubjectError.TabIndex = 5;
			this.labelSubjectError.Text = "Pick a subject first";
			this.labelSubjectError.Visible = false;
			// 
			// TestClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 477);
			this.Controls.Add(this.labelSubjectError);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.labelTimer);
			this.Controls.Add(this.buttonEndTest);
			this.Controls.Add(this.buttonBeginTest);
			this.Controls.Add(this.comboBoxSubjects);
			this.Controls.Add(this.labelQuestion);
			this.MinimumSize = new System.Drawing.Size(200, 200);
			this.Name = "TestClient";
			this.Text = "Test client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox comboBoxSubjects;
		private System.Windows.Forms.Button buttonBeginTest;
		private System.Windows.Forms.Button buttonEndTest;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label labelTimer;
		private System.Windows.Forms.Label labelQuestion;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label labelSubjectError;
	}
}

