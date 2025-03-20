using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Abdelrahman_mohamed_200709050
{
    public partial class IssueBooks : Form
    {
        private string connectionString = "Data Source=ABDO_ESSAM\\SQLEXPRESS;Initial Catalog=LibraryAutomation;Integrated Security=True;Encrypt=False";

        public IssueBooks()
        {
            InitializeComponent();
            LoadBookNames(); // Populate the book names into the comboBox
        }

        // Populate the book names from NewBook table into comboBox
        private void LoadBookNames()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT bName FROM NewBook";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    comboBoxbookname.Items.Clear();

                    while (reader.Read())
                    {
                        comboBoxbookname.Items.Add(reader["bName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading book names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Search for student details by student_number
        private void searchstudentnumberbtn_Click(object sender, EventArgs e)
        {
            string studentNumber = textBoxstudentnumbersearch.Text.Trim();

            if (string.IsNullOrEmpty(studentNumber))
            {
                MessageBox.Show("Please enter a student number to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT StudentName, Department, EducationLevel, StudentContact FROM NewStudent WHERE StudentNumber = @studentNumber";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtstudentname.Text = reader["StudentName"].ToString();
                        txtdepartment.Text = reader["Department"].ToString();
                        txtedu.Text = reader["EducationLevel"].ToString();
                        txtstudentcontact.Text = reader["StudentContact"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No student found with this number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Issue book to a student
        private void issuebookbtn_Click(object sender, EventArgs e)
        {
            string studentNumber = textBoxstudentnumbersearch.Text.Trim();
            string studentName = txtstudentname.Text.Trim();
            string bookName = comboBoxbookname.Text.Trim();
            string issueDate = dateTimebookissue.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(studentNumber) || string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(bookName))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Check if the student has already issued 3 books
                    string countQuery = "SELECT COUNT(*) FROM IRBook WHERE student_number = @studentNumber AND book_return_date IS NULL";
                    SqlCommand countCmd = new SqlCommand(countQuery, con);
                    countCmd.Parameters.AddWithValue("@studentNumber", studentNumber);

                    int issuedBooks = (int)countCmd.ExecuteScalar();
                    if (issuedBooks >= 3)
                    {
                        MessageBox.Show("This student has already issued the maximum of 3 books.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert the issued book into IRBook table
                    string insertQuery = "INSERT INTO IRBook (student_number, std_name, std_dep, std_contact, book_name, book_issue_date, book_return_date) " +
                                         "VALUES (@studentNumber, @studentName, @department, @contact, @bookName, @issueDate, NULL)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                    insertCmd.Parameters.AddWithValue("@studentName", studentName);
                    insertCmd.Parameters.AddWithValue("@department", txtdepartment.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@contact", txtstudentcontact.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@bookName", bookName);
                    insertCmd.Parameters.AddWithValue("@issueDate", issueDate);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Book issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Clear all fields when the search box is cleared
        private void textBoxstudentnumbersearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxstudentnumbersearch.Text.Trim()))
            {
                ClearFields();
            }
        }

        // Helper method to clear all fields
        private void ClearFields()
        {
            txtstudentname.Clear();
            txtdepartment.Clear();
            txtedu.Clear();
            txtstudentcontact.Clear();
            comboBoxbookname.SelectedIndex = -1;
        }

        private void txtstudentname_TextChanged(object sender, EventArgs e) { }
        private void txtdepartment_TextChanged(object sender, EventArgs e) { }
        private void txtedu_TextChanged(object sender, EventArgs e) { }
        private void txtstudentcontact_TextChanged(object sender, EventArgs e) { }
        private void comboBoxbookname_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimebookissue_ValueChanged(object sender, EventArgs e) { }
    }
}
