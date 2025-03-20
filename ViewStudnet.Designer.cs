namespace Abdelrahman_mohamed_200709050
{
    partial class ViewStudnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudnet));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            deletebtn = new Button();
            txtsearchstudentname = new TextBox();
            txtupdatestudentcontact = new TextBox();
            txtupdateedu = new TextBox();
            updatebuttn = new Button();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 98);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(522, 20);
            label1.Name = "label1";
            label1.Size = new Size(85, 81);
            label1.TabIndex = 1;
            label1.Text = "View \r\nStudent\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(276, -17);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 316);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(931, 218);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 146);
            label2.Name = "label2";
            label2.Size = new Size(326, 23);
            label2.TabIndex = 2;
            label2.Text = "Search Student name / Student Number";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 237);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 8;
            label3.Text = "Delete Studnet";
            label3.Click += label3_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(189, 230);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(136, 39);
            deletebtn.TabIndex = 7;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // txtsearchstudentname
            // 
            txtsearchstudentname.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtsearchstudentname.Location = new Point(62, 170);
            txtsearchstudentname.Name = "txtsearchstudentname";
            txtsearchstudentname.Size = new Size(255, 27);
            txtsearchstudentname.TabIndex = 9;
            txtsearchstudentname.TextChanged += txtsearchstudentname_TextChanged;
            // 
            // txtupdatestudentcontact
            // 
            txtupdatestudentcontact.Location = new Point(595, 239);
            txtupdatestudentcontact.Name = "txtupdatestudentcontact";
            txtupdatestudentcontact.Size = new Size(176, 23);
            txtupdatestudentcontact.TabIndex = 14;
            txtupdatestudentcontact.TextChanged += txtupdatestudentcontact_TextChanged;
            // 
            // txtupdateedu
            // 
            txtupdateedu.Location = new Point(595, 153);
            txtupdateedu.Name = "txtupdateedu";
            txtupdateedu.Size = new Size(176, 23);
            txtupdateedu.TabIndex = 13;
            txtupdateedu.TextChanged += txtupdateedu_TextChanged;
            // 
            // updatebuttn
            // 
            updatebuttn.Location = new Point(785, 188);
            updatebuttn.Name = "updatebuttn";
            updatebuttn.Size = new Size(136, 39);
            updatebuttn.TabIndex = 12;
            updatebuttn.Text = "Update";
            updatebuttn.UseVisualStyleBackColor = true;
            updatebuttn.Click += updatebuttn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label6.Location = new Point(383, 150);
            label6.Name = "label6";
            label6.Size = new Size(192, 23);
            label6.TabIndex = 17;
            label6.Text = "Update Education level";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label5.Location = new Point(383, 237);
            label5.Name = "label5";
            label5.Size = new Size(200, 23);
            label5.TabIndex = 18;
            label5.Text = "Update Student Contact";
            // 
            // ViewStudnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(952, 542);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtupdatestudentcontact);
            Controls.Add(txtupdateedu);
            Controls.Add(updatebuttn);
            Controls.Add(txtsearchstudentname);
            Controls.Add(label3);
            Controls.Add(deletebtn);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewStudnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Student ";
            Load += ViewStudnet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Button deletebtn;
        private TextBox txtsearchstudentname;
        private TextBox txtupdatestudentcontact;
        private TextBox txtupdateedu;
        private Button updatebuttn;
        private Label label6;
        private Label label5;
    }
}