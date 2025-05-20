using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvanceProjectObjects;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp3
{
    public partial class Verifiyadm : Form
    {
        private string newUserName;
        private string newUserEmail;
        private string newUserPassword;
        private string newUserRole;

        EquipmentRentalDBContext equipmentDBContext;

        public Verifiyadm(string name, string email, string password, string role)
        {
            InitializeComponent();
            newUserName = name;
            newUserEmail = email;
            newUserPassword = password;
            newUserRole = role;
            equipmentDBContext = new EquipmentRentalDBContext();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string enteredEmail = adm.Text.Trim();
            string enteredPassword = adm_pass.Text.Trim();

            var currentUser = equipmentDBContext.Users.FirstOrDefault(u => u.Email == enteredEmail && u.PasswordHash == enteredPassword);

            if (currentUser != null && (currentUser.Role == "Admin" || currentUser.Role == "Manager"))
            {
                // Create and save new user
                User newUser = new User
                {
                    Name = newUserName,
                    Email = newUserEmail,
                    PasswordHash = newUserPassword,
                    Role = newUserRole,
                    CreatedAt = DateTime.Now
                };

                equipmentDBContext.Users.Add(newUser);
                equipmentDBContext.SaveChanges();

                MessageBox.Show("New user created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to login
                Form1 Form1 = new Form1(); // Replace with your login form name
                Form1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Only Admins and Managers can confirm.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void adm_pass_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void verifiyadm_Load(object sender, EventArgs e)
        {

        }

        private void adm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox4_Click(object sender, EventArgs e)
        {

            

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {

            

        }
    }
}
