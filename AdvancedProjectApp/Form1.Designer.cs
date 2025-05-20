namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Login_Btn = new Button();
            ForgotPassword = new LinkLabel();
            CreateNewAcount = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            Login = new Label();
            Email = new TextBox();
            emailPanel = new Panel();
            panel4 = new Panel();
            textBox3 = new TextBox();
            panel3 = new Panel();
            Panel5 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label2 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            textBox2 = new TextBox();
            Password = new TextBox();
            Email_Label = new Label();
            Password_Label = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            emailPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            Panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Login_Btn
            // 
            Login_Btn.Location = new Point(636, 461);
            Login_Btn.Margin = new Padding(4);
            Login_Btn.Name = "Login_Btn";
            Login_Btn.Size = new Size(248, 36);
            Login_Btn.TabIndex = 0;
            Login_Btn.Text = "Login";
            Login_Btn.UseVisualStyleBackColor = true;
            Login_Btn.Click += Button1_Click;
            // 
            // ForgotPassword
            // 
            ForgotPassword.AutoSize = true;
            ForgotPassword.LinkColor = Color.Black;
            ForgotPassword.Location = new Point(703, 412);
            ForgotPassword.Margin = new Padding(4, 0, 4, 0);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new Size(114, 17);
            ForgotPassword.TabIndex = 3;
            ForgotPassword.TabStop = true;
            ForgotPassword.Text = "Forgot Password";
            ForgotPassword.LinkClicked += ForgotPassword_LinkClicked;
            // 
            // CreateNewAcount
            // 
            CreateNewAcount.AutoSize = true;
            CreateNewAcount.LinkColor = Color.Black;
            CreateNewAcount.Location = new Point(696, 516);
            CreateNewAcount.Margin = new Padding(4, 0, 4, 0);
            CreateNewAcount.Name = "CreateNewAcount";
            CreateNewAcount.Size = new Size(129, 17);
            CreateNewAcount.TabIndex = 4;
            CreateNewAcount.TabStop = true;
            CreateNewAcount.Text = "Create New Acount";
            CreateNewAcount.LinkClicked += CreateNewAcount_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(0, 15);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 573);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(-1, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 31);
            panel2.TabIndex = 6;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Regular, GraphicsUnit.Point);
            Login.Location = new Point(728, 57);
            Login.Margin = new Padding(4, 0, 4, 0);
            Login.Name = "Login";
            Login.Size = new Size(65, 25);
            Login.TabIndex = 10;
            Login.Text = "Login";
            Login.Click += Login_Click;
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.None;
            Email.BackColor = SystemColors.ButtonFace;
            Email.BorderStyle = BorderStyle.None;
            Email.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            Email.ForeColor = Color.Gray;
            Email.Location = new Point(35, 17);
            Email.Margin = new Padding(4);
            Email.Name = "Email";
            Email.Size = new Size(415, 19);
            Email.TabIndex = 11;
            Email.Text = "Enter Email";
            Email.Click += TextBox1_Click;
            Email.TextChanged += TextBox1_TextChanged;
            // 
            // emailPanel
            // 
            emailPanel.BackColor = Color.Transparent;
            emailPanel.Controls.Add(panel4);
            emailPanel.Controls.Add(Email);
            emailPanel.Dock = DockStyle.Top;
            emailPanel.ForeColor = SystemColors.ActiveCaptionText;
            emailPanel.Location = new Point(0, 0);
            emailPanel.Margin = new Padding(4);
            emailPanel.Name = "emailPanel";
            emailPanel.Size = new Size(499, 50);
            emailPanel.TabIndex = 12;
            emailPanel.Paint += Panel3_Paint;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(textBox3);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(34, 40);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(415, 2);
            panel4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(200, 20);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(415, 23);
            textBox3.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(Panel5);
            panel3.Controls.Add(emailPanel);
            panel3.Location = new Point(511, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 97);
            panel3.TabIndex = 13;
            // 
            // Panel5
            // 
            Panel5.Controls.Add(label1);
            Panel5.Location = new Point(34, 55);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(462, 39);
            Panel5.TabIndex = 13;
            Panel5.Visible = false;
            Panel5.Paint += Panel5_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 14;
            label1.Text = "Invalid Email";
            label1.Click += Label1_Click_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(511, 248);
            panel6.Name = "panel6";
            panel6.Size = new Size(499, 97);
            panel6.TabIndex = 14;
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Location = new Point(34, 55);
            panel7.Name = "panel7";
            panel7.Size = new Size(462, 39);
            panel7.TabIndex = 13;
            panel7.Visible = false;
            panel7.Paint += Panel7_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 17);
            label2.TabIndex = 14;
            label2.Text = "Invalid Password";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(Password);
            panel8.Dock = DockStyle.Top;
            panel8.ForeColor = SystemColors.ActiveCaptionText;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(499, 50);
            panel8.TabIndex = 12;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.BackColor = Color.Black;
            panel9.Controls.Add(textBox2);
            panel9.ForeColor = SystemColors.ActiveCaptionText;
            panel9.Location = new Point(34, 40);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(415, 2);
            panel9.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(200, 20);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(415, 23);
            textBox2.TabIndex = 11;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.BackColor = SystemColors.ButtonFace;
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = Color.Gray;
            Password.Location = new Point(35, 17);
            Password.Margin = new Padding(4);
            Password.Name = "Password";
            Password.Size = new Size(415, 19);
            Password.TabIndex = 11;
            Password.Text = "Enter Password";
            Password.Click += TextBox4_Click;
            Password.TextChanged += TextBox4_TextChanged;
            // 
            // Email_Label
            // 
            Email_Label.AutoSize = true;
            Email_Label.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            Email_Label.Location = new Point(439, 149);
            Email_Label.Margin = new Padding(4, 0, 4, 0);
            Email_Label.Name = "Email_Label";
            Email_Label.Size = new Size(42, 17);
            Email_Label.TabIndex = 1;
            Email_Label.Text = "Email";
            Email_Label.Click += Label1_Click;
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_Label.Location = new Point(439, 258);
            Password_Label.Margin = new Padding(4, 0, 4, 0);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(69, 17);
            Password_Label.TabIndex = 2;
            Password_Label.Text = "Password";
            Password_Label.Click += Password_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(363, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(363, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += PictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1067, 588);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Login);
            Controls.Add(Password_Label);
            Controls.Add(panel2);
            Controls.Add(Email_Label);
            Controls.Add(panel1);
            Controls.Add(CreateNewAcount);
            Controls.Add(ForgotPassword);
            Controls.Add(Login_Btn);
            Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            emailPanel.ResumeLayout(false);
            emailPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_Btn;
        private LinkLabel ForgotPassword;
        private LinkLabel CreateNewAcount;
        private Panel panel1;
        private Panel panel2;
        private Label Login;
        private TextBox Email;
        private Panel emailPanel;
        private Panel panel4;
        private TextBox textBox3;
        private Panel panel3;
        private Panel Panel5;
        private Label label1;
        private Panel panel6;
        private Panel panel7;
        private Label label2;
        private Panel panel8;
        private Panel panel9;
        private TextBox textBox2;
        private TextBox Password;
        private Label Email_Label;
        private Label Password_Label;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

