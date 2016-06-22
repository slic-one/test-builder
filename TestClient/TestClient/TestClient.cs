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
	public partial class TestClient : Form
	{
		int cntr = (int)TimeSpan.FromMinutes(40).TotalSeconds;
		DateTime dt = new DateTime();
        QuestionsBank qBank;

        string studentName;
        string studentSurname;
        string studentGroup;

        int counterRightAnswers;

        public TestClient(string name,string surname,string group)
		{
			InitializeComponent();

            buttonEndTest.Visible = false;
            buttonBeginTest.Visible = true;

            this.studentName = name;
            this.studentSurname = surname;
            this.studentGroup = group;

            timer1.Interval = 1000;
            qBank = QuestionsBank.LoadFromXml(@"cppTest.xml");
		}
		
		private void buttonBeginTest_Click(object sender, EventArgs e)
		{
			if (comboBoxSubjects.SelectedItem == null)
			{
				labelSubjectError.Visible = true;
				return;
			}
			labelSubjectError.Visible = false;

			buttonEndTest.Visible = true;
			buttonBeginTest.Visible = false;

			comboBoxSubjects.Enabled = false;
			//labelQuestion.Visible = true;

			timer1.Start();

            listBoxQuestion.DataSource = qBank.Questions;
		}

		/*private void buttonEndTest_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Are you sure you want to end the test?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			buttonEndTest.Visible = false;
			buttonBeginTest.Visible = true;
		}*/

		private void timer1_Tick(object sender, EventArgs e)
		{
			labelTimer.Text = dt.AddSeconds(cntr).ToString("mm:ss");
			cntr--;
		}

        private void listBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewAnswers.Clear();
            var selQuestion = listBoxQuestion.SelectedItem as Question;
            textBoxQuestion.Text = selQuestion.QuestionText;

            foreach (var a in selQuestion.Answers)
            {
                ListViewItem li = new ListViewItem(a.ToString());
                li.Tag = a;

                if (a.isSelected) // highlight if already was selected
                {
                    li.BackColor = Color.LightGray;
                    li.Checked = true;
                }

                listViewAnswers.Items.Add(li);
           }
        }

        private void buttonEndTest_Click_1(object sender, EventArgs e)
        {
            buttonEndTest.Visible = false;
            buttonBeginTest.Visible = true;

            DialogResult result= MessageBox.Show("Завершити тест?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result==DialogResult.Yes)
            {
                timer1.Stop();

                counterRightAnswers =0;
                int totalAnswers = qBank.Questions.Count;
                foreach(var question in qBank.Questions)
                {
                    foreach(var answer in question.Answers)
                    {
                        //here must be checking is selected answer right or not but it don't work
                        if (answer.isRight && answer.isSelected)
                        {
                            counterRightAnswers++;
                        }
                       
                    }
                }

                double min = Int32.Parse(labelTimer.Text.Substring(0, labelTimer.Text.IndexOf(":")));
                double sec= (Double)Int32.Parse(labelTimer.Text.Substring(labelTimer.Text.IndexOf(":")+1, 2))/100;
                double spentTime = 40.00 - (min + sec);


                MessageBox.Show(String.Format("Ваш результат {0} правильних відповідей з {1} за {2:0.0} хвилин", counterRightAnswers, totalAnswers,  spentTime));

                using (StreamWriter writer = new StreamWriter(studentGroup+"Rezults.txt", true))
                {
                    writer.WriteLine(String.Format("{0}  {1}  {2} -результат {3} з {4} час {5:0.0} хвилин", DateTime.Now, studentName, studentSurname, counterRightAnswers, qBank.Questions.Count, spentTime));
                }
            }
        }

        private void listViewAnswers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var answer = listViewAnswers.Items[e.Index].Tag as Answer;

            if (e.CurrentValue == CheckState.Unchecked)
            {
                answer.isSelected = true;
                listViewAnswers.Items[e.Index].BackColor = Color.LightGray;
            }
            else
            {
                answer.isSelected = false;
                listViewAnswers.Items[e.Index].BackColor = Color.White;
            }

        }
    }
}
