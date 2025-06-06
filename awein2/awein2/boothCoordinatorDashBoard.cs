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
    public partial class boothCoordinatorDashBoard : Form
    {
        public boothCoordinatorDashBoard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkIn checkIn = new checkIn();
            checkIn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trafficMonitoring trafficMonitoring = new trafficMonitoring();
            trafficMonitoring.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
