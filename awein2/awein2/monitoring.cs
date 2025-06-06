using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awein2
{
    public partial class monitoring : Form
    {
        public monitoring()
        {
            InitializeComponent();
        }

        private void monitoring_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet10.Comments' table. You can move, or remove it, as needed.
            this.commentsTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet10.Comments);
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet9.Review' table. You can move, or remove it, as needed.
            this.reviewTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet9.Review);
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet8.Recruiters' table. You can move, or remove it, as needed.
            this.recruitersTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet8.Recruiters);
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet7.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet7.Students);
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet6.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet6.Company);
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet5.JobFairEvents' table. You can move, or remove it, as needed.
            this.jobFairEventsTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet5.JobFairEvents);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
