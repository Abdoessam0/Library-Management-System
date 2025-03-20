namespace Abdelrahman_mohamed_200709050
{
    partial class Complete_Book_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridViewIssuedBooks = new DataGridView();
            label2 = new Label();
            dataGridViewReturnedbooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIssuedBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturnedbooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(492, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 29);
            label1.TabIndex = 0;
            label1.Text = "Issued Books";
            // 
            // dataGridViewIssuedBooks
            // 
            dataGridViewIssuedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIssuedBooks.Location = new Point(42, 56);
            dataGridViewIssuedBooks.Name = "dataGridViewIssuedBooks";
            dataGridViewIssuedBooks.Size = new Size(1036, 279);
            dataGridViewIssuedBooks.TabIndex = 1;
            dataGridViewIssuedBooks.CellClick += dataGridViewIssuedBooks_CellContentClick;
            dataGridViewIssuedBooks.CellContentClick += dataGridViewIssuedBooks_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(462, 367);
            label2.Name = "label2";
            label2.Size = new Size(173, 29);
            label2.TabIndex = 2;
            label2.Text = "Retruned Books";
            // 
            // dataGridViewReturnedbooks
            // 
            dataGridViewReturnedbooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReturnedbooks.Location = new Point(42, 416);
            dataGridViewReturnedbooks.Name = "dataGridViewReturnedbooks";
            dataGridViewReturnedbooks.Size = new Size(1036, 279);
            dataGridViewReturnedbooks.TabIndex = 3;
            dataGridViewReturnedbooks.CellClick += dataGridViewReturnedbooks_CellContentClick;
            dataGridViewReturnedbooks.CellContentClick += dataGridViewReturnedbooks_CellContentClick;
            // 
            // Complete_Book_Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1124, 755);
            Controls.Add(dataGridViewReturnedbooks);
            Controls.Add(label2);
            Controls.Add(dataGridViewIssuedBooks);
            Controls.Add(label1);
            Name = "Complete_Book_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Complete_Book_Details_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIssuedBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturnedbooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewIssuedBooks;
        private Label label2;
        private DataGridView dataGridViewReturnedbooks;
    }
}