using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using AdvanceProjectObjects;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AdvancedProjectApp
{
    public partial class EquipmentInformation : Form
    {

        EquipmentRentalDBContext equipmentDBContext;

        public EquipmentInformation()
        {
            InitializeComponent();

            var requests = equipmentDBContext.Equipment.Select(r => new
            {
                r.EquipmentId,
                r.Name,
                r.Description,
                r.CategoryId,
                r.RentalPrice,
                r.AvailabilityStatus,
                r.ConditionStatus,
                r.CreatedAt,
                r.LastUpdated
            })
               .ToList();
            dataGridView.DataSource = requests;
        }

        private void EquipmentInformation_Load(object sender, EventArgs e)
        {

            cmbConditionStatus.Items.AddRange(new string[] { "All", "New", "Good", "Damaged" });
            cmbAvailabilityStatus.Items.AddRange(new string[] { "All", "Available", "Rented" });

            cmbConditionStatus.SelectedIndex = 0;  // All
            cmbAvailabilityStatus.SelectedIndex = 0;  // All

            RefreshData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Make sure it's not a header cell
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Populate the textboxes
                txtEquipmentId.Text = row.Cells["EquipmentId"].Value?.ToString();
                txtEquipmentName.Text = row.Cells["Name"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();
                txtCategoryId.Text = row.Cells["CategoryId"].Value?.ToString();
                txtRentalPrice.Text = row.Cells["RentalPrice"].Value?.ToString();
                txtAvailabilityStatus.Text = row.Cells["AvailabilityStatus"].Value?.ToString();
                txtConditionStatus.Text = row.Cells["ConditionStatus"].Value?.ToString();
                txtCreatedAt.Text = row.Cells["CreatedAt"].Value?.ToString();
                txtLastUpdated.Text = row.Cells["LastUpdated"].Value?.ToString();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new EquipmentRentalDBContext())
                {
                    // Validate required fields
                    if (
                        string.IsNullOrWhiteSpace(txtEquipmentId.Text) ||
                        string.IsNullOrWhiteSpace(txtEquipmentName.Text) ||
                        string.IsNullOrWhiteSpace(txtDescription.Text) ||
                        string.IsNullOrWhiteSpace(txtCategoryId.Text) ||
                        string.IsNullOrWhiteSpace(txtRentalPrice.Text) ||
                        string.IsNullOrWhiteSpace(txtAvailabilityStatus.Text) ||
                        string.IsNullOrWhiteSpace(txtConditionStatus.Text) ||
                        string.IsNullOrWhiteSpace(txtCreatedAt.Text) ||
                        string.IsNullOrWhiteSpace(txtLastUpdated.Text))
                    {
                        MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Parse values
                    if (!int.TryParse(txtEquipmentId.Text, out int equipmentId))
                    {
                        MessageBox.Show("Invalid Equipment ID. Please enter a number.");
                        return;
                    }

                    if (!int.TryParse(txtCategoryId.Text, out int categoryId))
                    {
                        MessageBox.Show("Invalid Category ID. Please enter a number.");
                        return;
                    }

                    if (!decimal.TryParse(txtRentalPrice.Text, out decimal rentalPrice))
                    {
                        MessageBox.Show("Invalid Rental Price. Use decimal format like 50.00.");
                        return;
                    }

                    if (!DateTime.TryParse(txtCreatedAt.Text, out DateTime createdAt))
                    {
                        MessageBox.Show("Invalid Created At date. Use format YYYY-MM-DD.");
                        return;
                    }

                    if (!DateTime.TryParse(txtLastUpdated.Text, out DateTime lastUpdated))
                    {
                        MessageBox.Show("Invalid Last Updated date. Use format YYYY-MM-DD.");
                        return;
                    }

                    string name = txtEquipmentName.Text;
                    string description = txtDescription.Text;
                    string availabilityStatus = txtAvailabilityStatus.Text;
                    string conditionStatus = txtConditionStatus.Text;

                    // Create and add new equipment
                    var newEquipment = new Equipment
                    {
                        EquipmentId = equipmentId,
                        Name = name,
                        Description = description,
                        CategoryId = categoryId,
                        RentalPrice = rentalPrice,
                        AvailabilityStatus = availabilityStatus,
                        ConditionStatus = conditionStatus,
                        CreatedAt = createdAt,
                        LastUpdated = lastUpdated
                    };

                    // Save to DB
                    context.Equipment.Add(newEquipment);
                    context.SaveChanges();
                }

                MessageBox.Show("Equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
                ClearFormControls(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + (ex.InnerException?.Message ?? ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtEquipmentId.Text, out int EquipmentId))
            {
                MessageBox.Show("Invalid Request ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingRequest = equipmentDBContext.Equipment.FirstOrDefault(r => r.EquipmentId == EquipmentId);
            if (existingRequest != null)
            {
                existingRequest.EquipmentId = int.Parse(txtEquipmentId.Text);
                existingRequest.Name = txtEquipmentName.Text;
                existingRequest.Description = txtDescription.Text;
                existingRequest.CategoryId = int.Parse(txtCategoryId.Text);
                existingRequest.RentalPrice = decimal.Parse(txtRentalPrice.Text);
                existingRequest.AvailabilityStatus = txtAvailabilityStatus.Text;
                existingRequest.ConditionStatus = txtConditionStatus.Text;
                existingRequest.CreatedAt = DateTime.Parse(txtCreatedAt.Text);
                existingRequest.LastUpdated = DateTime.Parse(txtLastUpdated.Text);

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
            var query = equipmentDBContext.Equipment.AsQueryable();

            if (condition != "All")
            {
                query = query.Where(e => e.ConditionStatus == condition);
            }

            if (availability != "All")
            {
                query = query.Where(e => e.AvailabilityStatus == availability);
            }

            var filteredData = query.Select(r => new
            {
                r.EquipmentId,
                r.Name,
                r.Description,
                r.CategoryId,
                r.RentalPrice,
                r.AvailabilityStatus,
                r.ConditionStatus,
                r.CreatedAt,
                r.LastUpdated
            }).ToList();

            dataGridView.DataSource = filteredData;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }


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

            var requests = equipmentDBContext.Equipment.Select(r => new
            {
                r.EquipmentId,
                r.Name,
                r.Description,
                r.CategoryId,
                r.RentalPrice,
                r.AvailabilityStatus,
                r.ConditionStatus,
                r.CreatedAt,
                r.LastUpdated
            })
               .ToList();
            dataGridView.DataSource = requests;

        }
    }
}
