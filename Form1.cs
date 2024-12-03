using System.Diagnostics
using System.Data.SqlClient;


namespace Abdelrahman_mohamed_200709050
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtusername.Text == "Username")
            {
                txtusername.Clear();
            }

        }

        private void txtpasword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpasword.Text == "Password")
            {
                txtpasword.Clear();
                txtpasword.PasswordChar = '*';
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void instabox_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.instagram.com/_abdo_essam/");
        }

        private void ataunibox_Click(object sender, EventArgs e)
        {
            OpenLink("https://atauni.edu.tr/tr/index");

        }

        private void linkedinbox_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.linkedin.com/in/abdo-mo/");

        }
        private void OpenLink(string url)
        {
            try
            {
                // Open the URL in the default browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ensures it opens in the default web browser
                });
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("Failed to open link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
    }
}
