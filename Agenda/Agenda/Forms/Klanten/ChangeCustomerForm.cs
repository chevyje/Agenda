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
    public partial class ChangeCustomerForm : Form
    {
        int customerId;
        public ChangeCustomerForm()
        {
            InitializeComponent();
        }

        public void LoadInfo(Customer c)
        {
            customerId = c.Id;
            string[] adres = c.Adres.Split(',');
            txtbox_name.Text = c.Naam;
            datetimepicker.Value = c.gbDatum;
            txtbox_email.Text = c.Email;
            txtbox_number.Text = c.TelefoonNummer;
            txtbox_street.Text = adres[0];
            txtbox_postcode.Text = adres[1];
            txtbox_city.Text = adres[2];
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
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

            if (CustomerCheck.LegitEmail(txtbox_email.Text) ||
                CustomerCheck.DutchPhoneNumber(txtbox_number.Text) ||
                CustomerCheck.ExistingCustomer(txtbox_name.Text, customerId))
            { MessageBox.Show("Email bevat geen @ of telefoon nummer is meer dan 10 tot 11 karaters lang of er bestaat al een klant met die naam"); return; }

            // Format the adress
            string adress = $"{txtbox_street.Text}, {txtbox_postcode.Text}, {txtbox_city.Text}";

            // Make a customer
            Customer c = new Customer(customerId, txtbox_name.Text, adress, txtbox_number.Text, txtbox_email.Text, datetimepicker.Value);

            // Add the customer to the database
            await CustomerQuery.UpdateCustomer(c);

            // Close this form
            this.Close();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet je zeker dat je deze klant wilt verwijderen?", "Bevestiging", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                await CustomerQuery.DeleteCustomer(customerId);
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}
