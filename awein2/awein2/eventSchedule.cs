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
    public partial class eventSchedule : Form
    {
        public eventSchedule()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            // Reset numeric values
            numericUpDown1.Value = 0; // Event ID
            numericUpDown2.Value = 0; // Number of Staff
            numericUpDown3.Value = 0; // Total Capacity

            // Clear venue textbox
            textBox9.Text = string.Empty;

            // Reset date to today
            dateTimePicker1.Value = DateTime.Today; // Event Date

            // Reset time pickers to current time
            dateTimePicker2.Value = DateTime.Now; // Starting Time
            dateTimePicker3.Value = DateTime.Now; // Ending Time
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eventID = (int)numericUpDown1.Value;
            string venue = textBox9.Text.Trim();
            DateTime eventDate = dateTimePicker1.Value.Date;
            int noOfStaff = (int)numericUpDown2.Value;
            int totalCapacity = (int)numericUpDown3.Value;
            string startTime = dateTimePicker2.Value.ToString("HH:mm:ss");
            string endTime = dateTimePicker3.Value.ToString("HH:mm:ss");

            // === VALIDATION ===
            if (string.IsNullOrWhiteSpace(venue))
            {
                MessageBox.Show("Please enter the venue.");
                return;
            }

            if (eventDate < DateTime.Today)
            {
                MessageBox.Show("Event date cannot be in the past.");
                return;
            }

            if (noOfStaff <= 0 || totalCapacity <= 0)
            {
                MessageBox.Show("Number of staff and total capacity must be greater than zero.");
                return;
            }

            if (TimeSpan.Parse(startTime) >= TimeSpan.Parse(endTime))
            {
                MessageBox.Show("Start time must be earlier than end time.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;"))
            {
                try
                {
                    conn.Open(); 

                    // === CHECK IF EventID ALREADY EXISTS ===
                    string checkQuery = "SELECT COUNT(*) FROM JobFairEvents WHERE EventID = @EventID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@EventID", eventID);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This Event ID already exists. Please choose a different ID.");
                            return;
                        }
                    }

                    // === INSERTION ===
                    string query = @"INSERT INTO JobFairEvents 
                    (EventID, Venue, EventDate, NoOfStaff, TotalCapacity, StartTime, EndTime) 
                    VALUES 
                    (@EventID, @Venue, @EventDate, @NoOfStaff, @TotalCapacity, @StartTime, @EndTime)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EventID", eventID);
                        cmd.Parameters.AddWithValue("@Venue", venue);
                        cmd.Parameters.AddWithValue("@EventDate", eventDate);
                        cmd.Parameters.AddWithValue("@NoOfStaff", noOfStaff);
                        cmd.Parameters.AddWithValue("@TotalCapacity", totalCapacity);
                        cmd.Parameters.AddWithValue("@StartTime", startTime);
                        cmd.Parameters.AddWithValue("@EndTime", endTime);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Job Fair Event added successfully!");
                            ClearForm();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add event.");
                        }
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
