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
            this.textBoxQuestionEditor = new System.Windows.Forms.TextBox();
            this.buttonAddAnswer = new System.Windows.Forms.Button();
            this.textBoxAnswerEditor = new System.Windows.Forms.TextBox();
            this.checkBoxRightAnswer = new System.Windows.Forms.CheckBox();
            this.buttonSaveQuestion = new System.Windows.Forms.Button();
            this.listViewAnswersEditor = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedQestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDocumentEditor = new System.Windows.Forms.TabPage();
            this.labelTopic = new System.Windows.Forms.Label();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewAnswersCopy = new System.Windows.Forms.ListView();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.tabPageAnswerEditor = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.adminStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.openXmlFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveXmlFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageDocumentEditor.SuspendLayout();
            this.tabPageAnswerEditor.SuspendLayout();
            this.adminStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxQuestionEditor
            // 
            this.textBoxQuestionEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuestionEditor.Location = new System.Drawing.Point(9, 9);
            this.textBoxQuestionEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuestionEditor.MaxLength = 256;
            this.textBoxQuestionEditor.Multiline = true;
            this.textBoxQuestionEditor.Name = "textBoxQuestionEditor";
            this.textBoxQuestionEditor.Size = new System.Drawing.Size(1022, 95);
            this.textBoxQuestionEditor.TabIndex = 0;
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAnswer.Location = new System.Drawing.Point(892, 118);
            this.buttonAddAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(141, 35);
            this.buttonAddAnswer.TabIndex = 3;
            this.buttonAddAnswer.Text = "Add answer";
            this.buttonAddAnswer.UseVisualStyleBackColor = false;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // textBoxAnswerEditor
            // 
            this.textBoxAnswerEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswerEditor.Location = new System.Drawing.Point(9, 118);
            this.textBoxAnswerEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAnswerEditor.MaxLength = 128;
            this.textBoxAnswerEditor.Multiline = true;
            this.textBoxAnswerEditor.Name = "textBoxAnswerEditor";
            this.textBoxAnswerEditor.Size = new System.Drawing.Size(722, 61);
            this.textBoxAnswerEditor.TabIndex = 1;
            // 
            // checkBoxRightAnswer
            // 
            this.checkBoxRightAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRightAnswer.AutoSize = true;
            this.checkBoxRightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRightAnswer.ForeColor = System.Drawing.Color.DarkGreen;
            this.checkBoxRightAnswer.Location = new System.Drawing.Point(744, 122);
            this.checkBoxRightAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxRightAnswer.Name = "checkBoxRightAnswer";
            this.checkBoxRightAnswer.Size = new System.Drawing.Size(102, 29);
            this.checkBoxRightAnswer.TabIndex = 2;
            this.checkBoxRightAnswer.Text = "Is right";
            this.checkBoxRightAnswer.UseVisualStyleBackColor = true;
            // 
            // buttonSaveQuestion
            // 
            this.buttonSaveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveQuestion.Location = new System.Drawing.Point(900, 657);
            this.buttonSaveQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveQuestion.Name = "buttonSaveQuestion";
            this.buttonSaveQuestion.Size = new System.Drawing.Size(141, 35);
            this.buttonSaveQuestion.TabIndex = 5;
            this.buttonSaveQuestion.Text = "Save question";
            this.buttonSaveQuestion.UseVisualStyleBackColor = true;
            this.buttonSaveQuestion.Click += new System.EventHandler(this.buttonSaveQuestion_Click);
            // 
            // listViewAnswersEditor
            // 
            this.listViewAnswersEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAnswersEditor.Location = new System.Drawing.Point(9, 191);
            this.listViewAnswersEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewAnswersEditor.MultiSelect = false;
            this.listViewAnswersEditor.Name = "listViewAnswersEditor";
            this.listViewAnswersEditor.Size = new System.Drawing.Size(722, 499);
            this.listViewAnswersEditor.TabIndex = 4;
            this.listViewAnswersEditor.UseCompatibleStateImageBehavior = false;
            this.listViewAnswersEditor.View = System.Windows.Forms.View.List;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1090, 35);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItemSaveAs,
            this.toolStripSeparator1,
            this.addUserToolStripMenuItem,
            this.showLogsToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItemSaveAs
            // 
            this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(251, 30);
            this.toolStripMenuItemSaveAs.Text = "Save As";
            this.toolStripMenuItemSaveAs.Click += new System.EventHandler(this.toolStripMenuItemSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(248, 6);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // showLogsToolStripMenuItem
            // 
            this.showLogsToolStripMenuItem.Name = "showLogsToolStripMenuItem";
            this.showLogsToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.showLogsToolStripMenuItem.Text = "Show logs";
            this.showLogsToolStripMenuItem.Click += new System.EventHandler(this.showLogsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSelectedQestionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            // 
            // editSelectedQestionToolStripMenuItem
            // 
            this.editSelectedQestionToolStripMenuItem.Name = "editSelectedQestionToolStripMenuItem";
            this.editSelectedQestionToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.editSelectedQestionToolStripMenuItem.Text = "Edit Selected Qestion";
            this.editSelectedQestionToolStripMenuItem.Click += new System.EventHandler(this.editSelectedQestionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageDocumentEditor);
            this.tabControl.Controls.Add(this.tabPageAnswerEditor);
            this.tabControl.Location = new System.Drawing.Point(0, 42);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1090, 714);
            this.tabControl.TabIndex = 7;
            // 
            // tabPageDocumentEditor
            // 
            this.tabPageDocumentEditor.Controls.Add(this.labelTopic);
            this.tabPageDocumentEditor.Controls.Add(this.textBoxTopic);
            this.tabPageDocumentEditor.Controls.Add(this.label2);
            this.tabPageDocumentEditor.Controls.Add(this.label1);
            this.tabPageDocumentEditor.Controls.Add(this.listViewAnswersCopy);
            this.tabPageDocumentEditor.Controls.Add(this.listBoxQuestions);
            this.tabPageDocumentEditor.Location = new System.Drawing.Point(28, 4);
            this.tabPageDocumentEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDocumentEditor.Name = "tabPageDocumentEditor";
            this.tabPageDocumentEditor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDocumentEditor.Size = new System.Drawing.Size(1058, 706);
            this.tabPageDocumentEditor.TabIndex = 1;
            this.tabPageDocumentEditor.Text = "Document editor";
            this.tabPageDocumentEditor.UseVisualStyleBackColor = true;
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(46, 9);
            this.labelTopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(82, 20);
            this.labelTopic.TabIndex = 9;
            this.labelTopic.Text = "Test topic:";
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTopic.Location = new System.Drawing.Point(141, 6);
            this.textBoxTopic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(347, 26);
            this.textBoxTopic.TabIndex = 8;
            this.textBoxTopic.Text = "Enter topic name";
            this.textBoxTopic.Leave += new System.EventHandler(this.textBoxTopic_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Answers of the selected question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Questions in this document";
            // 
            // listViewAnswersCopy
            // 
            this.listViewAnswersCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAnswersCopy.Location = new System.Drawing.Point(554, 29);
            this.listViewAnswersCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewAnswersCopy.Name = "listViewAnswersCopy";
            this.listViewAnswersCopy.Size = new System.Drawing.Size(490, 659);
            this.listViewAnswersCopy.TabIndex = 5;
            this.listViewAnswersCopy.UseCompatibleStateImageBehavior = false;
            this.listViewAnswersCopy.View = System.Windows.Forms.View.List;
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 20;
            this.listBoxQuestions.Location = new System.Drawing.Point(9, 69);
            this.listBoxQuestions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxQuestions.MinimumSize = new System.Drawing.Size(534, 624);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(534, 624);
            this.listBoxQuestions.TabIndex = 0;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // tabPageAnswerEditor
            // 
            this.tabPageAnswerEditor.Controls.Add(this.button1);
            this.tabPageAnswerEditor.Controls.Add(this.textBoxQuestionEditor);
            this.tabPageAnswerEditor.Controls.Add(this.listViewAnswersEditor);
            this.tabPageAnswerEditor.Controls.Add(this.buttonAddAnswer);
            this.tabPageAnswerEditor.Controls.Add(this.buttonSaveQuestion);
            this.tabPageAnswerEditor.Controls.Add(this.textBoxAnswerEditor);
            this.tabPageAnswerEditor.Controls.Add(this.checkBoxRightAnswer);
            this.tabPageAnswerEditor.Location = new System.Drawing.Point(28, 4);
            this.tabPageAnswerEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAnswerEditor.Name = "tabPageAnswerEditor";
            this.tabPageAnswerEditor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAnswerEditor.Size = new System.Drawing.Size(1058, 706);
            this.tabPageAnswerEditor.TabIndex = 0;
            this.tabPageAnswerEditor.Text = "Answers editor";
            this.tabPageAnswerEditor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(892, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminStatusStrip
            // 
            this.adminStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.adminStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusFileName});
            this.adminStatusStrip.Location = new System.Drawing.Point(0, 766);
            this.adminStatusStrip.Name = "adminStatusStrip";
            this.adminStatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.adminStatusStrip.Size = new System.Drawing.Size(1090, 22);
            this.adminStatusStrip.TabIndex = 8;
            this.adminStatusStrip.Text = "AdminPaner: Here file";
            // 
            // toolStripStatusFileName
            // 
            this.toolStripStatusFileName.Name = "toolStripStatusFileName";
            this.toolStripStatusFileName.Size = new System.Drawing.Size(0, 17);
            // 
            // QuestionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 788);
            this.Controls.Add(this.adminStatusStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(466, 238);
            this.Name = "QuestionEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageDocumentEditor.ResumeLayout(false);
            this.tabPageDocumentEditor.PerformLayout();
            this.tabPageAnswerEditor.ResumeLayout(false);
            this.tabPageAnswerEditor.PerformLayout();
            this.adminStatusStrip.ResumeLayout(false);
            this.adminStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestionEditor;
        private System.Windows.Forms.Button buttonAddAnswer;
        private System.Windows.Forms.TextBox textBoxAnswerEditor;
        private System.Windows.Forms.CheckBox checkBoxRightAnswer;
        private System.Windows.Forms.Button buttonSaveQuestion;
        private System.Windows.Forms.ListView listViewAnswersEditor;
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
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLogsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip adminStatusStrip;
        private System.Windows.Forms.OpenFileDialog openXmlFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveXmlFileDialog;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedQestionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFileName;
    }
}

