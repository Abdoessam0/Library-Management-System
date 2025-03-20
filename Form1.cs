using System;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Abdelrahman_mohamed_200709050
{
    public partial class Form1 : Form
    {
        // Connection String to connect to SQL Server
        private readonly string connectionString = "Data Source=ABDO_ESSAM\\SQLEXPRESS;Initial Catalog=LibraryAutomation;Integrated Security=True;Encrypt=False";

        public Form1()
        {
            InitializeComponent();
        }

        // Load Event for Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Optionally add a focus or welcome message here
            txtusername.Text = "Username";
            txtpasword.Text = "Password";
        }

        // Clear 'Username' placeholder on click
        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtusername.Text == "Username")
            {
                txtusername.Clear();
            }
        }

        // Clear 'Password' placeholder and mask text on click
        private void txtpasword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpasword.Text == "Password")
            {
                txtpasword.Clear();
                txtpasword.PasswordChar = '*'; // Mask password input
            }
        }

        // Open a hyperlink in the default browser
        private void OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ensures the link opens in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Social Media Links
        private void instabox_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.instagram.com/atauni1957");
        }

        private void ataunibox_Click(object sender, EventArgs e)
        {
            OpenLink("https://atauni.edu.tr/tr/index");
        }

        private void linkedinbox_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.linkedin.com/school/atauni1957");
        }

        // Close the application
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Login Button Click Event
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpasword.Text))
            {
                MessageBox.Show("Please enter both Username and Password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // SQL query to validate username and password
                    string query = "SELECT * FROM loginTable WHERE username = @username AND pass = @password";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtpasword.Text.Trim());

                    // Open connection and execute query
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    // Validate the result
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Empty Event Handlers (Preserved as requested)
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtusername_TextChanged(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
    }
}
