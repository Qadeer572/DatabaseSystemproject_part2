using Microsoft.Reporting.WinForms;
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

using awein2.CareerConnect_JobFairManagementDataSet17TableAdapters;

namespace awein2
{
    public partial class placementReport : Form
    {
        public placementReport()
        {
            InitializeComponent();
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            

        }

        private void placementReport_Load(object sender, EventArgs e)
        {
            var num1 = new placementDataTableAdapter();
            var da = new CareerConnect_JobFairManagementDataSet17.placementDataDataTable();
            num1.Fill(da);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"C:\Users\MP\Data Strucutre\awein2\awein2\placement.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("placementData", (DataTable)da)); // <-- must match RDLC name
            reportViewer1.RefreshReport();
        }

    }
}
