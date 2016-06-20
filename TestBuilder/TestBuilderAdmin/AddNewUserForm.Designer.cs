namespace TestBuilderAdmin
{
    partial class AddNewUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxLoginAddUser = new System.Windows.Forms.TextBox();
            this.textBoxPasswordAddUser = new System.Windows.Forms.TextBox();
            this.buttonOkAddUser = new System.Windows.Forms.Button();
            this.buttonCancelAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "login:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(141, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(237, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(141, 74);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(237, 26);
            this.textBoxSurname.TabIndex = 5;
            // 
            // textBoxLoginAddUser
            // 
            this.textBoxLoginAddUser.Location = new System.Drawing.Point(141, 122);
            this.textBoxLoginAddUser.Name = "textBoxLoginAddUser";
            this.textBoxLoginAddUser.Size = new System.Drawing.Size(237, 26);
            this.textBoxLoginAddUser.TabIndex = 6;
            // 
            // textBoxPasswordAddUser
            // 
            this.textBoxPasswordAddUser.Location = new System.Drawing.Point(141, 167);
            this.textBoxPasswordAddUser.Name = "textBoxPasswordAddUser";
            this.textBoxPasswordAddUser.Size = new System.Drawing.Size(237, 26);
            this.textBoxPasswordAddUser.TabIndex = 7;
            // 
            // buttonOkAddUser
            // 
            this.buttonOkAddUser.Location = new System.Drawing.Point(61, 232);
            this.buttonOkAddUser.Name = "buttonOkAddUser";
            this.buttonOkAddUser.Size = new System.Drawing.Size(94, 32);
            this.buttonOkAddUser.TabIndex = 8;
            this.buttonOkAddUser.Text = "OK";
            this.buttonOkAddUser.UseVisualStyleBackColor = true;
            this.buttonOkAddUser.Click += new System.EventHandler(this.buttonOkAddUser_Click);
            // 
            // buttonCancelAddUser
            // 
            this.buttonCancelAddUser.Location = new System.Drawing.Point(234, 232);
            this.buttonCancelAddUser.Name = "buttonCancelAddUser";
            this.buttonCancelAddUser.Size = new System.Drawing.Size(94, 32);
            this.buttonCancelAddUser.TabIndex = 9;
            this.buttonCancelAddUser.Text = "CANCEL";
            this.buttonCancelAddUser.UseVisualStyleBackColor = true;
            this.buttonCancelAddUser.Click += new System.EventHandler(this.buttonCancelAddUser_Click);
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 289);
            this.Controls.Add(this.buttonCancelAddUser);
            this.Controls.Add(this.buttonOkAddUser);
            this.Controls.Add(this.textBoxPasswordAddUser);
            this.Controls.Add(this.textBoxLoginAddUser);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewUserForm";
            this.Text = "AddNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxLoginAddUser;
        private System.Windows.Forms.TextBox textBoxPasswordAddUser;
        private System.Windows.Forms.Button buttonOkAddUser;
        private System.Windows.Forms.Button buttonCancelAddUser;
    }
}