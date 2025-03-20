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

namespace Abdelrahman_mohamed_200709050
{
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string bname = txtBookName.Text.Trim();
            string bauthor = txtAuthorName.Text.Trim();
            string publication = txtPublication.Text.Trim();
            string pdate = dateTimePicker1.Text.Trim();

            // Validate numeric fields (Price and Quantity)
            if (!Int64.TryParse(txtBookPrice.Text.Trim(), out long price) || price < 0)
            {
                MessageBox.Show("Please enter a valid numeric value for Book Price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Int64.TryParse(txtBookQuantity.Text.Trim(), out long quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid numeric value for Book Quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=ABDO_ESSAM\\SQLEXPRESS;Initial Catalog=LibraryAutomation;Integrated Security=True;Encrypt=False"))
                {
                    string query = "INSERT INTO NewBook (bName, bAuthor, bPubl, bPDate, bPrice, bQuan) " +
                                   "VALUES (@bName, @bAuthor, @bPubl, @bPDate, @bPrice, @bQuan)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@bName", bname);
                        cmd.Parameters.AddWithValue("@bAuthor", bauthor);
                        cmd.Parameters.AddWithValue("@bPubl", publication);
                        cmd.Parameters.AddWithValue("@bPDate", pdate);
                        cmd.Parameters.AddWithValue("@bPrice", price);
                        cmd.Parameters.AddWithValue("@bQuan", quantity);

                        // Open connection and execute query
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Show success message and clear fields
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            // Clear all input fields
            txtBookName.Clear();
            txtAuthorName.Clear();
            txtPublication.Clear();
            txtBookPrice.Clear();
            txtBookQuantity.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Confirm cancellation
            if (MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close(); // Close the form
            }

        }

        private void Addbook_Load(object sender, EventArgs e)
        {

        }
    }
}
