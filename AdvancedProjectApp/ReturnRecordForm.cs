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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AdvancedProjectApp
{
    public partial class ReturnRecordForm : Form
    {

        EquipmentRentalDBContext equipmentDBContext;

        public ReturnRecordForm()
        {
            InitializeComponent();

            equipmentDBContext = new EquipmentRentalDBContext();

            var requests = equipmentDBContext.ReturnRecords.Select(r => new
            {
                r.ReturnId,
                r.TransactionId,
                r.ActualReturnDate,
                r.ReturnCondition,
                r.LateReturnFees,
                r.AdditionalCharges
            })
               .ToList();
            dataGridView.DataSource = requests;
        }

        private void ReturnRecord_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Make sure it's not a header cell
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Populate the textboxes
                txtReturnId.Text = row.Cells["ReturnId"].Value?.ToString();
                txtTransactionId.Text = row.Cells["TransactionId"].Value?.ToString();
                txtActualReturnDate.Text = row.Cells["ActualReturnDate"].Value?.ToString();
                txtReturnCondition.Text = row.Cells["ReturnCondition"].Value?.ToString();
                txtLateReturnFees.Text = row.Cells["LateReturnFees"].Value?.ToString();
                txtAdditionalCharges.Text = row.Cells["AdditionalCharges"].Value?.ToString();
            }


        }

        private void RefreshData()
        {

            var requests = equipmentDBContext.ReturnRecords.Select(r => new
            {
                r.ReturnId,
                r.TransactionId,
                r.ActualReturnDate,
                r.ReturnCondition,
                r.LateReturnFees,
                r.AdditionalCharges
            })
              .ToList();
            dataGridView.DataSource = requests;

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

        private void addBtn_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new EquipmentRentalDBContext())
                {
                    // Validate required fields
                    if (string.IsNullOrWhiteSpace(txtReturnId.Text) ||
                        string.IsNullOrWhiteSpace(txtTransactionId.Text) ||
                        string.IsNullOrWhiteSpace(txtActualReturnDate.Text) ||
                        string.IsNullOrWhiteSpace(txtReturnCondition.Text) ||
                        string.IsNullOrWhiteSpace(txtLateReturnFees.Text) ||
                        string.IsNullOrWhiteSpace(txtAdditionalCharges.Text))
                    {
                        MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Parse values
                    if (!int.TryParse(txtReturnId.Text, out int returnId))
                    {
                        MessageBox.Show("Invalid Return ID.");
                        return;
                    }

                    if (!int.TryParse(txtTransactionId.Text, out int transactionId))
                    {
                        MessageBox.Show("Invalid Transaction ID.");
                        return;
                    }

                    if (!DateTime.TryParse(txtActualReturnDate.Text, out DateTime actualReturnDate))
                    {
                        MessageBox.Show("Invalid date. Use YYYY-MM-DD.");
                        return;
                    }

                    string returnCondition = txtReturnCondition.Text;

                    if (!decimal.TryParse(txtLateReturnFees.Text, out decimal lateReturnFees))
                    {
                        MessageBox.Show("Invalid Late Return Fee.");
                        return;
                    }

                    if (!decimal.TryParse(txtAdditionalCharges.Text, out decimal additionalCharges))
                    {
                        MessageBox.Show("Invalid Additional Charges.");
                        return;
                    }

                    var newRecord = new AdvanceProjectObjects.ReturnRecord
                    {
                        ReturnId = returnId,
                        TransactionId = transactionId,
                        ActualReturnDate = actualReturnDate,
                        ReturnCondition = returnCondition,
                        LateReturnFees = lateReturnFees,
                        AdditionalCharges = additionalCharges
                    };

                    context.ReturnRecords.Add(newRecord);
                    context.SaveChanges();
                }

                MessageBox.Show("Return record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
                ClearFormControls(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException?.Message ?? ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtReturnId.Text, out int returnId))
            {
                MessageBox.Show("Invalid Return ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingRecord = equipmentDBContext.ReturnRecords.FirstOrDefault(r => r.ReturnId == returnId);
            if (existingRecord != null)
            {
                existingRecord.TransactionId = int.Parse(txtTransactionId.Text);
                existingRecord.ActualReturnDate = DateTime.Parse(txtActualReturnDate.Text);
                existingRecord.ReturnCondition = txtReturnCondition.Text;
                existingRecord.LateReturnFees = decimal.Parse(txtLateReturnFees.Text);
                existingRecord.AdditionalCharges = decimal.Parse(txtAdditionalCharges.Text);

                equipmentDBContext.SaveChanges();
                MessageBox.Show("Return record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Return record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFormControls(this);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            string input = txtFilterValue.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a value to filter.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parse input to integer for filtering
            if (!int.TryParse(input, out int filterId))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filtered = equipmentDBContext.ReturnRecords
                .Where(r => r.TransactionId == filterId || r.Transaction.EquipmentId == filterId)
                .Select(r => new
                {
                    r.ReturnId,
                    r.TransactionId,
                    r.ActualReturnDate,
                    r.ReturnCondition,
                    r.LateReturnFees,
                    r.AdditionalCharges
                })
                .ToList();

            dataGridView.DataSource = filtered;

            if (filtered.Count == 0)
            {
                MessageBox.Show("No records found for the given ID.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtFilterValue.Clear();
            RefreshData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open the Dashboard form
            DashboardForm dashboardForm = new DashboardForm(); // optionally pass user
            this.Hide();
            dashboardForm.FormClosed += (s, args) => this.Close();
            dashboardForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rental_Requests RentalReq = new Rental_Requests(); // optionally pass user
            this.Hide();
            RentalReq.FormClosed += (s, args) => this.Close();
            RentalReq.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rental_Transactions RentalTr = new Rental_Transactions(); // optionally pass user
            this.Hide();
            RentalTr.FormClosed += (s, args) => this.Close();
            RentalTr.Show();
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
