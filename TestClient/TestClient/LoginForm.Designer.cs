namespace TestClient
{
    partial class LoginForm
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
            this.textBoxNameLoginForm = new System.Windows.Forms.TextBox();
            this.textBoxSurnameLoginForm = new System.Windows.Forms.TextBox();
            this.textBoxGroupLoginForm = new System.Windows.Forms.TextBox();
            this.textBoxPasswordLoginForm = new System.Windows.Forms.TextBox();
            this.buttonLoginLoginForm = new System.Windows.Forms.Button();
            this.buttonCancelLoginForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // textBoxNameLoginForm
            // 
            this.textBoxNameLoginForm.Location = new System.Drawing.Point(140, 49);
            this.textBoxNameLoginForm.Name = "textBoxNameLoginForm";
            this.textBoxNameLoginForm.Size = new System.Drawing.Size(195, 26);
            this.textBoxNameLoginForm.TabIndex = 4;
            this.textBoxNameLoginForm.Text = "Bob";
            // 
            // textBoxSurnameLoginForm
            // 
            this.textBoxSurnameLoginForm.Location = new System.Drawing.Point(140, 99);
            this.textBoxSurnameLoginForm.Name = "textBoxSurnameLoginForm";
            this.textBoxSurnameLoginForm.Size = new System.Drawing.Size(195, 26);
            this.textBoxSurnameLoginForm.TabIndex = 5;
            this.textBoxSurnameLoginForm.Text = "Optimus";
            // 
            // textBoxGroupLoginForm
            // 
            this.textBoxGroupLoginForm.Location = new System.Drawing.Point(140, 152);
            this.textBoxGroupLoginForm.Name = "textBoxGroupLoginForm";
            this.textBoxGroupLoginForm.Size = new System.Drawing.Size(195, 26);
            this.textBoxGroupLoginForm.TabIndex = 6;
            this.textBoxGroupLoginForm.Text = "s23-rp";
            // 
            // textBoxPasswordLoginForm
            // 
            this.textBoxPasswordLoginForm.Location = new System.Drawing.Point(140, 212);
            this.textBoxPasswordLoginForm.Name = "textBoxPasswordLoginForm";
            this.textBoxPasswordLoginForm.PasswordChar = '*';
            this.textBoxPasswordLoginForm.Size = new System.Drawing.Size(195, 26);
            this.textBoxPasswordLoginForm.TabIndex = 7;
            this.textBoxPasswordLoginForm.Text = "222";
            // 
            // buttonLoginLoginForm
            // 
            this.buttonLoginLoginForm.Location = new System.Drawing.Point(57, 297);
            this.buttonLoginLoginForm.Name = "buttonLoginLoginForm";
            this.buttonLoginLoginForm.Size = new System.Drawing.Size(91, 33);
            this.buttonLoginLoginForm.TabIndex = 8;
            this.buttonLoginLoginForm.Text = "LOGIN";
            this.buttonLoginLoginForm.UseVisualStyleBackColor = true;
            this.buttonLoginLoginForm.Click += new System.EventHandler(this.buttonLoginLoginForm_Click);
            // 
            // buttonCancelLoginForm
            // 
            this.buttonCancelLoginForm.Location = new System.Drawing.Point(208, 297);
            this.buttonCancelLoginForm.Name = "buttonCancelLoginForm";
            this.buttonCancelLoginForm.Size = new System.Drawing.Size(91, 33);
            this.buttonCancelLoginForm.TabIndex = 9;
            this.buttonCancelLoginForm.Text = "CANCEL";
            this.buttonCancelLoginForm.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 353);
            this.Controls.Add(this.buttonCancelLoginForm);
            this.Controls.Add(this.buttonLoginLoginForm);
            this.Controls.Add(this.textBoxPasswordLoginForm);
            this.Controls.Add(this.textBoxGroupLoginForm);
            this.Controls.Add(this.textBoxSurnameLoginForm);
            this.Controls.Add(this.textBoxNameLoginForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNameLoginForm;
        private System.Windows.Forms.TextBox textBoxSurnameLoginForm;
        private System.Windows.Forms.TextBox textBoxGroupLoginForm;
        private System.Windows.Forms.TextBox textBoxPasswordLoginForm;
        private System.Windows.Forms.Button buttonLoginLoginForm;
        private System.Windows.Forms.Button buttonCancelLoginForm;
    }
}