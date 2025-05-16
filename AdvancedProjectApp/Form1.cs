using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedProjectObjects;

namespace WindowsFormsApp3
{
    public partial class Form1: Form
    {

        EquipmentRentalDBContext equipmentDBContext;
        public Form1()
        {
            InitializeComponent();
            equipmentDBContext = new EquipmentRentalDBContext();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string enteredEmail = Email.Text.Trim();
            string enteredPassword = Password.Text.Trim(); // ideally use hash

            var user = equipmentDBContext.Users
                          .FirstOrDefault(u => u.Email == enteredEmail && u.PasswordHash == enteredPassword);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Name}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: redirect to another form
            }
            else
            {
                MessageBox.Show("Invalid Email or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Email.Text == "Enter Email")
            {
                Panel5.Visible = true;
            }

            if (Password.Text == "Enter Password")
            {
                panel6.Visible = true;
            }

        }
        

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                Email.ForeColor = Color.Black;

            } catch {


            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewAcount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Password.ForeColor = Color.Black;

            }
            catch
            {


            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_Click(object sender, EventArgs e)
        {

            Password.SelectAll();

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {

            Email.SelectAll();

        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
