using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Abdelrahman_mohamed_200709050
{
    public partial class AddStudent : Form
    {
        // Connection string to the database
        private string connectionString = "Data Source=ABDO_ESSAM\\SQLEXPRESS;Initial Catalog=LibraryAutomation;Integrated Security=True;Encrypt=False";

        public AddStudent()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Placeholder for label3 click event
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Placeholder for label2 click event
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Placeholder for label6 click event
        }

        private void CANCELBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close(); // Close the form
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            // Get values from the input fields
            string studentName = txtstudentname.Text.Trim();
            string studentNumber = txtstudentnumber.Text.Trim();
            string department = txtdepartment.Text.Trim();
            string educationLevel = txtedu.Text.Trim();
            string studentContact = txtstudentcontact.Text.Trim();

            // Validate that all required fields are filled
            if (string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(studentNumber) ||
                string.IsNullOrEmpty(department) || string.IsNullOrEmpty(educationLevel) || string.IsNullOrEmpty(studentContact))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           /* // Validate Student Contact (assuming phone number)
            if (!long.TryParse(studentContact, out _) || studentContact.Length != 11)
            {
                MessageBox.Show("Please enter a valid 11-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            try
            {
                // Connect to the database
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Ensure StudentNumber is unique
                    string checkQuery = "SELECT COUNT(*) FROM NewStudent WHERE StudentNumber = @StudentNumber";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This Student Number already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert data into NewStudent table
                    string query = "INSERT INTO NewStudent (StudentName, StudentNumber, Department, EducationLevel, StudentContact) " +
                                   "VALUES (@StudentName, @StudentNumber, @Department, @EducationLevel, @StudentContact)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@StudentName", studentName);
                        cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        cmd.Parameters.AddWithValue("@Department", department);
                        cmd.Parameters.AddWithValue("@EducationLevel", educationLevel);
                        cmd.Parameters.AddWithValue("@StudentContact", studentContact);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                }

                // Show success message and clear input fields
                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("An error occurred while saving the student data. Please try again later.\nDetails: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            // Clear all input fields
            txtstudentname.Clear();
            txtstudentnumber.Clear();
            txtdepartment.Clear();
            txtedu.Clear();
            txtstudentcontact.Clear();
          //  TxtstudentID.Clear();
        }
    }
}
