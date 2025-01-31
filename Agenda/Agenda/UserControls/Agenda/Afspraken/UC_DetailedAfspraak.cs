using Agenda.Classes.Objects;
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

namespace Agenda.UserControls
{
    public partial class UC_DetailedAfspraak : UserControl
    {
        public UC_DetailedAfspraak()
        {
            InitializeComponent();
        }

        public void LoadInfo(Appointment afspraak)
        {
            lbl_datum.Text = afspraak.Datum.ToString("dd-MM-yyyy");
            if(int.TryParse(afspraak.Lengte.Replace("Minuten", "").Trim(), out int minutes))
            {
                lbl_tijd.Text = $"{afspraak.Tijd:HH:mm} - {afspraak.Tijd.AddMinutes(minutes):HH:mm}";
            }
            else
            {
                lbl_tijd.Text = $"{afspraak.Tijd:HH:mm} - {afspraak.Tijd.AddMinutes(60):HH:mm}";
            }
            lbl_behandeling.Text = afspraak.Behandeling;
        }
    }
}
