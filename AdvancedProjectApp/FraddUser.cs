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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp3
{
    public partial class FraddUsers : Form
    {

        EquipmentRentalDBContext equipmentDBContext;

        public FraddUsers()
        {
            InitializeComponent();
            equipmentDBContext = new EquipmentRentalDBContext();
        }

        private void Signup_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FraddUsers_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verifiy_btn_Click(object sender, EventArgs e)
        {
            // Show red panels if fields are invalid
            panel4.Visible = string.IsNullOrWhiteSpace(FullName.Text) || FullName.Text == "Enter Admin/Manager Name";
            panel7.Visible = string.IsNullOrWhiteSpace(email.Text) || email.Text == "Enter Admin/Manager Email";
            panel15.Visible = string.IsNullOrWhiteSpace(password.Text) || password.Text == "Enter Password";
            panel11.Visible = string.IsNullOrWhiteSpace(Number.Text) || Number.Text == "Enter Password";

            // Check role selection
            if (checkedListBox1.CheckedItems.Count != 1)
            {
                MessageBox.Show("Please select exactly one role (Admin or Manager).", "Role Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //// Check passwords match
            //if (password.Text.Trim() != ConPassword.Text.Trim())
            //{
            //    MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            // Gather user input
            string role = checkedListBox1.CheckedItems[0].ToString();
            string name = FullName.Text.Trim();
            string emailInput = email.Text.Trim();
            string pass = password.Text.Trim();
            //int phone = Number.int.Trim();
            string address = Address.Text.Trim();

            // Open verification form and pass data
            Verifiyadm verifyForm = new Verifiyadm(name, emailInput, pass, role); // Create this form next
            verifyForm.FormClosed += (s, args) => this.Close(); // Close signup form after verification
            verifyForm.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
