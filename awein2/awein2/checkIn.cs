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
    public partial class checkIn : Form
    {
        public checkIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet12.JobFairEvents' table. You can move, or remove it, as needed.
            this.jobFairEventsTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet12.JobFairEvents);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            string studentID = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentID))
            {
                MessageBox.Show("Please enter your Student ID.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;"))
            {
                string query = "SELECT COUNT(*) FROM Students WHERE RollNo = @studentID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentID);

                conn.Open();
                int exists = (int)cmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Student ID verified.");
                    comboBox1.Enabled = true;
                    comboBox1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Student ID not found. Please check and re-enter.");
                    comboBox1.Enabled = false;
                    comboBox1.Enabled = false;
                }
            }

        }
        private void LoadBoothIDs(int eventID)
        {
            string connString = "Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;";
            string query = "SELECT BoothID FROM Booth where EventID=@EventID";
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EventID", eventID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                // Bind CompanyID to comboBox3
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "BoothID"; // What user sees
                comboBox2.ValueMember = "BoothID";     // What you get from comboBox3.SelectedValue
                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList; // Optional: restrict to list
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Your code here or leave empty if not needed yet
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedEventID = 0;
            if (comboBox1.SelectedValue != null)
            {
                selectedEventID = Convert.ToInt32(comboBox1.SelectedValue);
                // Use selectedEventID...
            }
            LoadBoothIDs(selectedEventID);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string studentID = textBox1.Text.Trim();
            int boothID = Convert.ToInt32(comboBox2.SelectedValue);
            int eventID = Convert.ToInt32(comboBox1.SelectedValue); // Assuming comboBox1 holds EventID

            if (string.IsNullOrWhiteSpace(studentID))
            {
                MessageBox.Show("Please enter your Student ID.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;"; // Replace with your actual connection string

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Direct insert since student is already verified
                    string insertQuery = @"
                INSERT INTO BoothCheckIn (studentID, BoothID, EventID)
                VALUES (@StudentID, @BoothID, @EventID)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@StudentID", studentID);
                    insertCmd.Parameters.AddWithValue("@BoothID", boothID);
                    insertCmd.Parameters.AddWithValue("@EventID", eventID);  // Adding EventID

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Check-in successful.");
                    }
                    else
                    {
                        MessageBox.Show("Check-in failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
