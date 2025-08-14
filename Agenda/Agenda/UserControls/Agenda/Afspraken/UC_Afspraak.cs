using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agenda.Classes.Objects;
using Agenda.Forms.Agenda;

namespace Agenda.UserControls
{
    public partial class UC_Afspraak : UserControl
    {
        Appointment afspraak;
        public UC_Afspraak()
        {
            InitializeComponent();
        }

        public void SetTime(Appointment afspraak)
        {
            this.afspraak = afspraak;
            if (int.TryParse(afspraak.Lengte.Replace("Minuten", "").Trim(), out int minutes))
            {
                lb_Time.Text = $"{afspraak.Tijd:HH:mm} - {afspraak.Tijd.AddMinutes(minutes):HH:mm}";
            }
            else
            {
                lb_Time.Text = $"{afspraak.Tijd:HH:mm} - {afspraak.Tijd.AddMinutes(60):HH:mm}";
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            DetailedAppointmentForm form = new DetailedAppointmentForm();
            form.LoadInfo(afspraak);
            form.ShowDialog();
        }
    }
}
