
//namespace EmployeeManagementSystem
//{
//    partial class AddEmployee
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
//            panel1 = new Panel();
//            dataGridView1 = new DataGridView();
//            label1 = new Label();
//            panel2 = new Panel();
//            panel3 = new Panel();
//            addEmployee_status = new ComboBox();
//            label7 = new Label();
//            addEmployee_clearBtn = new Button();
//            addEmployee_deleteBtn = new Button();
//            addEmployee_updateBtn = new Button();
//            addEmployee_addBtn = new Button();
//            addEmployee_importBtn = new Button();
//            addEmployee_picture = new PictureBox();
//            addEmployee_position = new ComboBox();
//            label6 = new Label();
//            addEmployee_phoneNum = new TextBox();
//            label5 = new Label();
//            addEmployee_gender = new ComboBox();
//            label4 = new Label();
//            addEmployee_fullName = new TextBox();
//            label3 = new Label();
//            addEmployee_id = new TextBox();
//            label2 = new Label();
//            panel4 = new Panel();
//            panel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
//            panel3.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)addEmployee_picture).BeginInit();
//            SuspendLayout();
//            // 
//            // panel1
//            // 
//            panel1.BackColor = SystemColors.ButtonHighlight;
//            panel1.BorderStyle = BorderStyle.FixedSingle;
//            panel1.Controls.Add(dataGridView1);
//            panel1.Controls.Add(label1);
//            panel1.Controls.Add(panel2);
//            panel1.Location = new Point(21, 28);
//            panel1.Margin = new Padding(4, 3, 4, 3);
//            panel1.Name = "panel1";
//            panel1.Size = new Size(978, 322);
//            panel1.TabIndex = 0;
//            // 
//            // dataGridView1
//            // 
//            dataGridView1.AllowUserToAddRows = false;
//            dataGridView1.AllowUserToDeleteRows = false;
//            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 11, 97);
//            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            dataGridViewCellStyle1.ForeColor = Color.White;
//            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
//            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
//            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
//            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
//            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridView1.EnableHeadersVisualStyles = false;
//            dataGridView1.Location = new Point(26, 68);
//            dataGridView1.Margin = new Padding(4, 3, 4, 3);
//            dataGridView1.Name = "dataGridView1";
//            dataGridView1.ReadOnly = true;
//            dataGridView1.RowHeadersVisible = false;
//            dataGridView1.Size = new Size(931, 223);
//            dataGridView1.TabIndex = 3;
//            dataGridView1.CellClick += dataGridView1_CellClick;
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label1.Location = new Point(21, 24);
//            label1.Margin = new Padding(4, 0, 4, 0);
//            label1.Name = "label1";
//            label1.Size = new Size(148, 23);
//            label1.TabIndex = 2;
//            label1.Text = "Employee's Data";
//            // 
//            // panel2
//            // 
//            panel2.BackColor = SystemColors.ButtonHighlight;
//            panel2.Location = new Point(0, 345);
//            panel2.Margin = new Padding(4, 3, 4, 3);
//            panel2.Name = "panel2";
//            panel2.Size = new Size(979, 261);
//            panel2.TabIndex = 1;
//            // 
//            // panel3
//            // 
//            panel3.BackColor = SystemColors.ButtonHighlight;
//            panel3.BorderStyle = BorderStyle.FixedSingle;
//            panel3.Controls.Add(addEmployee_status);
//            panel3.Controls.Add(label7);
//            panel3.Controls.Add(addEmployee_clearBtn);
//            panel3.Controls.Add(addEmployee_deleteBtn);
//            panel3.Controls.Add(addEmployee_updateBtn);
//            panel3.Controls.Add(addEmployee_addBtn);
//            panel3.Controls.Add(addEmployee_importBtn);
//            panel3.Controls.Add(addEmployee_picture);
//            panel3.Controls.Add(addEmployee_position);
//            panel3.Controls.Add(label6);
//            panel3.Controls.Add(addEmployee_phoneNum);
//            panel3.Controls.Add(label5);
//            panel3.Controls.Add(addEmployee_gender);
//            panel3.Controls.Add(label4);
//            panel3.Controls.Add(addEmployee_fullName);
//            panel3.Controls.Add(label3);
//            panel3.Controls.Add(addEmployee_id);
//            panel3.Controls.Add(label2);
//            panel3.Controls.Add(panel4);
//            panel3.Location = new Point(21, 373);
//            panel3.Margin = new Padding(4, 3, 4, 3);
//            panel3.Name = "panel3";
//            panel3.Size = new Size(978, 248);
//            panel3.TabIndex = 2;
//            // 
//            // addEmployee_status
//            // 
//            addEmployee_status.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_status.FormattingEnabled = true;
//            addEmployee_status.Items.AddRange(new object[] { "Active", "Ianctive" });
//            addEmployee_status.Location = new Point(492, 125);
//            addEmployee_status.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_status.Name = "addEmployee_status";
//            addEmployee_status.Size = new Size(198, 23);
//            addEmployee_status.TabIndex = 19;
//            // 
//            // label7
//            // 
//            label7.AutoSize = true;
//            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label7.Location = new Point(436, 125);
//            label7.Margin = new Padding(4, 0, 4, 0);
//            label7.Name = "label7";
//            label7.Size = new Size(44, 15);
//            label7.TabIndex = 18;
//            label7.Text = "Status:";
//            // 
//            // addEmployee_clearBtn
//            // 
//            addEmployee_clearBtn.BackColor = Color.FromArgb(33, 11, 97);
//            addEmployee_clearBtn.Cursor = Cursors.Hand;
//            addEmployee_clearBtn.FlatAppearance.BorderSize = 0;
//            addEmployee_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_clearBtn.FlatStyle = FlatStyle.Flat;
//            addEmployee_clearBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_clearBtn.ForeColor = Color.White;
//            addEmployee_clearBtn.Location = new Point(690, 188);
//            addEmployee_clearBtn.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_clearBtn.Name = "addEmployee_clearBtn";
//            addEmployee_clearBtn.Size = new Size(132, 43);
//            addEmployee_clearBtn.TabIndex = 17;
//            addEmployee_clearBtn.Text = "Clear";
//            addEmployee_clearBtn.UseVisualStyleBackColor = false;
//            addEmployee_clearBtn.Click += addEmployee_clearBtn_Click;
//            // 
//            // addEmployee_deleteBtn
//            // 
//            addEmployee_deleteBtn.BackColor = Color.FromArgb(33, 11, 97);
//            addEmployee_deleteBtn.Cursor = Cursors.Hand;
//            addEmployee_deleteBtn.FlatAppearance.BorderSize = 0;
//            addEmployee_deleteBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_deleteBtn.FlatStyle = FlatStyle.Flat;
//            addEmployee_deleteBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_deleteBtn.ForeColor = Color.White;
//            addEmployee_deleteBtn.Location = new Point(538, 188);
//            addEmployee_deleteBtn.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
//            addEmployee_deleteBtn.Size = new Size(132, 43);
//            addEmployee_deleteBtn.TabIndex = 16;
//            addEmployee_deleteBtn.Text = "Delete";
//            addEmployee_deleteBtn.UseVisualStyleBackColor = false;
//            addEmployee_deleteBtn.Click += addEmployee_deleteBtn_Click;
//            // 
//            // addEmployee_updateBtn
//            // 
//            addEmployee_updateBtn.BackColor = Color.FromArgb(33, 11, 97);
//            addEmployee_updateBtn.Cursor = Cursors.Hand;
//            addEmployee_updateBtn.FlatAppearance.BorderSize = 0;
//            addEmployee_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_updateBtn.FlatStyle = FlatStyle.Flat;
//            addEmployee_updateBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_updateBtn.ForeColor = Color.White;
//            addEmployee_updateBtn.Location = new Point(364, 188);
//            addEmployee_updateBtn.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_updateBtn.Name = "addEmployee_updateBtn";
//            addEmployee_updateBtn.Size = new Size(132, 43);
//            addEmployee_updateBtn.TabIndex = 15;
//            addEmployee_updateBtn.Text = "Update";
//            addEmployee_updateBtn.UseVisualStyleBackColor = false;
//            addEmployee_updateBtn.Click += addEmployee_updateBtn_Click;
//            // 
//            // addEmployee_addBtn
//            // 
//            addEmployee_addBtn.BackColor = Color.FromArgb(33, 11, 97);
//            addEmployee_addBtn.Cursor = Cursors.Hand;
//            addEmployee_addBtn.FlatAppearance.BorderSize = 0;
//            addEmployee_addBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_addBtn.FlatStyle = FlatStyle.Flat;
//            addEmployee_addBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_addBtn.ForeColor = Color.White;
//            addEmployee_addBtn.Location = new Point(212, 188);
//            addEmployee_addBtn.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_addBtn.Name = "addEmployee_addBtn";
//            addEmployee_addBtn.Size = new Size(132, 43);
//            addEmployee_addBtn.TabIndex = 14;
//            addEmployee_addBtn.Text = "Add";
//            addEmployee_addBtn.UseVisualStyleBackColor = false;
//            addEmployee_addBtn.Click += addEmployee_addBtn_Click;
//            // 
//            // addEmployee_importBtn
//            // 
//            addEmployee_importBtn.BackColor = Color.FromArgb(33, 11, 97);
//            addEmployee_importBtn.Cursor = Cursors.Hand;
//            addEmployee_importBtn.FlatAppearance.BorderSize = 0;
//            addEmployee_importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_importBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
//            addEmployee_importBtn.FlatStyle = FlatStyle.Flat;
//            addEmployee_importBtn.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_importBtn.ForeColor = Color.White;
//            addEmployee_importBtn.Location = new Point(860, 145);
//            addEmployee_importBtn.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_importBtn.Name = "addEmployee_importBtn";
//            addEmployee_importBtn.Size = new Size(96, 27);
//            addEmployee_importBtn.TabIndex = 13;
//            addEmployee_importBtn.Text = "Import";
//            addEmployee_importBtn.UseVisualStyleBackColor = false;
//            addEmployee_importBtn.Click += addEmployee_importBtn_Click;
//            // 
//            // addEmployee_picture
//            // 
//            addEmployee_picture.BackColor = SystemColors.ButtonShadow;
//            addEmployee_picture.BorderStyle = BorderStyle.FixedSingle;
//            addEmployee_picture.Location = new Point(861, 39);
//            addEmployee_picture.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_picture.Name = "addEmployee_picture";
//            addEmployee_picture.Size = new Size(95, 106);
//            addEmployee_picture.SizeMode = PictureBoxSizeMode.StretchImage;
//            addEmployee_picture.TabIndex = 12;
//            addEmployee_picture.TabStop = false;
//            // 
//            // addEmployee_position
//            // 
//            addEmployee_position.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_position.FormattingEnabled = true;
//            addEmployee_position.Items.AddRange(new object[] { "Business Management", "Front-End Developer", "Back-End Developer", "Data Administrator", "UI/UX Design" });
//            addEmployee_position.Location = new Point(492, 80);
//            addEmployee_position.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_position.Name = "addEmployee_position";
//            addEmployee_position.Size = new Size(198, 23);
//            addEmployee_position.TabIndex = 11;
//            // 
//            // label6
//            // 
//            label6.AutoSize = true;
//            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label6.Location = new Point(425, 80);
//            label6.Margin = new Padding(4, 0, 4, 0);
//            label6.Name = "label6";
//            label6.Size = new Size(54, 15);
//            label6.TabIndex = 10;
//            label6.Text = "Position:";
//            // 
//            // addEmployee_phoneNum
//            // 
//            addEmployee_phoneNum.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_phoneNum.Location = new Point(492, 39);
//            addEmployee_phoneNum.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_phoneNum.Name = "addEmployee_phoneNum";
//            addEmployee_phoneNum.Size = new Size(177, 21);
//            addEmployee_phoneNum.TabIndex = 9;
//            // 
//            // label5
//            // 
//            label5.AutoSize = true;
//            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label5.Location = new Point(376, 39);
//            label5.Margin = new Padding(4, 0, 4, 0);
//            label5.Name = "label5";
//            label5.Size = new Size(94, 15);
//            label5.TabIndex = 8;
//            label5.Text = "Phone Number:";
//            // 
//            // addEmployee_gender
//            // 
//            addEmployee_gender.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_gender.FormattingEnabled = true;
//            addEmployee_gender.Items.AddRange(new object[] { "Male", "Female", "Others" });
//            addEmployee_gender.Location = new Point(146, 128);
//            addEmployee_gender.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_gender.Name = "addEmployee_gender";
//            addEmployee_gender.Size = new Size(198, 23);
//            addEmployee_gender.TabIndex = 7;
//            // 
//            // label4
//            // 
//            label4.AutoSize = true;
//            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label4.Location = new Point(78, 128);
//            label4.Margin = new Padding(4, 0, 4, 0);
//            label4.Name = "label4";
//            label4.Size = new Size(51, 15);
//            label4.TabIndex = 6;
//            label4.Text = "Gender:";
//            // 
//            // addEmployee_fullName
//            // 
//            addEmployee_fullName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_fullName.Location = new Point(146, 87);
//            addEmployee_fullName.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_fullName.Name = "addEmployee_fullName";
//            addEmployee_fullName.Size = new Size(198, 21);
//            addEmployee_fullName.TabIndex = 5;
//            // 
//            // label3
//            // 
//            label3.AutoSize = true;
//            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label3.Location = new Point(59, 87);
//            label3.Margin = new Padding(4, 0, 4, 0);
//            label3.Name = "label3";
//            label3.Size = new Size(67, 15);
//            label3.TabIndex = 4;
//            label3.Text = "Full Name:";
//            // 
//            // addEmployee_id
//            // 
//            addEmployee_id.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            addEmployee_id.Location = new Point(146, 40);
//            addEmployee_id.Margin = new Padding(4, 3, 4, 3);
//            addEmployee_id.Name = "addEmployee_id";
//            addEmployee_id.Size = new Size(156, 21);
//            addEmployee_id.TabIndex = 3;
//            // 
//            // label2
//            // 
//            label2.AutoSize = true;
//            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label2.Location = new Point(44, 40);
//            label2.Margin = new Padding(4, 0, 4, 0);
//            label2.Name = "label2";
//            label2.Size = new Size(80, 15);
//            label2.TabIndex = 2;
//            label2.Text = "Employee ID:";
//            // 
//            // panel4
//            // 
//            panel4.BackColor = SystemColors.ButtonHighlight;
//            panel4.Location = new Point(0, 345);
//            panel4.Margin = new Padding(4, 3, 4, 3);
//            panel4.Name = "panel4";
//            panel4.Size = new Size(979, 261);
//            panel4.TabIndex = 1;
//            // 
//            // AddEmployee
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            Controls.Add(panel3);
//            Controls.Add(panel1);
//            Margin = new Padding(4, 3, 4, 3);
//            Name = "AddEmployee";
//            Size = new Size(1021, 652);
//            Load += AddEmployee_Load;
//            panel1.ResumeLayout(false);
//            panel1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
//            panel3.ResumeLayout(false);
//            panel3.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)addEmployee_picture).EndInit();
//            ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Panel panel2;
//        private System.Windows.Forms.Panel panel3;
//        private System.Windows.Forms.Panel panel4;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.TextBox addEmployee_fullName;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.TextBox addEmployee_id;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.TextBox addEmployee_phoneNum;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.ComboBox addEmployee_gender;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.ComboBox addEmployee_position;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.Button addEmployee_clearBtn;
//        private System.Windows.Forms.Button addEmployee_deleteBtn;
//        private System.Windows.Forms.Button addEmployee_updateBtn;
//        private System.Windows.Forms.Button addEmployee_addBtn;
//        private System.Windows.Forms.Button addEmployee_importBtn;
//        private System.Windows.Forms.PictureBox addEmployee_picture;
//        private System.Windows.Forms.ComboBox addEmployee_status;
//        private System.Windows.Forms.Label label7;
//    }
//}
