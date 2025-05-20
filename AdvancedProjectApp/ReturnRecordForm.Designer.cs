namespace AdvancedProjectApp
{
    partial class ReturnRecordForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnRecordForm));
            dataGridView = new DataGridView();
            panel7 = new Panel();
            txtFilterValue = new TextBox();
            btnReset = new Button();
            btnFilter = new Button();
            label9 = new Label();
            groupBox1 = new GroupBox();
            panel6 = new Panel();
            label10 = new Label();
            txtAdditionalCharges = new TextBox();
            label11 = new Label();
            txtLateReturnFees = new TextBox();
            label5 = new Label();
            txtActualReturnDate = new TextBox();
            txtReturnId = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtReturnCondition = new ComboBox();
            label7 = new Label();
            clearBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            label6 = new Label();
            txtTransactionId = new TextBox();
            label8 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(21, 95);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(931, 223);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Location = new Point(0, 345);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(979, 261);
            panel7.TabIndex = 1;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.ForeColor = SystemColors.ScrollBar;
            txtFilterValue.Location = new Point(117, 26);
            txtFilterValue.Margin = new Padding(4, 3, 4, 3);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(201, 21);
            txtFilterValue.TabIndex = 15;
            txtFilterValue.Text = "Equipment ID or Request ID";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.WhiteSmoke;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(519, 21);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(137, 29);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.SteelBlue;
            btnFilter.FlatAppearance.BorderColor = Color.Purple;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(376, 21);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(137, 29);
            btnFilter.TabIndex = 13;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 30);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 0;
            label9.Text = "Filter by status:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtFilterValue);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnFilter);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(277, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(679, 64);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(groupBox1);
            panel6.Controls.Add(dataGridView);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(325, 31);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(978, 350);
            panel6.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 24);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(108, 23);
            label10.TabIndex = 2;
            label10.Text = "Rental Data";
            // 
            // txtAdditionalCharges
            // 
            txtAdditionalCharges.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdditionalCharges.Location = new Point(809, 93);
            txtAdditionalCharges.Margin = new Padding(4, 3, 4, 3);
            txtAdditionalCharges.Name = "txtAdditionalCharges";
            txtAdditionalCharges.Size = new Size(131, 21);
            txtAdditionalCharges.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(688, 96);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(113, 15);
            label11.TabIndex = 26;
            label11.Text = "Additional Charges:";
            // 
            // txtLateReturnFees
            // 
            txtLateReturnFees.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLateReturnFees.Location = new Point(809, 39);
            txtLateReturnFees.Margin = new Padding(4, 3, 4, 3);
            txtLateReturnFees.Name = "txtLateReturnFees";
            txtLateReturnFees.Size = new Size(131, 21);
            txtLateReturnFees.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(724, 42);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 24;
            label5.Text = "Return Fees:";
            // 
            // txtActualReturnDate
            // 
            txtActualReturnDate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtActualReturnDate.Location = new Point(492, 42);
            txtActualReturnDate.Margin = new Padding(4, 3, 4, 3);
            txtActualReturnDate.Name = "txtActualReturnDate";
            txtActualReturnDate.Size = new Size(177, 21);
            txtActualReturnDate.TabIndex = 23;
            // 
            // txtReturnId
            // 
            txtReturnId.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReturnId.Location = new Point(146, 42);
            txtReturnId.Margin = new Padding(4, 3, 4, 3);
            txtReturnId.Name = "txtReturnId";
            txtReturnId.Size = new Size(156, 21);
            txtReturnId.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 21;
            label1.Text = "Return ID:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-14, -22);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 36);
            panel2.TabIndex = 29;
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
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-9, 13);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 722);
            panel1.TabIndex = 28;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(30, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(234, 106);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 34;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(30, 396);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(30, 335);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(30, 270);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(93, 396);
            button5.Name = "button5";
            button5.Size = new Size(169, 52);
            button5.TabIndex = 30;
            button5.Text = "Logs";
            button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(93, 326);
            button4.Name = "button4";
            button4.Size = new Size(169, 52);
            button4.TabIndex = 29;
            button4.Text = "Equipment Information";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(93, 270);
            button3.Name = "button3";
            button3.Size = new Size(169, 52);
            button3.TabIndex = 28;
            button3.Text = " Return Transaction";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(93, 199);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 27;
            button2.Text = "Rental Requset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(93, 138);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 26;
            button1.Text = "DashBoard";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtReturnCondition
            // 
            txtReturnCondition.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReturnCondition.FormattingEnabled = true;
            txtReturnCondition.Items.AddRange(new object[] { "Good", "Damaged", "Lost" });
            txtReturnCondition.Location = new Point(492, 94);
            txtReturnCondition.Margin = new Padding(4, 3, 4, 3);
            txtReturnCondition.Name = "txtReturnCondition";
            txtReturnCondition.Size = new Size(177, 23);
            txtReturnCondition.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(376, 97);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 18;
            label7.Text = "Return Condition:";
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(33, 11, 97);
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(579, 187);
            clearBtn.Margin = new Padding(4, 3, 4, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(132, 43);
            clearBtn.TabIndex = 17;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(33, 11, 97);
            updateBtn.Cursor = Cursors.Hand;
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(418, 188);
            updateBtn.Margin = new Padding(4, 3, 4, 3);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(132, 43);
            updateBtn.TabIndex = 15;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(33, 11, 97);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(254, 188);
            addBtn.Margin = new Padding(4, 3, 4, 3);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(132, 43);
            addBtn.TabIndex = 14;
            addBtn.Text = "Create";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(376, 42);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 10;
            label6.Text = "Actual Return Date:";
            // 
            // txtTransactionId
            // 
            txtTransactionId.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTransactionId.Location = new Point(146, 96);
            txtTransactionId.Margin = new Padding(4, 3, 4, 3);
            txtTransactionId.Name = "txtTransactionId";
            txtTransactionId.Size = new Size(156, 21);
            txtTransactionId.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 96);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 2;
            label8.Text = "Transaction ID:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Location = new Point(0, 345);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(979, 261);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtAdditionalCharges);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(txtLateReturnFees);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtActualReturnDate);
            panel4.Controls.Add(txtReturnId);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtReturnCondition);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(clearBtn);
            panel4.Controls.Add(updateBtn);
            panel4.Controls.Add(addBtn);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtTransactionId);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(325, 404);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(978, 248);
            panel4.TabIndex = 31;
            // 
            // ReturnRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 713);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "ReturnRecordForm";
            Text = "ReturnRecord";
            Load += ReturnRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Panel panel7;
        private TextBox txtFilterValue;
        private Button btnReset;
        private Button btnFilter;
        private Label label9;
        private GroupBox groupBox1;
        private Panel panel6;
        private Label label10;
        private TextBox txtAdditionalCharges;
        private Label label11;
        private TextBox txtLateReturnFees;
        private Label label5;
        private TextBox txtActualReturnDate;
        private TextBox txtReturnId;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button5;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox txtReturnCondition;
        private Label label7;
        private Button clearBtn;
        private Button updateBtn;
        private Button addBtn;
        private Label label6;
        private TextBox txtTransactionId;
        private Label label8;
        private Panel panel5;
        private Panel panel4;
    }
}