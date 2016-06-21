using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClient
{
	public partial class TestClient : Form
	{
		int cntr = (int)TimeSpan.FromMinutes(40).TotalSeconds;
		DateTime dt = new DateTime();

		public TestClient()
		{
			InitializeComponent();
			timer1.Interval = 1000;

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
			labelQuestion.Visible = true;

			timer1.Start();
		}

		private void buttonEndTest_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Are you sure you want to end the test?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			buttonEndTest.Visible = false;
			buttonBeginTest.Visible = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			labelTimer.Text = dt.AddSeconds(cntr).ToString("mm:ss");
			cntr--;
		}
	}
}
