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
            listBoxAnswers.Items.Add(textBoxAnswer.Text);
            textBoxAnswer.Clear();
        }
    }
}
