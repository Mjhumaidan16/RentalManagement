using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedProjectApp;
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
            string enteredPassword = Password.Text.Trim(); // Ideally hash it for real security

            var user = equipmentDBContext.Users
                          .FirstOrDefault(u => u.Email == enteredEmail && u.PasswordHash == enteredPassword);

            if (user != null)
            {
                // Check user role
                if (user.Role == "Admin" || user.Role == "Manager")
                {
                    MessageBox.Show($"Welcome {user.Name}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hide the login form
                    this.Hide();

                    // Open the Dashboard form
                    DashboardForm dashboardForm = new DashboardForm(); // optionally pass user
                    dashboardForm.FormClosed += (s, args) => this.Close();
                    dashboardForm.Show();
                }
                else
                {
                    MessageBox.Show("Access denied. Only Admins and Managers can log in.", "Access Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Email or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Optional visual indicators for empty fields
            Panel5.Visible = string.IsNullOrWhiteSpace(Email.Text) || Email.Text == "Enter Email";
            panel7.Visible = string.IsNullOrWhiteSpace(Password.Text) || Password.Text == "Enter Password";
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
            FraddUsers addUserForm = new FraddUsers(); // Use the actual form
            this.Hide(); // hide the login form
            addUserForm.FormClosed += (s, args) => this.Close(); // close login when addUser closes
            addUserForm.Show();
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
