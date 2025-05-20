namespace WindowsFormsApp3
{
    partial class Verifiyadm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verifiyadm));
            pictureBox2 = new PictureBox();
            password = new Label();
            email = new Label();
            adm = new TextBox();
            textBox2 = new TextBox();
            panel9 = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            Signup = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            verifiy_btn = new Button();
            panel14 = new Panel();
            panel15 = new Panel();
            label4 = new Label();
            panel16 = new Panel();
            panel17 = new Panel();
            textBox7 = new TextBox();
            adm_pass = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(402, 368);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(491, 380);
            password.Margin = new Padding(5, 0, 5, 0);
            password.Name = "password";
            password.Size = new Size(69, 17);
            password.TabIndex = 17;
            password.Text = "Password";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(491, 254);
            email.Margin = new Padding(5, 0, 5, 0);
            email.Name = "email";
            email.Size = new Size(42, 17);
            email.TabIndex = 16;
            email.Text = "Email";
            // 
            // adm
            // 
            adm.Anchor = AnchorStyles.None;
            adm.BackColor = SystemColors.ButtonFace;
            adm.BorderStyle = BorderStyle.None;
            adm.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            adm.ForeColor = Color.Gray;
            adm.Location = new Point(10, 20);
            adm.Margin = new Padding(5);
            adm.Name = "adm";
            adm.Size = new Size(484, 19);
            adm.TabIndex = 11;
            adm.Text = "Enter Admin Email";
            adm.Click += TextBox1_Click;
            adm.TextChanged += adm_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(233, 23);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(483, 23);
            textBox2.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.BackColor = Color.Black;
            panel9.Controls.Add(textBox2);
            panel9.ForeColor = SystemColors.ActiveCaptionText;
            panel9.Location = new Point(9, 46);
            panel9.Margin = new Padding(5);
            panel9.Name = "panel9";
            panel9.Size = new Size(484, 2);
            panel9.TabIndex = 13;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(adm);
            panel8.Dock = DockStyle.Top;
            panel8.ForeColor = SystemColors.ActiveCaptionText;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(5);
            panel8.Name = "panel8";
            panel8.Size = new Size(520, 58);
            panel8.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 17);
            label2.TabIndex = 14;
            label2.Text = "* Invalid Email";
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Location = new Point(12, 63);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(505, 45);
            panel7.TabIndex = 13;
            panel7.Visible = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(597, 232);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(520, 112);
            panel6.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(402, 232);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Signup
            // 
            Signup.AutoSize = true;
            Signup.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Regular, GraphicsUnit.Point);
            Signup.Location = new Point(748, 54);
            Signup.Margin = new Padding(5, 0, 5, 0);
            Signup.Name = "Signup";
            Signup.Size = new Size(141, 25);
            Signup.TabIndex = 23;
            Signup.Text = "verifiy Admin ";
            Signup.Click += Login_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-9, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 36);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Location = new Point(9, 35);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(362, 725);
            panel3.TabIndex = 29;
            // 
            // verifiy_btn
            // 
            verifiy_btn.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            verifiy_btn.Location = new Point(741, 658);
            verifiy_btn.Margin = new Padding(5);
            verifiy_btn.Name = "verifiy_btn";
            verifiy_btn.Size = new Size(184, 42);
            verifiy_btn.TabIndex = 15;
            verifiy_btn.Text = "verifiy";
            verifiy_btn.UseVisualStyleBackColor = true;
            verifiy_btn.Click += login_btn_Click;
            // 
            // panel14
            // 
            panel14.Controls.Add(panel15);
            panel14.Controls.Add(panel16);
            panel14.Location = new Point(597, 351);
            panel14.Margin = new Padding(4, 3, 4, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(524, 112);
            panel14.TabIndex = 27;
            // 
            // panel15
            // 
            panel15.Controls.Add(label4);
            panel15.Location = new Point(12, 63);
            panel15.Margin = new Padding(4, 3, 4, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(509, 45);
            panel15.TabIndex = 13;
            panel15.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 17);
            label4.TabIndex = 14;
            label4.Text = "* Invalid Password";
            // 
            // panel16
            // 
            panel16.BackColor = Color.Transparent;
            panel16.Controls.Add(panel17);
            panel16.Controls.Add(adm_pass);
            panel16.Dock = DockStyle.Top;
            panel16.ForeColor = SystemColors.ActiveCaptionText;
            panel16.Location = new Point(0, 0);
            panel16.Margin = new Padding(5);
            panel16.Name = "panel16";
            panel16.Size = new Size(524, 58);
            panel16.TabIndex = 12;
            // 
            // panel17
            // 
            panel17.Anchor = AnchorStyles.None;
            panel17.BackColor = Color.Black;
            panel17.Controls.Add(textBox7);
            panel17.ForeColor = SystemColors.ActiveCaptionText;
            panel17.Location = new Point(10, 46);
            panel17.Margin = new Padding(5);
            panel17.Name = "panel17";
            panel17.Size = new Size(484, 2);
            panel17.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(233, 23);
            textBox7.Margin = new Padding(5);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(483, 23);
            textBox7.TabIndex = 11;
            // 
            // adm_pass
            // 
            adm_pass.Anchor = AnchorStyles.None;
            adm_pass.BackColor = SystemColors.ButtonFace;
            adm_pass.BorderStyle = BorderStyle.None;
            adm_pass.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            adm_pass.ForeColor = Color.Gray;
            adm_pass.Location = new Point(12, 20);
            adm_pass.Margin = new Padding(5);
            adm_pass.Name = "adm_pass";
            adm_pass.Size = new Size(484, 19);
            adm_pass.TabIndex = 11;
            adm_pass.Text = "Enter Password";
            adm_pass.Click += TextBox4_Click;
            adm_pass.TextChanged += adm_pass_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(-5, 35);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 722);
            panel1.TabIndex = 21;
            // 
            // Verifiyadm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 752);
            Controls.Add(pictureBox2);
            Controls.Add(panel14);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(panel6);
            Controls.Add(pictureBox1);
            Controls.Add(Signup);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(verifiy_btn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Verifiyadm";
            Text = "DashboardForm";
            WindowState = FormWindowState.Maximized;
            Load += verifiyadm_Load;
            Click += adm_TextChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox pictureBox2;
        private Label password;
        private Label email;
        private TextBox adm;
        private TextBox textBox2;
        private Panel panel9;
        private Panel panel8;
        private Label label2;
        private Panel panel7;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label Signup;
        private Panel panel2;
        private Button verifiy_btn;
        private Panel panel14;
        private Panel panel15;
        private Label label4;
        private Panel panel16;
        private Panel panel17;
        private TextBox textBox7;
        private TextBox adm_pass;
        private Panel panel3;
        private Panel panel1;
    }
}