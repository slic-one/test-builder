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
    public partial class QuestionEditorForm : Form
    {
        //list of questions, should be saved/loaded from a document
        //List<Question> questions = new List<Question>();
        //List<Answer> currentAnswers = new List<Answer>();

        QuestionsBank qBank;


        public QuestionEditorForm(bool userIsAdmin)
        {
            InitializeComponent();

            if(!userIsAdmin)
            {
                addUserToolStripMenuItem.Enabled = false;
                showLogsToolStripMenuItem.Enabled = false;
            }
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            //var answer = new Answer(checkBoxRightAnswer.Checked, textBoxAnswer.Text);
            //currentAnswers.Add(answer);

            //listViewAnswers.Items.Add(answer.Text);
            //if (checkBoxRightAnswer.Checked)
            //    listViewAnswers.Items[listViewAnswers.Items.Count-1].ForeColor = Color.Green;

            //checkBoxRightAnswer.Checked = false;
            //textBoxAnswer.Clear();
            //textBoxAnswer.Focus();
        }

        private void buttonSaveQuestion_Click(object sender, EventArgs e)
        {
            //Question toSave = new Question(textBoxQuestion.Text, currentAnswers);
            //questions.Add(toSave);
            //listBoxQuestions.Items.Add(toSave);
            
            //currentAnswers.Clear();
            //listViewAnswers.Clear();
            //textBoxQuestion.Clear();
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewAnswersCopy.Clear();
            var selectedQestion = listBoxQuestions.SelectedItem as Question;

            int counter = 0;
            foreach (var a in selectedQestion.Answers)
            {
                listViewAnswersCopy.Items.Add(a.ToString());

                if (a.isRight) // highlight right answers with green color
                    listViewAnswersCopy.Items[counter].ForeColor = Color.Green;
                counter++;
            }

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUserForm addUser = new AddNewUserForm();
            addUser.ShowDialog();
        }

        private void showLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string logs;
                using (StreamReader reader = new StreamReader("logHistory.txt"))
                {
                    logs = reader.ReadToEnd();
                }
            MessageBox.Show(logs);  
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openXmlFileDialog.Filter = "Xml Files (.xml)|*.xml";

            if (DialogResult.OK == openXmlFileDialog.ShowDialog())
            {
                qBank = QuestionsBank.LoadFromXml(openXmlFileDialog.FileName);
                listBoxQuestions.DataSource = qBank.Questions;
            }

        }
    }
}
