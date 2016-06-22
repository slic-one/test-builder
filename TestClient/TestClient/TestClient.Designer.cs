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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.listViewAnswers = new System.Windows.Forms.ListView();
            this.labelSubjectError = new System.Windows.Forms.Label();
            this.listBoxQuestion = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEndTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Items.AddRange(new object[] {
            "C++",
            "C#"});
            this.comboBoxSubjects.Location = new System.Drawing.Point(93, 8);
            this.comboBoxSubjects.MinimumSize = new System.Drawing.Size(50, 0);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(616, 25);
            this.comboBoxSubjects.TabIndex = 0;
            this.comboBoxSubjects.Text = " subject list";
            // 
            // buttonBeginTest
            // 
            this.buttonBeginTest.Location = new System.Drawing.Point(12, 6);
            this.buttonBeginTest.Name = "buttonBeginTest";
            this.buttonBeginTest.Size = new System.Drawing.Size(75, 27);
            this.buttonBeginTest.TabIndex = 1;
            this.buttonBeginTest.Text = "Begin test";
            this.buttonBeginTest.UseVisualStyleBackColor = true;
            this.buttonBeginTest.Click += new System.EventHandler(this.buttonBeginTest_Click);
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
            this.labelTimer.Location = new System.Drawing.Point(810, 6);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(42, 14);
            this.labelTimer.TabIndex = 3;
            this.labelTimer.Text = "00:00";
            // 
            // listViewAnswers
            // 
            this.listViewAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAnswers.CheckBoxes = true;
            this.listViewAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listViewAnswers.FullRowSelect = true;
            this.listViewAnswers.Location = new System.Drawing.Point(220, 157);
            this.listViewAnswers.Name = "listViewAnswers";
            this.listViewAnswers.Size = new System.Drawing.Size(632, 314);
            this.listViewAnswers.TabIndex = 4;
            this.listViewAnswers.UseCompatibleStateImageBehavior = false;
            this.listViewAnswers.View = System.Windows.Forms.View.List;
            this.listViewAnswers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewAnswers_ItemCheck);
            // 
            // labelSubjectError
            // 
            this.labelSubjectError.AutoSize = true;
            this.labelSubjectError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSubjectError.Location = new System.Drawing.Point(12, 36);
            this.labelSubjectError.Name = "labelSubjectError";
            this.labelSubjectError.Size = new System.Drawing.Size(93, 13);
            this.labelSubjectError.TabIndex = 5;
            this.labelSubjectError.Text = "Pick a subject first";
            this.labelSubjectError.Visible = false;
            // 
            // listBoxQuestion
            // 
            this.listBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxQuestion.FormattingEnabled = true;
            this.listBoxQuestion.Location = new System.Drawing.Point(12, 77);
            this.listBoxQuestion.Name = "listBoxQuestion";
            this.listBoxQuestion.Size = new System.Drawing.Size(199, 394);
            this.listBoxQuestion.TabIndex = 6;
            this.listBoxQuestion.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Questions list:";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(220, 59);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.ShortcutsEnabled = false;
            this.textBoxQuestion.Size = new System.Drawing.Size(625, 68);
            this.textBoxQuestion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Answers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Question";
            // 
            // buttonEndTest
            // 
            this.buttonEndTest.Location = new System.Drawing.Point(12, 8);
            this.buttonEndTest.Name = "buttonEndTest";
            this.buttonEndTest.Size = new System.Drawing.Size(75, 25);
            this.buttonEndTest.TabIndex = 11;
            this.buttonEndTest.Text = "End test";
            this.buttonEndTest.UseVisualStyleBackColor = true;
            this.buttonEndTest.Click += new System.EventHandler(this.buttonEndTest_Click_1);
            // 
            // TestClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxQuestion);
            this.Controls.Add(this.labelSubjectError);
            this.Controls.Add(this.listViewAnswers);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonBeginTest);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.buttonEndTest);
            this.MinimumSize = new System.Drawing.Size(198, 194);
            this.Name = "TestClient";
            this.Text = "Test client";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox comboBoxSubjects;
		private System.Windows.Forms.Button buttonBeginTest;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label labelTimer;
		private System.Windows.Forms.ListView listViewAnswers;
		private System.Windows.Forms.Label labelSubjectError;
        private System.Windows.Forms.ListBox listBoxQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEndTest;
    }
}

