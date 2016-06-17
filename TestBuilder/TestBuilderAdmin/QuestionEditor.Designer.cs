namespace TestBuilderAdmin
{
    partial class QuestionEditorForm
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
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonAddAnswer = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.checkBoxRightAnswer = new System.Windows.Forms.CheckBox();
            this.buttonSaveQuestion = new System.Windows.Forms.Button();
            this.listViewAnswers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuestion.Location = new System.Drawing.Point(13, 12);
            this.textBoxQuestion.MaxLength = 256;
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(548, 63);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAnswer.Location = new System.Drawing.Point(467, 81);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(94, 23);
            this.buttonAddAnswer.TabIndex = 3;
            this.buttonAddAnswer.Text = "Add answer";
            this.buttonAddAnswer.UseVisualStyleBackColor = true;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer.Location = new System.Drawing.Point(13, 83);
            this.textBoxAnswer.MaxLength = 128;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(348, 20);
            this.textBoxAnswer.TabIndex = 1;
            // 
            // checkBoxRightAnswer
            // 
            this.checkBoxRightAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRightAnswer.AutoSize = true;
            this.checkBoxRightAnswer.Location = new System.Drawing.Point(367, 85);
            this.checkBoxRightAnswer.Name = "checkBoxRightAnswer";
            this.checkBoxRightAnswer.Size = new System.Drawing.Size(94, 17);
            this.checkBoxRightAnswer.TabIndex = 2;
            this.checkBoxRightAnswer.Text = "Is right answer";
            this.checkBoxRightAnswer.UseVisualStyleBackColor = true;
            // 
            // buttonSaveQuestion
            // 
            this.buttonSaveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveQuestion.Location = new System.Drawing.Point(467, 235);
            this.buttonSaveQuestion.Name = "buttonSaveQuestion";
            this.buttonSaveQuestion.Size = new System.Drawing.Size(94, 23);
            this.buttonSaveQuestion.TabIndex = 5;
            this.buttonSaveQuestion.Text = "Save question";
            this.buttonSaveQuestion.UseVisualStyleBackColor = true;
            this.buttonSaveQuestion.Click += new System.EventHandler(this.buttonSaveQuestion_Click);
            // 
            // listViewAnswers
            // 
            this.listViewAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAnswers.Location = new System.Drawing.Point(12, 109);
            this.listViewAnswers.Name = "listViewAnswers";
            this.listViewAnswers.Size = new System.Drawing.Size(349, 147);
            this.listViewAnswers.TabIndex = 4;
            this.listViewAnswers.UseCompatibleStateImageBehavior = false;
            this.listViewAnswers.View = System.Windows.Forms.View.List;
            // 
            // QuestionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 270);
            this.Controls.Add(this.listViewAnswers);
            this.Controls.Add(this.buttonSaveQuestion);
            this.Controls.Add(this.checkBoxRightAnswer);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonAddAnswer);
            this.Controls.Add(this.textBoxQuestion);
            this.MinimumSize = new System.Drawing.Size(320, 180);
            this.Name = "QuestionEditorForm";
            this.Text = "Question Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonAddAnswer;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.CheckBox checkBoxRightAnswer;
        private System.Windows.Forms.Button buttonSaveQuestion;
        private System.Windows.Forms.ListView listViewAnswers;
    }
}

