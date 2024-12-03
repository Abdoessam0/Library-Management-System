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
            button2 = new Button();
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
            pictureBox1.Location = new Point(95, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(35, 36, 55);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtusername.ForeColor = Color.White;
            txtusername.Location = new Point(85, 178);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(183, 26);
            txtusername.TabIndex = 1;
            txtusername.Text = "Username";
            txtusername.MouseClick += txtusername_MouseClick;
            // 
            // txtpasword
            // 
            txtpasword.BackColor = Color.FromArgb(35, 36, 55);
            txtpasword.BorderStyle = BorderStyle.None;
            txtpasword.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpasword.ForeColor = Color.White;
            txtpasword.Location = new Point(84, 263);
            txtpasword.Name = "txtpasword";
            txtpasword.Size = new Size(185, 20);
            txtpasword.TabIndex = 2;
            txtpasword.Text = "Password";
            txtpasword.MouseClick += txtpasword_MouseClick;
            txtpasword.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(47, 181);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(47, 263);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(83, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 1);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(83, 285);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 1);
            panel2.TabIndex = 6;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Cyan;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(95, 316);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(148, 32);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(95, 367);
            button2.Name = "button2";
            button2.Size = new Size(148, 29);
            button2.TabIndex = 8;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnClose_Click
            // 
            btnClose_Click.BackColor = Color.FromArgb(64, 64, 64);
            btnClose_Click.FlatStyle = FlatStyle.Popup;
            btnClose_Click.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose_Click.ForeColor = Color.Red;
            btnClose_Click.Location = new Point(305, 2);
            btnClose_Click.Name = "btnClose_Click";
            btnClose_Click.Size = new Size(26, 33);
            btnClose_Click.TabIndex = 9;
            btnClose_Click.Text = "X";
            btnClose_Click.UseVisualStyleBackColor = false;
            btnClose_Click.Click += button3_Click;
            // 
            // instabox
            // 
            instabox.Image = (Image)resources.GetObject("instabox.Image");
            instabox.Location = new Point(13, 415);
            instabox.Name = "instabox";
            instabox.Size = new Size(64, 37);
            instabox.SizeMode = PictureBoxSizeMode.StretchImage;
            instabox.TabIndex = 10;
            instabox.TabStop = false;
            instabox.Click += instabox_Click;
            // 
            // ataunibox
            // 
            ataunibox.Image = (Image)resources.GetObject("ataunibox.Image");
            ataunibox.Location = new Point(126, 415);
            ataunibox.Name = "ataunibox";
            ataunibox.Size = new Size(62, 37);
            ataunibox.SizeMode = PictureBoxSizeMode.StretchImage;
            ataunibox.TabIndex = 11;
            ataunibox.TabStop = false;
            ataunibox.Click += ataunibox_Click;
            // 
            // linkedinbox
            // 
            linkedinbox.Image = (Image)resources.GetObject("linkedinbox.Image");
            linkedinbox.Location = new Point(229, 415);
            linkedinbox.Name = "linkedinbox";
            linkedinbox.Size = new Size(62, 37);
            linkedinbox.SizeMode = PictureBoxSizeMode.StretchImage;
            linkedinbox.TabIndex = 12;
            linkedinbox.TabStop = false;
            linkedinbox.Click += linkedinbox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(333, 461);
            Controls.Add(linkedinbox);
            Controls.Add(ataunibox);
            Controls.Add(instabox);
            Controls.Add(btnClose_Click);
            Controls.Add(button2);
            Controls.Add(btnlogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtpasword);
            Controls.Add(txtusername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button button2;
        private Button btnClose_Click;
        private PictureBox instabox;
        private PictureBox ataunibox;
        private PictureBox linkedinbox;
    }
}
