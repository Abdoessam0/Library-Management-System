using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Abdelrahman_mohamed_200709050
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SetupDashboard(); // Initialize improved UI
            AddStatusBar();   // Add a status bar for additional info
        }

        // Method to improve the overall UI of the Dashboard
        private void SetupDashboard()
        {
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.FromArgb(100, 0, 0, 0) // Semi-transparent background
            };

            Label welcomeLabel = new Label
            {
                Text = "Welcome to Library Management System",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            headerPanel.Controls.Add(welcomeLabel);
            this.Controls.Add(headerPanel);

            // Center the label within the header panel
            welcomeLabel.Left = (headerPanel.Width - welcomeLabel.PreferredWidth) / 2;
            welcomeLabel.Top = (headerPanel.Height - welcomeLabel.Height) / 2;

            // Bring the panel and label to front
            headerPanel.BringToFront();
        }


        // Method to add a Status Bar at the bottom of the form
        private void AddStatusBar()
        {
            StatusStrip statusStrip = new StatusStrip();
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel
            {
                Text = "Ready",
                ForeColor = Color.DarkBlue
            };

            statusStrip.Items.Add(statusLabel);
            this.Controls.Add(statusStrip);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application if the user confirms
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addbook abs = new Addbook();
            abs.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook abs = new ViewBook();
            abs.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent abs = new AddStudent();
            abs.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewStudnet abs = new ViewStudnet();
            abs.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks abs = new IssueBooks();
            abs.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Books abs = new Return_Books();
            abs.Show();
        }

        private void compToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Complete_Book_Details abs = new Complete_Book_Details();
            abs.Show();
        }
    }
}
