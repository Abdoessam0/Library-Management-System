namespace Abdelrahman_mohamed_200709050
{
    partial class Return_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return_Books));
            searchstudentnumberbtn = new Button();
            label2 = new Label();
            panel2 = new Panel();
            txtboxstudentnumsearch = new TextBox();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            Returnbuttn = new Button();
            dateTimePickerretrundate = new DateTimePicker();
            dateTimebookissue = new DateTimePicker();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtupdatebookname = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchstudentnumberbtn
            // 
            searchstudentnumberbtn.FlatStyle = FlatStyle.Popup;
            searchstudentnumberbtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchstudentnumberbtn.Location = new Point(60, 208);
            searchstudentnumberbtn.Margin = new Padding(3, 2, 3, 2);
            searchstudentnumberbtn.Name = "searchstudentnumberbtn";
            searchstudentnumberbtn.Size = new Size(121, 47);
            searchstudentnumberbtn.TabIndex = 6;
            searchstudentnumberbtn.Text = "Search student";
            searchstudentnumberbtn.UseVisualStyleBackColor = true;
            searchstudentnumberbtn.Click += searchstudentnumberbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 135);
            label2.Name = "label2";
            label2.Size = new Size(165, 19);
            label2.TabIndex = 4;
            label2.Text = "Enter Student Number";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(txtboxstudentnumsearch);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(searchstudentnumberbtn);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 11);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 368);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // txtboxstudentnumsearch
            // 
            txtboxstudentnumsearch.Location = new Point(46, 166);
            txtboxstudentnumsearch.Name = "txtboxstudentnumsearch";
            txtboxstudentnumsearch.Size = new Size(149, 23);
            txtboxstudentnumsearch.TabIndex = 11;
            txtboxstudentnumsearch.TextChanged += txtboxstudentnumsearch_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 34);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Location = new Point(270, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(651, 357);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(Returnbuttn);
            panel1.Controls.Add(dateTimePickerretrundate);
            panel1.Controls.Add(dateTimebookissue);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtupdatebookname);
            panel1.Location = new Point(275, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 206);
            panel1.TabIndex = 9;
            // 
            // Returnbuttn
            // 
            Returnbuttn.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Returnbuttn.Location = new Point(449, 35);
            Returnbuttn.Name = "Returnbuttn";
            Returnbuttn.Size = new Size(136, 50);
            Returnbuttn.TabIndex = 28;
            Returnbuttn.Text = "Return";
            Returnbuttn.UseVisualStyleBackColor = true;
            Returnbuttn.Click += Returnbuttn_Click;
            // 
            // dateTimePickerretrundate
            // 
            dateTimePickerretrundate.Location = new Point(224, 122);
            dateTimePickerretrundate.Name = "dateTimePickerretrundate";
            dateTimePickerretrundate.Size = new Size(191, 23);
            dateTimePickerretrundate.TabIndex = 27;
            dateTimePickerretrundate.ValueChanged += dateTimePickerretrundate_ValueChanged;
            // 
            // dateTimebookissue
            // 
            dateTimebookissue.Location = new Point(225, 82);
            dateTimebookissue.Name = "dateTimebookissue";
            dateTimebookissue.Size = new Size(190, 23);
            dateTimebookissue.TabIndex = 26;
            dateTimebookissue.ValueChanged += dateTimebookissue_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label1.Location = new Point(37, 82);
            label1.Name = "label1";
            label1.Size = new Size(143, 23);
            label1.TabIndex = 25;
            label1.Text = "Book Isuue Date ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label5.Location = new Point(37, 122);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 23;
            label5.Text = "Book Retrun Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label6.Location = new Point(37, 35);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 22;
            label6.Text = "Book Name";
            // 
            // txtupdatebookname
            // 
            txtupdatebookname.Location = new Point(225, 35);
            txtupdatebookname.Name = "txtupdatebookname";
            txtupdatebookname.Size = new Size(190, 23);
            txtupdatebookname.TabIndex = 20;
            txtupdatebookname.TextChanged += txtupdatebookname_TextChanged;
            // 
            // Return_Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(962, 593);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "Return_Books";
            Text = "Return_Books";
            Load += Return_Books_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button searchstudentnumberbtn;
        private Label label2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private TextBox txtupdatebookname;
        private Label label1;
        private DateTimePicker dateTimebookissue;
        private DateTimePicker dateTimePickerretrundate;
        private Button Returnbuttn;
        private TextBox txtboxstudentnumsearch;
    }
}