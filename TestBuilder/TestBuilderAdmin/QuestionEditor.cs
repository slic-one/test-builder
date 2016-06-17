using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBuilderAdmin
{
    public partial class QuestionEditorForm : Form
    {
        public QuestionEditorForm()
        {
            InitializeComponent();
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            var answer = new Answer(checkBoxRightAnswer.Checked, textBoxAnswer.Text);

            listViewAnswers.Items.Add(answer.Text);
            if (checkBoxRightAnswer.Checked)
                listViewAnswers.Items[listViewAnswers.Items.Count-1].ForeColor = Color.Green;

            checkBoxRightAnswer.Checked = false;
            textBoxAnswer.Clear();
            textBoxAnswer.Focus();
        }

        private void buttonSaveQuestion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
