namespace Abdelrahman_mohamed_200709050
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            searchstudentnumberbtn = new Button();
            textBoxstudentnumbersearch = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            comboBoxbookname = new ComboBox();
            label9 = new Label();
            issuebookbtn = new Button();
            dateTimebookissue = new DateTimePicker();
            label8 = new Label();
            txtstudentcontact = new TextBox();
            txtedu = new TextBox();
            txtdepartment = new TextBox();
            txtstudentname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(4, 5);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 106);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(400, 42);
            label1.Name = "label1";
            label1.Size = new Size(120, 27);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(173, -25);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(searchstudentnumberbtn);
            panel2.Controls.Add(textBoxstudentnumbersearch);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(4, 118);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 368);
            panel2.TabIndex = 1;
            // 
            // searchstudentnumberbtn
            // 
            searchstudentnumberbtn.FlatStyle = FlatStyle.Popup;
            searchstudentnumberbtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchstudentnumberbtn.Location = new Point(66, 174);
            searchstudentnumberbtn.Margin = new Padding(3, 2, 3, 2);
            searchstudentnumberbtn.Name = "searchstudentnumberbtn";
            searchstudentnumberbtn.Size = new Size(116, 33);
            searchstudentnumberbtn.TabIndex = 3;
            searchstudentnumberbtn.Text = "Search student";
            searchstudentnumberbtn.UseVisualStyleBackColor = true;
            searchstudentnumberbtn.Click += searchstudentnumberbtn_Click;
            // 
            // textBoxstudentnumbersearch
            // 
            textBoxstudentnumbersearch.Location = new Point(10, 139);
            textBoxstudentnumbersearch.Margin = new Padding(3, 2, 3, 2);
            textBoxstudentnumbersearch.Name = "textBoxstudentnumbersearch";
            textBoxstudentnumbersearch.Size = new Size(213, 23);
            textBoxstudentnumbersearch.TabIndex = 2;
            textBoxstudentnumbersearch.TextChanged += textBoxstudentnumbersearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 111);
            label2.Name = "label2";
            label2.Size = new Size(165, 19);
            label2.TabIndex = 1;
            label2.Text = "Enter Student Number";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 20);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.PaleTurquoise;
            panel3.Controls.Add(comboBoxbookname);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(issuebookbtn);
            panel3.Controls.Add(dateTimebookissue);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtstudentcontact);
            panel3.Controls.Add(txtedu);
            panel3.Controls.Add(txtdepartment);
            panel3.Controls.Add(txtstudentname);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(251, 118);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 368);
            panel3.TabIndex = 2;
            // 
            // comboBoxbookname
            // 
            comboBoxbookname.FormattingEnabled = true;
            comboBoxbookname.Location = new Point(235, 239);
            comboBoxbookname.Margin = new Padding(3, 2, 3, 2);
            comboBoxbookname.Name = "comboBoxbookname";
            comboBoxbookname.Size = new Size(208, 23);
            comboBoxbookname.TabIndex = 25;
            comboBoxbookname.SelectedIndexChanged += comboBoxbookname_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(17, 339);
            label9.Name = "label9";
            label9.Size = new Size(256, 17);
            label9.TabIndex = 24;
            label9.Text = "Maximum 3 books are issued per student.";
            // 
            // issuebookbtn
            // 
            issuebookbtn.FlatStyle = FlatStyle.Popup;
            issuebookbtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issuebookbtn.Location = new Point(311, 320);
            issuebookbtn.Margin = new Padding(3, 2, 3, 2);
            issuebookbtn.Name = "issuebookbtn";
            issuebookbtn.Size = new Size(162, 36);
            issuebookbtn.TabIndex = 23;
            issuebookbtn.Text = "Issue book";
            issuebookbtn.UseVisualStyleBackColor = true;
            issuebookbtn.Click += issuebookbtn_Click;
            // 
            // dateTimebookissue
            // 
            dateTimebookissue.Location = new Point(235, 282);
            dateTimebookissue.Margin = new Padding(3, 2, 3, 2);
            dateTimebookissue.Name = "dateTimebookissue";
            dateTimebookissue.Size = new Size(208, 23);
            dateTimebookissue.TabIndex = 22;
            dateTimebookissue.ValueChanged += dateTimebookissue_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label8.Location = new Point(64, 282);
            label8.Name = "label8";
            label8.Size = new Size(141, 23);
            label8.TabIndex = 21;
            label8.Text = "Book Issue Date ";
            // 
            // txtstudentcontact
            // 
            txtstudentcontact.Location = new Point(235, 188);
            txtstudentcontact.Name = "txtstudentcontact";
            txtstudentcontact.Size = new Size(208, 23);
            txtstudentcontact.TabIndex = 20;
            txtstudentcontact.TextChanged += txtstudentcontact_TextChanged;
            // 
            // txtedu
            // 
            txtedu.Location = new Point(235, 132);
            txtedu.Name = "txtedu";
            txtedu.Size = new Size(208, 23);
            txtedu.TabIndex = 19;
            txtedu.TextChanged += txtedu_TextChanged;
            // 
            // txtdepartment
            // 
            txtdepartment.Location = new Point(235, 70);
            txtdepartment.Name = "txtdepartment";
            txtdepartment.Size = new Size(208, 23);
            txtdepartment.TabIndex = 18;
            txtdepartment.TextChanged += txtdepartment_TextChanged;
            // 
            // txtstudentname
            // 
            txtstudentname.Location = new Point(235, 20);
            txtstudentname.Name = "txtstudentname";
            txtstudentname.Size = new Size(208, 23);
            txtstudentname.TabIndex = 16;
            txtstudentname.TextChanged += txtstudentname_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label6.Location = new Point(60, 188);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 15;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label5.Location = new Point(60, 129);
            label5.Name = "label5";
            label5.Size = new Size(130, 23);
            label5.TabIndex = 14;
            label5.Text = "Education level";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label4.Location = new Point(60, 70);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 13;
            label4.Text = "Depatment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label3.Location = new Point(64, 239);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 12;
            label3.Text = "Book Name ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(60, 17);
            label7.Name = "label7";
            label7.Size = new Size(124, 23);
            label7.TabIndex = 11;
            label7.Text = "Student Name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(752, 486);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IssueBooks";
            Text = "IssueBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Button searchstudentnumberbtn;
        private TextBox textBoxstudentnumbersearch;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label9;
        private Button issuebookbtn;
        private DateTimePicker dateTimebookissue;
        private Label label8;
        private TextBox txtstudentcontact;
        private TextBox txtedu;
        private TextBox txtdepartment;
        private TextBox txtstudentname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private ComboBox comboBoxbookname;
    }
}