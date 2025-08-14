using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agenda.Classes.Checks;
using Agenda.Classes.Objects;

namespace Agenda.Forms.Agenda
{
    public partial class DetailedAppointmentForm : Form
    {
        private Appointment Appointment;
        public DetailedAppointmentForm()
        {
            InitializeComponent();
        }

        public void LoadInfo(Appointment afspraak)
        {
            Appointment = afspraak;
            lb_details_datum.Text = afspraak.Datum.ToString("dd-MM-yyyy");
            lb_details_tijd.Text = afspraak.Tijd.ToString("HH:mm") + " - " + afspraak.Tijd.AddHours(1).ToString("HH:mm");
            lb_details_naam.Text = afspraak.Naam;
            lb_details_behandeling.Text = afspraak.Behandeling;
            lb_details_beschrijving.Text = afspraak.Beschrijving;
            LabelCheck.AdjustFontSizeToFit(lb_details_naam);
            LabelCheck.AdjustFontSizeToFit(lb_details_beschrijving);
        }

        private async void btn_details_wijzigen_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeAppointmentForm changeAppointment = new ChangeAppointmentForm();
            await changeAppointment.FillComboBox();
            changeAppointment.FillInfo(Appointment);
            changeAppointment.ShowDialog();
        }
    }
}
