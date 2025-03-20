namespace Abdelrahman_mohamed_200709050
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            txtusername = new TextBox();
            txtpasword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnlogin = new Button();
            btnClose_Click = new Button();
            instabox = new PictureBox();
            ataunibox = new PictureBox();
            linkedinbox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)instabox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ataunibox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linkedinbox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(35, 36, 55);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtusername.ForeColor = Color.White;
            txtusername.Location = new Point(97, 237);
            txtusername.Margin = new Padding(3, 4, 3, 4);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(209, 33);
            txtusername.TabIndex = 1;
            txtusername.Text = "Username";
            txtusername.MouseClick += txtusername_MouseClick;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpasword
            // 
            txtpasword.BackColor = Color.FromArgb(35, 36, 55);
            txtpasword.BorderStyle = BorderStyle.None;
            txtpasword.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpasword.ForeColor = Color.White;
            txtpasword.Location = new Point(96, 351);
            txtpasword.Margin = new Padding(3, 4, 3, 4);
            txtpasword.Name = "txtpasword";
            txtpasword.Size = new Size(211, 25);
            txtpasword.TabIndex = 2;
            txtpasword.Text = "Password";
            txtpasword.MouseClick += txtpasword_MouseClick;
            txtpasword.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Navy;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(54, 241);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(54, 351);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(95, 273);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 1);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(95, 380);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 1);
            panel2.TabIndex = 6;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Cyan;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(109, 439);
            btnlogin.Margin = new Padding(3, 4, 3, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(169, 43);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += button1_Click;
            // 
            // btnClose_Click
            // 
            btnClose_Click.BackColor = Color.FromArgb(64, 64, 64);
            btnClose_Click.FlatStyle = FlatStyle.Popup;
            btnClose_Click.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose_Click.ForeColor = Color.Red;
            btnClose_Click.Location = new Point(349, 3);
            btnClose_Click.Margin = new Padding(3, 4, 3, 4);
            btnClose_Click.Name = "btnClose_Click";
            btnClose_Click.Size = new Size(30, 44);
            btnClose_Click.TabIndex = 9;
            btnClose_Click.Text = "X";
            btnClose_Click.UseVisualStyleBackColor = false;
            btnClose_Click.Click += button3_Click;
            // 
            // instabox
            // 
            instabox.Image = (Image)resources.GetObject("instabox.Image");
            instabox.Location = new Point(15, 553);
            instabox.Margin = new Padding(3, 4, 3, 4);
            instabox.Name = "instabox";
            instabox.Size = new Size(73, 49);
            instabox.SizeMode = PictureBoxSizeMode.StretchImage;
            instabox.TabIndex = 10;
            instabox.TabStop = false;
            instabox.Click += instabox_Click;
            // 
            // ataunibox
            // 
            ataunibox.Image = (Image)resources.GetObject("ataunibox.Image");
            ataunibox.Location = new Point(144, 553);
            ataunibox.Margin = new Padding(3, 4, 3, 4);
            ataunibox.Name = "ataunibox";
            ataunibox.Size = new Size(71, 49);
            ataunibox.SizeMode = PictureBoxSizeMode.StretchImage;
            ataunibox.TabIndex = 11;
            ataunibox.TabStop = false;
            ataunibox.Click += ataunibox_Click;
            // 
            // linkedinbox
            // 
            linkedinbox.Image = (Image)resources.GetObject("linkedinbox.Image");
            linkedinbox.Location = new Point(262, 553);
            linkedinbox.Margin = new Padding(3, 4, 3, 4);
            linkedinbox.Name = "linkedinbox";
            linkedinbox.Size = new Size(71, 49);
            linkedinbox.SizeMode = PictureBoxSizeMode.StretchImage;
            linkedinbox.TabIndex = 12;
            linkedinbox.TabStop = false;
            linkedinbox.Click += linkedinbox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(381, 615);
            Controls.Add(linkedinbox);
            Controls.Add(ataunibox);
            Controls.Add(instabox);
            Controls.Add(btnClose_Click);
            Controls.Add(btnlogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtpasword);
            Controls.Add(txtusername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)instabox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ataunibox).EndInit();
            ((System.ComponentModel.ISupportInitialize)linkedinbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtusername;
        private TextBox txtpasword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Button btnlogin;
        private Button btnClose_Click;
        private PictureBox instabox;
        private PictureBox ataunibox;
        private PictureBox linkedinbox;
    }
}
