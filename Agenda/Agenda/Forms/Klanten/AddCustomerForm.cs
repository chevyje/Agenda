using Agenda.Classes.Checks;
using Agenda.Classes.Objects;
using Agenda.Classes.Querys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Forms.Klanten
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
            SetDateTimePicker();
        }

        private void SetDateTimePicker()
        {
            datetimepicker.MaxDate = DateTime.Today;
            datetimepicker.Value = DateTime.Today;
        }

        private async void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            // Check voor lege waardes
            if (string.IsNullOrEmpty(txtbox_email.Text) ||
                string.IsNullOrEmpty(txtbox_name.Text) ||
                string.IsNullOrEmpty(txtbox_city.Text) ||
                string.IsNullOrEmpty(txtbox_number.Text) ||
                string.IsNullOrEmpty(txtbox_postcode.Text) ||
                string.IsNullOrEmpty(txtbox_street.Text) ||
                datetimepicker.Value == DateTime.Today
                )
            {
                DialogResult result = MessageBox.Show("Een of meerdere waardes zijn niet ingevuld! \n\n Weet je zeker dat je door wilt gaan?", "Bevestiging", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            // Check for legit email, dutch phone number and if the customer already exists
            if (CustomerCheck.LegitEmail(txtbox_email.Text)||
                CustomerCheck.DutchPhoneNumber(txtbox_number.Text)||
                CustomerCheck.ExistingCustomer(txtbox_name.Text))
            { return; }

            // Format the adress
            string adress = $"{txtbox_street.Text}, {txtbox_postcode.Text}, {txtbox_city.Text}";

            // Make a customer
            Customer c = new Customer(0, txtbox_name.Text, adress, txtbox_number.Text, txtbox_email.Text, datetimepicker.Value);

            // Add the customer to the database
            await CustomerQuery.ÍnsertCustomer(c);

            // Close this form
            this.Close();
        }
    }
}
