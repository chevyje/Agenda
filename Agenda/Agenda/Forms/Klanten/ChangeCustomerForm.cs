using Agenda.Classes;
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
            customerId = c.id;

            // Personal
            txtbox_name.Text = c.name;
            txtbox_salutation.Text = c.salutation;
            switch (c.gender)
            {
                case "m": combox_gender.StartIndex = 1; break;
                case "v": combox_gender.StartIndex = 2; break;
                case "a": combox_gender.StartIndex = 3; break;
                default: combox_gender.StartIndex = 0; break;
            }

            // Location
            txtbox_address.Text = c.address;
            txtbox_postalCode.Text = c.postalCode;
            txtbox_city.Text = c.city;
            txtbox_country.Text = c.country;

            // Contact
            txtbox_phoneNumber.Text = c.phoneNumber;
            txtbox_mobilePhoneNumber.Text = c.mobilePhoneNumber;
            txtbox_emailAddress.Text = c.emailAddress;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            var requiredFields = new[] {
                txtbox_name,
                txtbox_salutation,

                txtbox_address,
                txtbox_postalCode,
                txtbox_city,
                txtbox_country,

                txtbox_phoneNumber,
                txtbox_mobilePhoneNumber,
                txtbox_emailAddress
            };
            if (InputChecks.emptyFields(requiredFields)) return;

            // Check for valid email & phone number
            if (!InputChecks.ValidEmail(txtbox_emailAddress.Text)) return;
            if (!InputChecks.ValidPhoneNumber(txtbox_phoneNumber.Text)) return;
            if (!InputChecks.ValidPhoneNumber(txtbox_mobilePhoneNumber.Text)) return;

            // Gatter info and create object
            var data = new
            {
                type = "P",
                name = txtbox_name.Text,
                salutation = txtbox_salutation,
                gender = combox_gender.Text,
                address = txtbox_address.Text,
                postalCode = txtbox_postalCode.Text,
                city = txtbox_city.Text,
                country = txtbox_country,
                address2 = txtbox_address.Text,
                postalCode2 = txtbox_postalCode.Text,
                city2 = txtbox_city.Text,
                country2 = txtbox_country,
                phoneNumber = txtbox_phoneNumber.Text,
                mobilePhoneNumber = txtbox_mobilePhoneNumber.Text,
                emailAddress = txtbox_emailAddress.Text,
                emailAddressInvoice = txtbox_emailAddress.Text,
                emailAddressReminder = txtbox_emailAddress.Text,
            };

            // Make patch request to eboekhouden
            ApiRequest.PatchRequest("/relation", data, customerId.ToString());

            // Close this form
            this.Close();
        }
    }
}
