using awein2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Microsoft.Reporting.WinForms;

namespace i233058_labdb_win_form_
{
    public partial class tpoDashBoard : Form
    {
        public tpoDashBoard()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadUserControl(UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
            
        }
     


        private void button1_Click(object sender, EventArgs e)
        {
            approval approvalForm = new approval();  
            approvalForm.Show();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
           eventSchedule eventSchedule = new eventSchedule();
            eventSchedule.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addingBooths addingBooths = new addingBooths();
            addingBooths.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boothAllocation boothAllocation = new boothAllocation();
            boothAllocation.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            monitoring monitoring = new monitoring();
            monitoring.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void button5_Click(object sender, EventArgs e)
        {
            placementReport placementReport = new placementReport();
            placementReport.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            boothTrafficView boothTrafficViewer = new boothTrafficView();
            boothTrafficViewer.Show();
        }
    }
}
