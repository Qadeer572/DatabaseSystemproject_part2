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

namespace awein2
{
    public partial class trafficMonitoring : Form
    {
        public trafficMonitoring()
        {
            InitializeComponent();
        }

        private void trafficMonitoring_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet13.BoothCheckIn' table. You can move, or remove it, as needed.
            //this.boothCheckInTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet13.BoothCheckIn);
            LoadGroupedCheckInData();
        }
        private void LoadGroupedCheckInData()
        {
            string connectionString = "Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;";

            string query = @"
        SELECT 
           
            EventID,
            BoothID,
            COUNT(*) AS CheckInCount
        FROM 
            BoothCheckIn
        GROUP BY 
            EventID,BoothID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.AutoGenerateColumns = false; // since you're adding your own column
                    dataGridView1.DataSource = dt;

                    // Fill the custom column you added manually (e.g., "MyCountColumn")
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        // Pull value from the actual data column
                        var countValue = row.Cells["CheckInCount"].Value;
                        row.Cells["CheckInCount"].Value = countValue;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
