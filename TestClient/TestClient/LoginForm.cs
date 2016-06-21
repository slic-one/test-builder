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

namespace TestClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLoginLoginForm_Click(object sender, EventArgs e)
        {
            if (textBoxGroupLoginForm.TextLength <= 0 || textBoxPasswordLoginForm.TextLength <= 0||textBoxNameLoginForm.TextLength<=0||textBoxSurnameLoginForm.TextLength<=0)
            {
                MessageBox.Show("You have to fill all fields!");
                return;
            }
            if (!File.Exists(textBoxGroupLoginForm.Text + ".txt"))
            {
                MessageBox.Show("Wrong group number! Please try again.");
                return;
            }
            using (StreamReader reader = new StreamReader(textBoxGroupLoginForm.Text+".txt"))
            {
                string groupPassword = reader.ReadLine();

                if (groupPassword==textBoxPasswordLoginForm.Text)
                { 
                        this.Hide();

                        TestClient client = new TestClient(textBoxNameLoginForm.Text,textBoxSurnameLoginForm.Text,textBoxGroupLoginForm.Text);
                        reader.Close();
                        client.ShowDialog();
                        this.Close();
               
                   
                }
                else 
                {
                    MessageBox.Show("Password is incorrect please try again!");
                }
            }
            
        }
    }
}
