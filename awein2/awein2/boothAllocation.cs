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
    public partial class boothAllocation : Form
    {
        public boothAllocation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boothAllocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet4.BoothCoordinators' table. You can move, or remove it, as needed.
            this.boothCoordinatorsTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet4.BoothCoordinators);
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet3.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet3.Company);
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet2.JobFairEvents' table. You can move, or remove it, as needed.
            this.jobFairEventsTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet2.JobFairEvents);
            LoadEventIDs();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null ||
                comboBox3.SelectedValue == null || comboBox4.SelectedValue == null)
            {
                MessageBox.Show("Please make sure all selections are made.");
                return;
            }

            int eventId = Convert.ToInt32(comboBox1.SelectedValue);
            int boothId = Convert.ToInt32(comboBox2.SelectedValue);
            int companyId = Convert.ToInt32(comboBox3.SelectedValue);
            int coordinatorId = Convert.ToInt32(comboBox4.SelectedValue);

            string connStr = "Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Check if either BoothID or CompanyID already exists
                    string checkQuery = @"SELECT COUNT(*) FROM BoothAllocation 
                                  WHERE BoothID = @BoothID OR CompanyID = @CompanyID";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@BoothID", boothId);
                        checkCmd.Parameters.AddWithValue("@CompanyID", companyId);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This booth or company has already been allocated. Please choose a different combination.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Proceed to insert
                    string insertQuery = @"INSERT INTO BoothAllocation (EventID, BoothID, CoordinatorID, CompanyID)
                                   VALUES (@EventID, @BoothID, @CoordinatorID, @CompanyID)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@EventID", eventId);
                        cmd.Parameters.AddWithValue("@BoothID", boothId);
                        cmd.Parameters.AddWithValue("@CoordinatorID", coordinatorId);
                        cmd.Parameters.AddWithValue("@CompanyID", companyId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Booth allocation successful!");

                            // Mark the coordinator as unavailable
                            string updateCoordinator = "UPDATE BoothCoordinators SET IsAvailable = 1 WHERE CoordinatorID = @CoordinatorID";
                            SqlCommand updateCmd = new SqlCommand(updateCoordinator, conn);
                            updateCmd.Parameters.AddWithValue("@CoordinatorID", coordinatorId);
                            updateCmd.ExecuteNonQuery();

                            // Refresh coordinator list
                            LoadCoordinatorIDs();
                        }
                        else
                        {
                            MessageBox.Show("Failed to allocate booth.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void LoadJobsForEvent(int eventId)
        {
            string query = "SELECT distinct c.CompanyID, c.CompanyName FROM JobPosting jp INNER JOIN Company c ON jp.CompanyID = c.CompanyID WHERE jp.EventID = @EventID";

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EventID", eventId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind to DataGridView
                dataGridView2.DataSource = dt;

                // Bind CompanyID to comboBox3
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "CompanyID"; // What user sees
                comboBox3.ValueMember = "CompanyID";     // What you get from comboBox3.SelectedValue
                comboBox3.DropDownStyle = ComboBoxStyle.DropDownList; // Optional: restrict to list
            }
        }

        private void LoadEventIDs()
        {
            string connString = "Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT EventID FROM JobFairEvents";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBox1.DisplayMember = "EventID";
                    comboBox1.ValueMember = "EventID";
                    comboBox1.DataSource = dt;
                    comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading events: " + ex.Message);
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

        private void LoadCoordinatorIDs()
        {
            string connString = "Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;";
            string query = "SELECT CoordinatorID FROM BoothCoordinators where isAvailable=0";
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind CompanyID to comboBox3
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "CoordinatorID"; // What user sees
                comboBox4.ValueMember = "CoordinatorID";     // What you get from comboBox3.SelectedValue
                comboBox4.DropDownStyle = ComboBoxStyle.DropDownList; // Optional: restrict to list
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedEventID=0;
            if (comboBox1.SelectedValue != null)
            {
                 selectedEventID = Convert.ToInt32(comboBox1.SelectedValue);
                // Use selectedEventID...
            }


            LoadJobsForEvent(selectedEventID);
            LoadBoothIDs(selectedEventID);
            LoadCoordinatorIDs();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
