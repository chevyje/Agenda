using Agenda.Classes.Checks;
using Agenda.Classes.Objects;
using Agenda.Classes.Querys;
using Agenda.LocalAppSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agenda.Forms.Agenda
{
    public partial class ChangeAppointmentForm : Form
    {
        private int chosenId;
        public ChangeAppointmentForm()
        {
            InitializeComponent();
        }

        public async Task FillComboBox()
        {
            LocalApplicationSettings appSettings = await AccessSettings.LoadSettings();
            combox_Type.Items.Clear();
            combox_Name.Items.Clear();
            combox_Time.Items.Clear();
            combox_Length.Items.Clear();

            foreach (Customer c in HomePageForm.Klanten)
            {
                combox_Name.Items.Add(c.Naam);
            }

            foreach (string s in appSettings.ChosableTime)
            {
                combox_Time.Items.Add(s);
            }

            foreach (string s in appSettings.TypesOfMassages)
            {
                combox_Type.Items.Add(s);
            }

            foreach (string s in appSettings.Length)
            {
                combox_Length.Items.Add($"{s} Minuten");
            }
        }

        public void FillInfo(Appointment a)
        {
            chosenId = a.Id;
            if (combox_Name.Items.Contains(a.Naam)) { combox_Name.SelectedItem = a.Naam; }
            else { combox_Name.Text = a.Naam; }

            if (combox_Time.Items.Contains(a.Tijd.ToString("HH:mm"))) { combox_Time.SelectedItem = a.Tijd.ToString("HH:mm"); }
            else { combox_Time.Text = a.Tijd.ToString("HH:mm"); }

            if (combox_Type.Items.Contains(a.Behandeling)) { combox_Type.SelectedItem = a.Behandeling; }
            else { combox_Type.Text = a.Behandeling; }

            if (combox_Length.Items.Contains(a.Lengte)) { combox_Length.SelectedItem = a.Lengte; }
            else { combox_Length.Text = a.Lengte; }

            dateTime.Value = a.Datum;
            txtbox_Description.Text = a.Beschrijving;
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(combox_Length.Text) ||
                string.IsNullOrWhiteSpace(combox_Name.Text) ||
                string.IsNullOrWhiteSpace(combox_Time.Text) ||
                string.IsNullOrWhiteSpace(combox_Type.Text) ||
                dateTime.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Een of meerdere velden zijn leeg");
                return;
            }

            // Make a appointment with all info
            Appointment a = new Appointment(chosenId, dateTime.Value, DateTime.Parse(combox_Time.Text), combox_Length.Text, combox_Name.Text, combox_Type.Text, txtbox_Description.Text);

            // Check for mistakes
            if (AppointmentCheck.DubbleAppointments(a, chosenId) == true)
            {
                MessageBox.Show("Er is op deze datum al een afspraak gepland");
                return;
            }

            // Make changes in the database
            await AppointmentQuery.UpdateAppointment(a);
            this.Close();
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            // Give a popup if they are sure they want to delete
            DialogResult result = MessageBox.Show("Weet je zeker dat je de afspraak wilt verwijderen?", "Bevestiging", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                await AppointmentQuery.DeleteAppointment(chosenId);
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                Console.WriteLine("User chose No");
            }
        }
    }
}
