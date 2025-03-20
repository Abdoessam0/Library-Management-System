namespace Abdelrahman_mohamed_200709050
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            CANCELBTN = new Button();
            Savebtn = new Button();
            txtstudentcontact = new TextBox();
            txtedu = new TextBox();
            txtdepartment = new TextBox();
            txtstudentnumber = new TextBox();
            txtstudentname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 89);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(371, 33);
            label1.Name = "label1";
            label1.Size = new Size(152, 33);
            label1.TabIndex = 1;
            label1.Text = "Add Student";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(250, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 88);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 531);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(CANCELBTN);
            panel2.Controls.Add(Savebtn);
            panel2.Controls.Add(txtstudentcontact);
            panel2.Controls.Add(txtedu);
            panel2.Controls.Add(txtdepartment);
            panel2.Controls.Add(txtstudentnumber);
            panel2.Controls.Add(txtstudentname);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(262, 88);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 531);
            panel2.TabIndex = 1;
            // 
            // CANCELBTN
            // 
            CANCELBTN.Location = new Point(280, 436);
            CANCELBTN.Margin = new Padding(3, 4, 3, 4);
            CANCELBTN.Name = "CANCELBTN";
            CANCELBTN.Size = new Size(131, 39);
            CANCELBTN.TabIndex = 13;
            CANCELBTN.Text = "Cancel";
            CANCELBTN.UseVisualStyleBackColor = true;
            CANCELBTN.Click += CANCELBTN_Click;
            // 
            // Savebtn
            // 
            Savebtn.Location = new Point(64, 436);
            Savebtn.Margin = new Padding(3, 4, 3, 4);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(110, 43);
            Savebtn.TabIndex = 12;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            Savebtn.Click += Savebtn_Click;
            // 
            // txtstudentcontact
            // 
            txtstudentcontact.Location = new Point(234, 355);
            txtstudentcontact.Margin = new Padding(3, 4, 3, 4);
            txtstudentcontact.Name = "txtstudentcontact";
            txtstudentcontact.Size = new Size(177, 27);
            txtstudentcontact.TabIndex = 10;
            // 
            // txtedu
            // 
            txtedu.Location = new Point(234, 281);
            txtedu.Margin = new Padding(3, 4, 3, 4);
            txtedu.Name = "txtedu";
            txtedu.Size = new Size(177, 27);
            txtedu.TabIndex = 9;
            // 
            // txtdepartment
            // 
            txtdepartment.Location = new Point(234, 198);
            txtdepartment.Margin = new Padding(3, 4, 3, 4);
            txtdepartment.Name = "txtdepartment";
            txtdepartment.Size = new Size(177, 27);
            txtdepartment.TabIndex = 8;
            // 
            // txtstudentnumber
            // 
            txtstudentnumber.Location = new Point(234, 129);
            txtstudentnumber.Margin = new Padding(3, 4, 3, 4);
            txtstudentnumber.Name = "txtstudentnumber";
            txtstudentnumber.Size = new Size(177, 27);
            txtstudentnumber.TabIndex = 7;
            // 
            // txtstudentname
            // 
            txtstudentname.Location = new Point(234, 51);
            txtstudentname.Margin = new Padding(3, 4, 3, 4);
            txtstudentname.Name = "txtstudentname";
            txtstudentname.Size = new Size(177, 27);
            txtstudentname.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label6.Location = new Point(34, 355);
            label6.Name = "label6";
            label6.Size = new Size(173, 29);
            label6.TabIndex = 4;
            label6.Text = "Student Contact";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label5.Location = new Point(34, 277);
            label5.Name = "label5";
            label5.Size = new Size(165, 29);
            label5.TabIndex = 3;
            label5.Text = "Education level";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label4.Location = new Point(34, 198);
            label4.Name = "label4";
            label4.Size = new Size(126, 29);
            label4.TabIndex = 2;
            label4.Text = "Depatment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label3.Location = new Point(14, 125);
            label3.Name = "label3";
            label3.Size = new Size(176, 29);
            label3.TabIndex = 1;
            label3.Text = "Student number";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 47);
            label2.Name = "label2";
            label2.Size = new Size(156, 29);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            label2.Click += label2_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 611);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button CANCELBTN;
        private Button Savebtn;
        private TextBox txtstudentcontact;
        private TextBox txtedu;
        private TextBox txtdepartment;
        private TextBox txtstudentnumber;
        private TextBox txtstudentname;
        private TextBox TxtstudentID;
        private Label label7;
    }
}