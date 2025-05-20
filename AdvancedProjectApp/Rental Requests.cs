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

namespace AdvancedProjectApp
{
    public partial class Rental_Requests : Form
    {

        EquipmentRentalDBContext equipmentDBContext;

        public Rental_Requests()
        {
            InitializeComponent();
            equipmentDBContext = new EquipmentRentalDBContext();

            var requests = equipmentDBContext.RentalRequests.Select(r => new
            {
                r.RequestId,
                r.CustomerId,
                r.EquipmentId,
                r.RentalStartDate,
                r.ReturnDate,
                r.TotalCost,
                r.Status
            })
               .ToList();
            dataGridView1.DataSource = requests;

        }

        private void Rental_Requests_Load(object sender, EventArgs e)
        {
            RefreshData();

            comboStatusFilter.Items.Clear();
            comboStatusFilter.Items.AddRange(new string[] { "Paid", "Pending", "Overdue" });
            comboStatusFilter.SelectedIndex = -1;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Open the Dashboard form
            DashboardForm dashboardForm = new DashboardForm(); // optionally pass user
            this.Hide();
            dashboardForm.FormClosed += (s, args) => this.Close();
            dashboardForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Rental_Transactions RentalTr = new Rental_Transactions(); // optionally pass user
            this.Hide();
            RentalTr.FormClosed += (s, args) => this.Close();
            RentalTr.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            ReturnRecordForm ReturnRec = new ReturnRecordForm(); // optionally pass user
            this.Hide();
            ReturnRec.FormClosed += (s, args) => this.Close();
            ReturnRec.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Make sure it's not a header cell
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate the textboxes
                txtRequestId.Text = row.Cells["RequestId"].Value?.ToString();
                txtCustomerId.Text = row.Cells["CustomerID"].Value?.ToString();
                txtEquipmentId.Text = row.Cells["EquipmentID"].Value?.ToString();
                txtStartDate.Text = row.Cells["RentalStartDate"].Value?.ToString();
                txtReturnDate.Text = row.Cells["ReturnDate"].Value?.ToString();
                txtTotalCost.Text = row.Cells["TotalCost"].Value?.ToString();
                txtStatus.Text = row.Cells["Status"].Value?.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearFormControls(this);
        }

        //Use the Controls collection to clear all textboxes
        private void ClearFormControls(Control parent)
        {
            foreach (Control ctl in parent.Controls)
            {
                if (ctl is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (ctl is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // Clears selection in dropdown
                }
                else if (ctl.HasChildren)
                {
                    ClearFormControls(ctl); // Recursively clear nested controls
                }
            }
        }


        private void RefreshData()
        {

            var requests = equipmentDBContext.RentalRequests.Select(r => new
            {
                r.RequestId,
                r.CustomerId,
                r.EquipmentId,
                r.RentalStartDate,
                r.ReturnDate,
                r.TotalCost,
                r.Status
            })
               .ToList();
            dataGridView1.DataSource = requests;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtRequestId.Text, out int requestId))
            {
                MessageBox.Show("Invalid Request ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingRequest = equipmentDBContext.RentalRequests.FirstOrDefault(r => r.RequestId == requestId);
            if (existingRequest != null)
            {
                existingRequest.CustomerId = int.Parse(txtCustomerId.Text);
                existingRequest.EquipmentId = int.Parse(txtEquipmentId.Text);
                existingRequest.RentalStartDate = DateTime.Parse(txtStartDate.Text);
                existingRequest.ReturnDate = DateTime.Parse(txtReturnDate.Text);
                existingRequest.TotalCost = decimal.Parse(txtTotalCost.Text);
                existingRequest.Status = txtStatus.Text;

                equipmentDBContext.SaveChanges();
                MessageBox.Show("Request updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Request not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            string selectedStatus = comboStatusFilter.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedStatus))
            {
                MessageBox.Show("Please select a status to filter.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var filteredRequests = equipmentDBContext.RentalRequests
                .Where(r => r.Status == selectedStatus)
                .Select(r => new
                {
                    r.RequestId,
                    r.CustomerId,
                    r.EquipmentId,
                    r.RentalStartDate,
                    r.ReturnDate,
                    r.TotalCost,
                    r.Status
                })
                .ToList();

            dataGridView1.DataSource = filteredRequests;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboStatusFilter.SelectedIndex = -1; // Clear selection
            RefreshData(); // Reload all data
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EquipmentInformation EquipmentInfo = new EquipmentInformation(); // optionally pass user
            this.Hide();
            EquipmentInfo.FormClosed += (s, args) => this.Close();
            EquipmentInfo.Show();
        }
    }
}
