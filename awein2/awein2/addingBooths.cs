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
    public partial class addingBooths : Form
    {
        public addingBooths()
        {
            InitializeComponent();
        }

        private void addingBooths_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet11.JobFairEvents' table. You can move, or remove it, as needed.
            this.jobFairEventsTableAdapter1.Fill(this.careerConnect_JobFairManagementDataSet11.JobFairEvents);
            string connString = "Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT EventID FROM JobFairEvents", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind to ComboBox
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "EventID"; // what user sees
                    comboBox1.ValueMember = "EventID";   // what you get when calling SelectedValue
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading events: " + ex.Message);
                }
            }

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an Event.");
                return;
            }

            int eventID;
            try
            {
                eventID = Convert.ToInt32(comboBox1.SelectedValue);
            }
            catch
            {
                MessageBox.Show("Please select a valid Event.");
                return;
            }

            int numberOfBooths = (int)numericUpDown1.Value;

            if (numberOfBooths <= 0)
            {
                MessageBox.Show("Number of booths must be greater than zero.");
                return;
            }

            string connStr = "Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                for (int i = 1; i <= numberOfBooths; i++)
                {
                    string insertQuery = @"INSERT INTO Booth (EventID, TotalCapacity, Location)
                                   VALUES (@EventID, @TotalCapacity, @Location)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@EventID", eventID);
                        cmd.Parameters.AddWithValue("@TotalCapacity", 10); // default capacity
                        cmd.Parameters.AddWithValue("@Location", DBNull.Value); // insert NULL for location

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"{numberOfBooths} booths added successfully for Event ID {eventID}.");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
