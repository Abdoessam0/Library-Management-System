using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing; // For styling
using System.Windows.Forms;

namespace Abdelrahman_mohamed_200709050
{
    public partial class ViewStudnet : Form
    {
        // Database connection string
        private string connectionString = "Data Source=ABDO_ESSAM\\SQLEXPRESS;Initial Catalog=LibraryAutomation;Integrated Security=True;Encrypt=False";

        public ViewStudnet()
        {
            InitializeComponent();
            LoadData(); // Load data on form initialization
            StyleDataGridView(); // Apply styling to the DataGridView
        }

        private void ViewStudnet_Load(object sender, EventArgs e)
        {
            // Optional: Add logic here if needed when form loads
        }

        // Load all student data into the DataGridView
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM NewStudent ORDER BY StudentID ASC";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt; // Bind the data to DataGridView
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        // Style the DataGridView for a better design
        private void StyleDataGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 70);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Search by Student Name, ID, or Student Number
        private void txtsearchstudentname_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtsearchstudentname.Text.Trim();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM NewStudent WHERE StudentName LIKE @search OR StudentID LIKE @search OR StudentNumber LIKE @search";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt; // Refresh data
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        // Delete selected student
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedStudentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            con.Open();
                            string query = "DELETE FROM NewStudent WHERE StudentID = @studentId";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@studentId", selectedStudentId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData(); // Refresh the DataGridView
                            }
                        }
                        catch (Exception ex)
                        {
                            ShowError(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Update Student details (Education Level & Contact)
        private void updatebuttn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedStudentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);
                string newEducationLevel = txtupdateedu.Text.Trim();
                string newStudentContact = txtupdatestudentcontact.Text.Trim();

                if (string.IsNullOrEmpty(newEducationLevel) && string.IsNullOrEmpty(newStudentContact))
                {
                    MessageBox.Show("Please provide a new value for Education Level or Student Contact.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string query = "UPDATE NewStudent SET EducationLevel = @newEdu, StudentContact = @newContact WHERE StudentID = @studentId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@newEdu", newEducationLevel);
                        cmd.Parameters.AddWithValue("@newContact", newStudentContact);
                        cmd.Parameters.AddWithValue("@studentId", selectedStudentId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowError(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Helper method to display errors
        private void ShowError(string message)
        {
            MessageBox.Show("Error: " + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Placeholder Methods
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void txtupdateedu_TextChanged(object sender, EventArgs e) { }
        private void txtupdatestudentcontact_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
