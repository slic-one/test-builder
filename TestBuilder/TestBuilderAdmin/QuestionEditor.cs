using System;
using System.Collections.Generic;
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
        QuestionsBank qBank;

        public QuestionEditorForm(bool userIsAdmin)
        {
            InitializeComponent();

            if (!userIsAdmin)
            {
                addUserToolStripMenuItem.Enabled = false;
                showLogsToolStripMenuItem.Enabled = false;
            }

            qBank = new QuestionsBank();

            //settings
            saveXmlFileDialog.DefaultExt = "xml";
            saveXmlFileDialog.AddExtension = true;
            saveXmlFileDialog.Filter = "Xml Files (.xml)|*.xml";
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAnswerEditor.Text))
            {
                MessageBox.Show("Cannot add empty answer..");
                return;
            }

            Answer answer = new Answer(textBoxAnswerEditor.Text, checkBoxRightAnswer.Checked);
            ListViewItem li = new ListViewItem(answer.AnswerText);
            li.Tag = answer; // save to Tag an instance of class

            if (answer.isRight)
                li.ForeColor = Color.Green;

            listViewAnswersEditor.Items.Add(li);

            checkBoxRightAnswer.Checked = false;
            textBoxAnswerEditor.Clear();
            textBoxAnswerEditor.Focus();
        }

        private void buttonSaveQuestion_Click(object sender, EventArgs e)
        {
            Question toSave = new Question();

            string questionText = textBoxQuestionEditor.Text;

            if (String.IsNullOrEmpty(questionText) || String.IsNullOrWhiteSpace(questionText))
            {
                MessageBox.Show("Question cannot be empty!");
                return;
            }
            else
                toSave.QuestionText = questionText;

            foreach (ListViewItem li in listViewAnswersEditor.Items)
            {
                // unbox answer from Tag (after adding to list)
                toSave.Answers.Add(li.Tag as Answer);
            }


            //if this question existed before updated only answers
            bool questionAlreadyExists = false;
            string currentQestionText = toSave.QuestionText.Trim(); //remove all white spaces before/after
            foreach (var q in qBank.Questions)
            {
                if (currentQestionText == q.QuestionText.Trim())
                {
                    q.Answers = toSave.Answers;
                    questionAlreadyExists = true;
                    break;
                }
            }

            if(!questionAlreadyExists)
                qBank.Questions.Add(toSave);

            clearQuestionEditor();

            MessageBox.Show("Question saved successfully!");
            //refresh questions list
            listBoxQuestions.SelectedIndex = -1;
            listBoxQuestions.DataSource = null;
            listBoxQuestions.DataSource = qBank.Questions;

        }

        private void clearQuestionEditor()
        {
            textBoxQuestionEditor.Clear();
            textBoxAnswerEditor.Clear();
            listViewAnswersEditor.Clear();
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem == null)
                return;

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



        #region work_With_Xml_Files
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openXmlFileDialog.Filter = "Xml Files (.xml)|*.xml";

            if (DialogResult.OK == openXmlFileDialog.ShowDialog())
            {
                qBank = QuestionsBank.LoadFromXml(openXmlFileDialog.FileName);
                qBank.xmlFileLocation = openXmlFileDialog.FileName;
            }

            listBoxQuestions.DataSource = qBank.Questions;
            textBoxTopic.Text = qBank.Topic;
            toolStripStatusFileName.Text = Path.GetFileName(qBank.xmlFileLocation);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(qBank.xmlFileLocation))
                    qBank.SaveToXml(qBank.xmlFileLocation);
                else
                {
                    if (DialogResult.OK == saveXmlFileDialog.ShowDialog())
                    {
                        qBank.xmlFileLocation = saveXmlFileDialog.FileName;
                        qBank.SaveToXml(qBank.xmlFileLocation);
                    }
                }

                MessageBox.Show("File '{0}' save successfully!", Path.GetFileName(qBank.xmlFileLocation));
            }
            catch
            {
                string fileName = Path.GetFileName(qBank.xmlFileLocation);
                string eMessage = String.Format("Error: Cannot rewrite file: '{0}' \nPath: ", fileName, qBank.xmlFileLocation);
                MessageBox.Show(eMessage);
            }
        }

        private void toolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            saveXmlFileDialog.DefaultExt = "xml";
            saveXmlFileDialog.AddExtension = true;
            saveXmlFileDialog.Filter = "Xml Files (.xml)|*.xml";

            if (DialogResult.OK == saveXmlFileDialog.ShowDialog())
            {
                try
                {
                    qBank.SaveToXml(saveXmlFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Some problems in saving your file on this location");
                }
            }
        }

        #endregion

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

        //before press "edit question" check if selected one
        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem == null)
                editSelectedQestionToolStripMenuItem.Enabled = false;
            else
                editSelectedQestionToolStripMenuItem.Enabled = true;
        }

        //put selected question into question editor
        private void editSelectedQestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedQestion = listBoxQuestions.SelectedItem as Question;
            textBoxQuestionEditor.Text = selectedQestion.QuestionText;

            //fill list with answers
            int counter = 0;
            foreach (var answer in selectedQestion.Answers)
            {
                ListViewItem li = new ListViewItem(answer.ToString());
                li.Tag = answer;
                listViewAnswersEditor.Items.Add(li);

                if (answer.isRight) // highlight right answers with green color
                    listViewAnswersEditor.Items[counter].ForeColor = Color.Green;
                counter++;
            }

            tabControl.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewAnswersEditor.SelectedIndices.Count > 0)
                listViewAnswersEditor.Items.RemoveAt(listViewAnswersEditor.SelectedIndices[0]);
            else
                MessageBox.Show("To remove first select answer...");
        }

        private void textBoxTopic_Leave(object sender, EventArgs e)
        {
            qBank.Topic = textBoxTopic.Text;
        }
    }
}
