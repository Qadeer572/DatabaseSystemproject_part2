using awein2.CareerConnect_JobFairManagementDataSet17TableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using awein2.CareerConnect_JobFairManagementDataSet18TableAdapters;
using System.IO;

namespace awein2
{
    public partial class boothTrafficView : Form
    {
        public boothTrafficView()
        {
            InitializeComponent();
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        private void boothTrafficView_Load(object sender, EventArgs e)
        {
            var adapter = new boothTrafficTableAdapter();
            var dt = new CareerConnect_JobFairManagementDataSet18.boothTrafficDataTable();
            adapter.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"C:\Users\MP\Data Strucutre\awein2\awein2\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("boothTraffic", (DataTable)dt)); // <-- must match RDLC name
            reportViewer1.RefreshReport();
        }
    }
}
