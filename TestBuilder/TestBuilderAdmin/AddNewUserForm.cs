using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestBuilderAdmin
{
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private void buttonOkAddUser_Click(object sender, EventArgs e)
        {
            if(textBoxName.TextLength<=0||textBoxSurname.TextLength<=0||textBoxPasswordAddUser.TextLength<=0||textBoxLoginAddUser.TextLength<=0)
            {
                MessageBox.Show("You have to fill all fields!");
                return;
            }
            if (textBoxName.Text.Contains("-") || textBoxSurname.Text.Contains("-")|| textBoxPasswordAddUser.Text.Contains("-")||textBoxLoginAddUser.Text.Contains("-"))
            {
                MessageBox.Show("You can't use '-' symbol!");
                return;
            }
            bool isLoginOk = true;
            using (StreamReader reader = new StreamReader("admins.txt"))
            {
                string temp;
                while ((temp = reader.ReadLine()) != null)
                {
                    string stringToCompare = temp.Substring(0, temp.IndexOf(" "));
                    if (stringToCompare == textBoxLoginAddUser.Text)
                    {
                        MessageBox.Show("Such login already exists");
                        isLoginOk = false;
                        
                    }
                }
            }
            if(isLoginOk)
            {
                using (StreamWriter writeUser = new StreamWriter("admins.txt", true))
                {
                    writeUser.WriteLine(textBoxLoginAddUser.Text+" "+textBoxPasswordAddUser.Text+"-"+textBoxName.Text+ " "+textBoxSurname.Text+ " ");
                }
                MessageBox.Show("New user has been added sucсessfully");
                this.Close();
                
            }
        }

        private void buttonCancelAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
