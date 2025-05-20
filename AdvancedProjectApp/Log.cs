using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using AdvanceProjectObjects;

namespace AdvancedProjectApp
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadRoles();
            LoadLogs();
        }

        private void LoadLogs()
        {
            try
            {
                using (var db = new EquipmentRentalDBContext())
                {
                    var logs = (from log in db.Logs
                                join user in db.Users on log.UserId equals user.UserId
                                orderby log.Timestamp descending
                                select new
                                {
                                    user.Name,
                                    user.Email,
                                    log.Action,
                                    log.Source,
                                    log.Details,
                                    log.Timestamp
                                }).ToList();

                    dataGridViewLogs.DataSource = logs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load logs: " + ex.Message);
            }
        }

        private void LoadRoles()
        {
            comboStatusFilter.Items.Clear();
            comboStatusFilter.Items.Add("All Roles"); // Optional "show everything"
            comboStatusFilter.Items.Add("Admin");
            comboStatusFilter.Items.Add("Manager");
            comboStatusFilter.Items.Add("Customer");
            comboStatusFilter.SelectedIndex = 0;
        }

        private void LoadLogs(string roleFilter = "All Roles")
        {
            try
            {
                using (var db = new EquipmentRentalDBContext())
                {
                    var query = from log in db.Logs
                                join user in db.Users on log.UserId equals user.UserId
                                orderby log.Timestamp descending
                                select new
                                {
                                    user.Name,
                                    user.Email,
                                    user.Role,
                                    log.Action,
                                    log.Source,
                                    log.Details,
                                    log.Timestamp
                                };

                    if (roleFilter != "All Roles")
                    {
                        query = query.Where(q => q.Role == roleFilter);
                    }

                    dataGridViewLogs.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load logs: " + ex.Message);
            }
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedRole = comboStatusFilter.SelectedItem.ToString();
            LoadLogs(selectedRole);
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            comboStatusFilter.SelectedIndex = 0; // Reset to "All Roles"
            LoadLogs(); // Reload everything
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm(); // optionally pass user
            this.Hide();
            dashboardForm.FormClosed += (s, args) => this.Close();
            dashboardForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rental_Transactions RentalTr = new Rental_Transactions(); // optionally pass user
            this.Hide();
            RentalTr.FormClosed += (s, args) => this.Close();
            RentalTr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReturnRecordForm ReturnRec = new ReturnRecordForm(); // optionally pass user
            this.Hide();
            ReturnRec.FormClosed += (s, args) => this.Close();
            ReturnRec.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EquipmentInformation EquipmentInfo = new EquipmentInformation(); // optionally pass user
            this.Hide();
            EquipmentInfo.FormClosed += (s, args) => this.Close();
            EquipmentInfo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rental_Requests RentalReq = new Rental_Requests(); // optionally pass user
            this.Hide();
            RentalReq.FormClosed += (s, args) => this.Close();
            RentalReq.Show();
        }
    }
}

