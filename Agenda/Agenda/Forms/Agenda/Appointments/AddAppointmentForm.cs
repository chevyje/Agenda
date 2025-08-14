using Agenda.Classes.Checks;
using Agenda.Classes.Objects;
using Agenda.Classes.Querys;
using Agenda.LocalAppSettings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Forms.Agenda
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
            FillCombobox();
            dateTimePicker.Value = DateTime.Today;
            dateTimePicker.MinDate = DateTime.Today.AddDays(-1);
        }

        private async void FillCombobox()
        {
            LocalApplicationSettings appSettings = await AccessSettings.LoadSettings();
            combox_time.Items.Clear();
            combox_type.Items.Clear();
            combox_length.Items.Clear();
            FillComboBox.CustomersNames(combox_name);
            foreach (string s in appSettings.ChosableTime)
            {
                combox_time.Items.Add(s);
            }

            foreach (string s in appSettings.TypesOfMassages)
            {
                combox_type.Items.Add(s);
            }

            foreach (string s in appSettings.Length)
            {
                combox_length.Items.Add($"{s} Minuten");
            }
        }

        private async void Btn_makeAppointment_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(combox_length.Text) ||
                string.IsNullOrWhiteSpace(combox_name.Text) ||
                string.IsNullOrWhiteSpace(combox_time.Text) ||
                string.IsNullOrWhiteSpace(combox_type.Text) ||
                dateTimePicker.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Een of meerdere velden zijn leeg");
                return;
            }

            // Make a appointment with the afspraak class
            Appointment a = new Appointment(0, dateTimePicker.Value, DateTime.Parse(combox_time.Text), combox_length.Text, combox_name.Text, combox_type.Text, txtbox_description.Text);

            //Check for dubble appointments & ???
            if (AppointmentCheck.DubbleAppointments(a) == true)
            {
                MessageBox.Show("Er is op deze datum en tijd al een afspraak ingepland");
                return;
            }

            // Insert appointment into the database
            await AppointmentQuery.InsertAppointment(a);

            this.Close();
        }
    }
}
