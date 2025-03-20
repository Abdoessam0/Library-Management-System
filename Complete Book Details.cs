using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Abdelrahman_mohamed_200709050
{
    public partial class Complete_Book_Details : Form
    {
        // Database connection string
        string connectionString = "Data Source=ABDO_ESSAM\\SQLEXPRESS;Initial Catalog=LibraryAutomation;Integrated Security=True;Encrypt=False";

        public Complete_Book_Details()
        {
            InitializeComponent();
        }

        // Form load event to load issued and returned books
        private void Complete_Book_Details_Load(object sender, EventArgs e)
        {
            LoadIssuedBooks();
            LoadReturnedBooks();
            StyleDataGridView(dataGridViewIssuedBooks);
            StyleDataGridView(dataGridViewReturnedbooks);
        }

        // Method to load issued books (books not returned)
        private void LoadIssuedBooks()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT id, student_number AS 'Student Number', std_name AS 'Student Name', " +
                                   "book_name AS 'Book Name', book_issue_date AS 'Issue Date' " +
                                   "FROM IRBook WHERE book_return_date IS NULL";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewIssuedBooks.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading issued books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to load returned books
        private void LoadReturnedBooks()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT id, student_number AS 'Student Number', std_name AS 'Student Name', " +
                                   "book_name AS 'Book Name', book_issue_date AS 'Issue Date', " +
                                   "book_return_date AS 'Return Date' " +
                                   "FROM IRBook WHERE book_return_date IS NOT NULL";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewReturnedbooks.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading returned books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Apply styling to the DataGridView
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.GridColor = System.Drawing.Color.LightGray;
        }

        private void dataGridViewIssuedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional functionality when a cell is clicked in issued books grid
        }

        private void dataGridViewReturnedbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional functionality when a cell is clicked in returned books grid
        }
    }
}

