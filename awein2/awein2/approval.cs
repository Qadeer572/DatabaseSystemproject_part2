using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace awein2
{
    public partial class approval : Form
    {
        public approval()
        {
            InitializeComponent();
            LoadPendingUsers();
        }

        private void approval_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'careerConnect_JobFairManagementDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.careerConnect_JobFairManagementDataSet.Users);

        }
        private void LoadPendingUsers()
        {
            string query = "SELECT UserID, Fname, Lname, Email,Password, isApproved FROM Users WHERE isApproved = 0";

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;"))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    Console.WriteLine($"Column: {col.Index} Name: {col.Name}, DataPropertyName: {col.DataPropertyName}");
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["Approve"].Value = false;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ApproveUser(int userId)
        {
            string query = "UPDATE Users SET isApproved = 1 WHERE UserID = @UserID";

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G7PF8EJ;Initial Catalog=CareerConnect_JobFairManagement;Integrated Security=True;"))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                // Check if the 'Approve' checkbox is checked
                var cellValue = row.Cells["Approve"].Value;  // This is the new 'Approve' checkbox column

                // Ensure we safely convert the value to a boolean
                bool approve = cellValue != null && Convert.ToBoolean(cellValue);

                // If approved, update the database's 'isApproved' field for that user
                if (approve)
                {
                    int userId = Convert.ToInt32(row.Cells["userIDDataGridViewTextBoxColumn"].Value);  // Get the UserID from the row
                    ApproveUser(userId);  // Call the method to update the approval status in the database
                }
            }


            LoadPendingUsers();  // Reload the grid to reflect the changes

            MessageBox.Show("Selected users have been approved.");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

