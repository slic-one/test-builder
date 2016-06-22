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
    ///Class for autorization a client
    /**
    Check login and password of a client
    */ 
    public partial class Autorization : Form
    {
        bool isAdmin; 
        bool autorizationComplete;

        public Autorization()
        {
            InitializeComponent();

            autorizationComplete = false;
            isAdmin = false;
        }

        private void buttonOkAdminLog_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.TextLength<=0||textBoxPassword.TextLength<=0)
            {
                MessageBox.Show("You have to fill all fields!");
                return;
            }
            if(textBoxLogin.Text.Contains("-")|| textBoxPassword.Text.Contains("-"))
            {
                MessageBox.Show("You can't use '-' symbol!");
                return;
            }
            using (StreamReader reader = new StreamReader("admins.txt"))
            {
                string temp;
                while ((temp = reader.ReadLine()) != null)
                {
                    string stringToCompare = temp.Substring(0, temp.IndexOf("-"));
                    if (stringToCompare == String.Format(textBoxLogin.Text + " " + textBoxPassword.Text))
                    {
                        if(stringToCompare=="admin 111")
                        { isAdmin = true; }
                        autorizationComplete = true;
                        addLog(temp);
                        this.Hide();

                        QuestionEditorForm q = new QuestionEditorForm(isAdmin);
                        reader.Close();
                        q.ShowDialog();
                        this.Close();
                        break;
                    }
                }
            }
            if(!autorizationComplete)
            {
                MessageBox.Show("Login or password is incorrect please try again!");
            }
        }
        
        /** 
        *Write information about user to logHistory.txt in current date and time
        \brief Add login information about user to file
        \param user  information about user(name, surname,login, password)
        \author Nazar
        */
        private void addLog(string user)
        {
            using (StreamWriter writer = new StreamWriter("logHistory.txt",true))
            {
                writer.WriteLine(DateTime.Now + user.Substring(user.IndexOf("-"),user.LastIndexOf(" ")- user.IndexOf("-")));
            }
        }
        private void buttonCancelAdminLog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
