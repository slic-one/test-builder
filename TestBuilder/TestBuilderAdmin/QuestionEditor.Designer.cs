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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAnswerEditor = new System.Windows.Forms.TabPage();
            this.tabPageDocumentEditor = new System.Windows.Forms.TabPage();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.listViewAnswersCopy = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageAnswerEditor.SuspendLayout();
            this.tabPageDocumentEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuestion.Location = new System.Drawing.Point(6, 6);
            this.textBoxQuestion.MaxLength = 256;
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(630, 63);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAnswer.Location = new System.Drawing.Point(542, 75);
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
            this.textBoxAnswer.Location = new System.Drawing.Point(6, 77);
            this.textBoxAnswer.MaxLength = 128;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(430, 20);
            this.textBoxAnswer.TabIndex = 1;
            // 
            // checkBoxRightAnswer
            // 
            this.checkBoxRightAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRightAnswer.AutoSize = true;
            this.checkBoxRightAnswer.Location = new System.Drawing.Point(442, 79);
            this.checkBoxRightAnswer.Name = "checkBoxRightAnswer";
            this.checkBoxRightAnswer.Size = new System.Drawing.Size(94, 17);
            this.checkBoxRightAnswer.TabIndex = 2;
            this.checkBoxRightAnswer.Text = "Is right answer";
            this.checkBoxRightAnswer.UseVisualStyleBackColor = true;
            // 
            // buttonSaveQuestion
            // 
            this.buttonSaveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveQuestion.Location = new System.Drawing.Point(542, 377);
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
            this.listViewAnswers.Location = new System.Drawing.Point(6, 103);
            this.listViewAnswers.Name = "listViewAnswers";
            this.listViewAnswers.Size = new System.Drawing.Size(430, 297);
            this.listViewAnswers.TabIndex = 4;
            this.listViewAnswers.UseCompatibleStateImageBehavior = false;
            this.listViewAnswers.View = System.Windows.Forms.View.List;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabPageDocumentEditor);
            this.tabControl.Controls.Add(this.tabPageAnswerEditor);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(674, 414);
            this.tabControl.TabIndex = 7;
            // 
            // tabPageAnswerEditor
            // 
            this.tabPageAnswerEditor.Controls.Add(this.textBoxQuestion);
            this.tabPageAnswerEditor.Controls.Add(this.listViewAnswers);
            this.tabPageAnswerEditor.Controls.Add(this.buttonAddAnswer);
            this.tabPageAnswerEditor.Controls.Add(this.buttonSaveQuestion);
            this.tabPageAnswerEditor.Controls.Add(this.textBoxAnswer);
            this.tabPageAnswerEditor.Controls.Add(this.checkBoxRightAnswer);
            this.tabPageAnswerEditor.Location = new System.Drawing.Point(23, 4);
            this.tabPageAnswerEditor.Name = "tabPageAnswerEditor";
            this.tabPageAnswerEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnswerEditor.Size = new System.Drawing.Size(647, 406);
            this.tabPageAnswerEditor.TabIndex = 0;
            this.tabPageAnswerEditor.Text = "Answers editor";
            this.tabPageAnswerEditor.UseVisualStyleBackColor = true;
            // 
            // tabPageDocumentEditor
            // 
            this.tabPageDocumentEditor.Controls.Add(this.label2);
            this.tabPageDocumentEditor.Controls.Add(this.label1);
            this.tabPageDocumentEditor.Controls.Add(this.listViewAnswersCopy);
            this.tabPageDocumentEditor.Controls.Add(this.listBoxQuestions);
            this.tabPageDocumentEditor.Location = new System.Drawing.Point(23, 4);
            this.tabPageDocumentEditor.Name = "tabPageDocumentEditor";
            this.tabPageDocumentEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocumentEditor.Size = new System.Drawing.Size(647, 406);
            this.tabPageDocumentEditor.TabIndex = 1;
            this.tabPageDocumentEditor.Text = "Document editor";
            this.tabPageDocumentEditor.UseVisualStyleBackColor = true;
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.Location = new System.Drawing.Point(6, 19);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(319, 381);
            this.listBoxQuestions.TabIndex = 0;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // listViewAnswersCopy
            // 
            this.listViewAnswersCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAnswersCopy.Location = new System.Drawing.Point(331, 19);
            this.listViewAnswersCopy.Name = "listViewAnswersCopy";
            this.listViewAnswersCopy.Size = new System.Drawing.Size(310, 380);
            this.listViewAnswersCopy.TabIndex = 5;
            this.listViewAnswersCopy.UseCompatibleStateImageBehavior = false;
            this.listViewAnswersCopy.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Questions in this document";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Answers of the selected question";
            // 
            // QuestionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 442);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(320, 180);
            this.Name = "QuestionEditorForm";
            this.Text = "Question Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageAnswerEditor.ResumeLayout(false);
            this.tabPageAnswerEditor.PerformLayout();
            this.tabPageDocumentEditor.ResumeLayout(false);
            this.tabPageDocumentEditor.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAnswerEditor;
        private System.Windows.Forms.TabPage tabPageDocumentEditor;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.ListView listViewAnswersCopy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

