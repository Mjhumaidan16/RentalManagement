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
    public partial class Rental_Transactions : Form
    {

        EquipmentRentalDBContext equipmentDBContext;

        public Rental_Transactions()
        {
            InitializeComponent();
            equipmentDBContext = new EquipmentRentalDBContext();

            var transactions = equipmentDBContext.RentalTransactions.Select(r => new
            {
                r.TransactionId,
                r.RequestId,
                r.CustomerId,
                r.EquipmentId,
                r.ActualStartDate,
                r.ActualReturnDate,
                r.RentalFee,
                r.Deposit,
                r.PaymentStatus
            })
                .ToList();
            dataGridView.DataSource = transactions;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Make sure it's not a header cell
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Populate the textboxes
                txtTransactionId.Text = row.Cells["TransactionId"].Value?.ToString();
                txtRequestId.Text = row.Cells["RequestId"].Value?.ToString();
                txtCustomerId.Text = row.Cells["CustomerID"].Value?.ToString();
                txtEquipmentId.Text = row.Cells["EquipmentID"].Value?.ToString();
                txtActualStartDate.Text = row.Cells["ActualStartDate"].Value?.ToString();
                txtActualReturnDate.Text = row.Cells["ActualReturnDate"].Value?.ToString();
                txtRentalFee.Text = row.Cells["RentalFee"].Value?.ToString();
                txtDeposit.Text = row.Cells["Deposit"].Value?.ToString();
                txtPaymentstatus.Text = row.Cells["PaymentStatus"].Value?.ToString();
            }

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
            Log Logs = new Log(); // optionally pass user
            this.Hide();
            Logs.FormClosed += (s, args) => this.Close();
            Logs.Show();
        }


        private void RefreshData()
        {

            var transactions = equipmentDBContext.RentalTransactions.Select(r => new
            {
                r.TransactionId,
                r.RequestId,
                r.CustomerId,
                r.EquipmentId,
                r.ActualStartDate,
                r.ActualReturnDate,
                r.RentalFee,
                r.Deposit,
                r.PaymentStatus
            })
               .ToList();
            dataGridView.DataSource = transactions;

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
                    //Validate required fields
                    if (
                        string.IsNullOrWhiteSpace(txtRequestId.Text) ||
                        string.IsNullOrWhiteSpace(txtCustomerId.Text) ||
                        string.IsNullOrWhiteSpace(txtEquipmentId.Text) ||
                        string.IsNullOrWhiteSpace(txtActualStartDate.Text) ||
                        string.IsNullOrWhiteSpace(txtActualReturnDate.Text) ||
                        string.IsNullOrWhiteSpace(txtRentalFee.Text) ||
                        string.IsNullOrWhiteSpace(txtDeposit.Text) ||
                        string.IsNullOrWhiteSpace(txtPaymentstatus.Text))
                    {
                        MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //Parse values
                    if (!int.TryParse(txtRequestId.Text, out int requestId))
                    {
                        MessageBox.Show("Invalid Request ID. Please enter a number.");
                        return;
                    }

                    if (!int.TryParse(txtCustomerId.Text, out int customerId))
                    {
                        MessageBox.Show("Invalid Customer ID. Please enter a number.");
                        return;
                    }

                    if (!int.TryParse(txtEquipmentId.Text, out int equipmentId))
                    {
                        MessageBox.Show("Invalid Equipment ID. Please enter a number.");
                        return;
                    }

                    if (!DateTime.TryParse(txtActualStartDate.Text, out DateTime actualStartDate))
                    {
                        MessageBox.Show("Invalid Actual Start Date. Use format YYYY-MM-DD.");
                        return;
                    }

                    if (!DateTime.TryParse(txtActualReturnDate.Text, out DateTime actualReturnDate))
                    {
                        MessageBox.Show("Invalid Actual Return Date. Use format YYYY-MM-DD.");
                        return;
                    }

                    if (!decimal.TryParse(txtRentalFee.Text, out decimal rentalFee))
                    {
                        MessageBox.Show("Invalid Rental Fee. Use decimal format like 100.00.");
                        return;
                    }

                    if (!decimal.TryParse(txtDeposit.Text, out decimal deposit))
                    {
                        MessageBox.Show("Invalid Deposit. Use decimal format like 50.00.");
                        return;
                    }

                    string paymentStatus = txtPaymentstatus.Text;



                    //Create and add the transaction
                    var newTransaction = new RentalTransaction
                    {
                        RequestId = requestId,
                        CustomerId = customerId,
                        EquipmentId = equipmentId,
                        ActualStartDate = actualStartDate,
                        ActualReturnDate = actualReturnDate,
                        RentalFee = rentalFee,
                        Deposit = deposit,
                        PaymentStatus = paymentStatus
                    };

                    context.RentalTransactions.Add(newTransaction);
                    context.SaveChanges();
                }

                MessageBox.Show("Transaction added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
                ClearFormControls(this);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric and date values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException?.Message ?? ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtRequestId.Text, out int requestId))
            {
                MessageBox.Show("Invalid Request ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingTransaction = equipmentDBContext.RentalTransactions.FirstOrDefault(r => r.RequestId == requestId);
            if (existingTransaction != null)
            {
                existingTransaction.RequestId = int.Parse(txtRequestId.Text);
                existingTransaction.CustomerId = int.Parse(txtCustomerId.Text);
                existingTransaction.EquipmentId = int.Parse(txtEquipmentId.Text);
                existingTransaction.ActualStartDate = DateTime.Parse(txtActualReturnDate.Text);
                existingTransaction.ActualReturnDate = DateTime.Parse(txtActualReturnDate.Text);
                existingTransaction.RentalFee = decimal.Parse(txtRentalFee.Text);
                existingTransaction.Deposit = decimal.Parse(txtDeposit.Text);
                existingTransaction.PaymentStatus = txtPaymentstatus.Text;

                equipmentDBContext.SaveChanges();
                MessageBox.Show("Request updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Request not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFormControls(this);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            string input = txtFilterValue.Text.Trim();

            IQueryable<RentalTransaction> query = equipmentDBContext.RentalTransactions;

            if (string.IsNullOrWhiteSpace(input))
            {
                // No filter, show all
            }
            else if (int.TryParse(input, out int idValue))
            {
                // Try to match either RequestId or EquipmentId
                query = query.Where(t => t.EquipmentId == idValue || t.RequestId == idValue);
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value (Equipment ID or Request ID).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filtered = query.Select(r => new
            {
                r.TransactionId,
                r.RequestId,
                r.CustomerId,
                r.EquipmentId,
                r.ActualStartDate,
                r.ActualReturnDate,
                r.RentalFee,
                r.Deposit,
                r.PaymentStatus
            }).ToList();

            dataGridView.DataSource = filtered;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFilterValue.Clear();
            RefreshData();

        }
    }
}
