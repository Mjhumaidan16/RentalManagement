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
    public partial class DashboardForm : Form
    {
        EquipmentRentalDBContext equipmentDBContext;

        public DashboardForm()
        {
            InitializeComponent();
            equipmentDBContext = new EquipmentRentalDBContext();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open the Dashboard form
            Rental_Requests RentalRec = new Rental_Requests(); // optionally pass user
            this.Hide();
            RentalRec.FormClosed += (s, args) => this.Close();
            RentalRec.Show();
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
    }
}
