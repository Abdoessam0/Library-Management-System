using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Abdelrahman_mohamed_200709050
{
    public partial class Return_Books : Form
    {
        // Database connection string
        string connectionString = "Data Source=ABDO_ESSAM\\SQLEXPRESS;Initial Catalog=LibraryAutomation;Integrated Security=True;Encrypt=False";

        public Return_Books()
        {
            InitializeComponent();
        }

        private void Return_Books_Load(object sender, EventArgs e)
        {
            ClearFields();
            StyleDataGridView();
        }

        // Search student number and display issued books
        private void searchstudentnumberbtn_Click(object sender, EventArgs e)
        {
            string studentNumber = txtboxstudentnumsearch.Text.Trim();

            if (string.IsNullOrEmpty(studentNumber))
            {
                MessageBox.Show("Please enter a student number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT id, book_name, book_issue_date, book_return_date " +
                                   "FROM IRBook WHERE student_number = @studentNumber AND book_return_date IS NULL";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No issued books found for this student number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Populate selected book data into fields
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtupdatebookname.Text = row.Cells["book_name"].Value?.ToString() ?? "";
                dateTimebookissue.Text = row.Cells["book_issue_date"].Value?.ToString() ?? "";
                dateTimePickerretrundate.Value = DateTime.Now;
            }
        }

        // Return the selected book
        private void Returnbuttn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) // Check if a row is selected
            {
                int bookID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                string returnDate = dateTimePickerretrundate.Value.ToString("yyyy-MM-dd");

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string query = "UPDATE IRBook SET book_return_date = @returnDate WHERE id = @bookID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@returnDate", returnDate);
                        cmd.Parameters.AddWithValue("@bookID", bookID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to return the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to return.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Refresh DataGridView after returning a book
        private void RefreshDataGrid()
        {
            string studentNumber = txtboxstudentnumsearch.Text.Trim();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT id, book_name, book_issue_date, book_return_date " +
                                   "FROM IRBook WHERE student_number = @studentNumber AND book_return_date IS NULL";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields()
        {
            txtupdatebookname.Clear();
            dateTimebookissue.ResetText();
            dateTimePickerretrundate.ResetText();
            dataGridView1.DataSource = null;
        }

        // Apply consistent style to DataGridView
        private void StyleDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.GridColor = System.Drawing.Color.LightGray;

            // Enable full row selection
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // Optional: Allow only one row to be selected
        }

        // Placeholder methods (Unchanged)
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtupdatebookname_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimebookissue_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickerretrundate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtboxstudentnumsearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxstudentnumsearch.Text))
            {
                dataGridView1.DataSource = null;
                ClearFields();
            }
        }
    }
}
