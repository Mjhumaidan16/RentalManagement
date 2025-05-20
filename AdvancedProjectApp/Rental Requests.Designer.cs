namespace AdvancedProjectApp
{
    partial class Rental_Requests
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental_Requests));
            txtStatus = new ComboBox();
            label7 = new Label();
            btnUpdate = new Button();
            ReturnDate = new Label();
            txtStartDate = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtEquipmentId = new TextBox();
            label3 = new Label();
            txtCustomerId = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            txtReturnDate = new TextBox();
            txtRequestId = new TextBox();
            label8 = new Label();
            clearBtn = new Button();
            txtTotalCost = new TextBox();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            btnReset = new Button();
            btnFilter = new Button();
            comboStatusFilter = new ComboBox();
            label9 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.FormattingEnabled = true;
            txtStatus.Items.AddRange(new object[] { "Pending", "Approved", "Rejected" });
            txtStatus.Location = new Point(599, 126);
            txtStatus.Margin = new Padding(4, 3, 4, 3);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(198, 23);
            txtStatus.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(483, 126);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 18;
            label7.Text = "Status:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(33, 11, 97);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(319, 187);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 43);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ReturnDate
            // 
            ReturnDate.AutoSize = true;
            ReturnDate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnDate.Location = new Point(483, 81);
            ReturnDate.Margin = new Padding(4, 0, 4, 0);
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Size = new Size(76, 15);
            ReturnDate.TabIndex = 10;
            ReturnDate.Text = "Return Date:";
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(599, 40);
            txtStartDate.Margin = new Padding(4, 3, 4, 3);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(177, 21);
            txtStartDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(483, 40);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 8;
            label5.Text = "Rental Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 146);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Total Cost:";
            // 
            // txtEquipmentId
            // 
            txtEquipmentId.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEquipmentId.Location = new Point(146, 102);
            txtEquipmentId.Margin = new Padding(4, 3, 4, 3);
            txtEquipmentId.Name = "txtEquipmentId";
            txtEquipmentId.Size = new Size(156, 21);
            txtEquipmentId.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "Equipment ID:";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerId.Location = new Point(146, 60);
            txtCustomerId.Margin = new Padding(4, 3, 4, 3);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(156, 21);
            txtCustomerId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Customer ID:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(0, 345);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(979, 261);
            panel4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(21, 95);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(931, 223);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 2;
            label1.Text = "Rental Requset";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(0, 345);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 261);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtReturnDate);
            panel3.Controls.Add(txtRequestId);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(clearBtn);
            panel3.Controls.Add(txtTotalCost);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(ReturnDate);
            panel3.Controls.Add(txtStartDate);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtEquipmentId);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtCustomerId);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(322, 445);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(978, 248);
            panel3.TabIndex = 4;
            // 
            // txtReturnDate
            // 
            txtReturnDate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtReturnDate.Location = new Point(599, 81);
            txtReturnDate.Margin = new Padding(4, 3, 4, 3);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.Size = new Size(177, 21);
            txtReturnDate.TabIndex = 24;
            // 
            // txtRequestId
            // 
            txtRequestId.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRequestId.Location = new Point(146, 20);
            txtRequestId.Margin = new Padding(4, 3, 4, 3);
            txtRequestId.Name = "txtRequestId";
            txtRequestId.Size = new Size(156, 21);
            txtRequestId.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(44, 20);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 22;
            label8.Text = "Request ID:";
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
            clearBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(483, 187);
            clearBtn.Margin = new Padding(4, 3, 4, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(132, 43);
            clearBtn.TabIndex = 21;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += button6_Click;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalCost.Location = new Point(146, 139);
            txtTotalCost.Margin = new Padding(4, 3, 4, 3);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(156, 21);
            txtTotalCost.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(322, 72);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 350);
            panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnFilter);
            groupBox2.Controls.Add(comboStatusFilter);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(277, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(679, 64);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filters";
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
            // comboStatusFilter
            // 
            comboStatusFilter.FormattingEnabled = true;
            comboStatusFilter.Items.AddRange(new object[] { "Pending", "Approved", "Rejected" });
            comboStatusFilter.Location = new Point(134, 25);
            comboStatusFilter.Name = "comboStatusFilter";
            comboStatusFilter.Size = new Size(221, 23);
            comboStatusFilter.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 30);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 0;
            label9.Text = "Filter by Status:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(-6, -2);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1370, 36);
            panel5.TabIndex = 26;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SteelBlue;
            panel6.Location = new Point(9, 35);
            panel6.Margin = new Padding(5);
            panel6.Name = "panel6";
            panel6.Size = new Size(362, 725);
            panel6.TabIndex = 29;
            // 
            // panel7
            // 
            panel7.BackColor = Color.SteelBlue;
            panel7.Controls.Add(pictureBox6);
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(pictureBox3);
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(button5);
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(button4);
            panel7.Controls.Add(button3);
            panel7.Controls.Add(button2);
            panel7.Controls.Add(button1);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(-1, 33);
            panel7.Margin = new Padding(5);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 722);
            panel7.TabIndex = 25;
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
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(93, 270);
            button3.Name = "button3";
            button3.Size = new Size(169, 52);
            button3.TabIndex = 28;
            button3.Text = " Return Records";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(93, 199);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 27;
            button2.Text = "Rental Transactions";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(93, 138);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 26;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Rental_Requests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 752);
            Controls.Add(panel5);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Rental_Requests";
            Text = "Rental_Requests";
            Load += Rental_Requests_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox txtStatus;
        private Label label7;
        private Button btnUpdate;
        private ComboBox addEmployee_position;
        private Label ReturnDate;
        private TextBox txtStartDate;
        private Label label5;
        private Label label4;
        private TextBox txtEquipmentId;
        private Label label3;
        private TextBox txtCustomerId;
        private Label label2;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
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
        private GroupBox groupBox2;
        private Button btnReset;
        private Button btnFilter;
        private ComboBox comboStatusFilter;
        private Label label9;
        private TextBox txtTotalCost;
        private Button clearBtn;
        private TextBox txtRequestId;
        private Label label8;
        private TextBox txtReturnDate;
    }
}