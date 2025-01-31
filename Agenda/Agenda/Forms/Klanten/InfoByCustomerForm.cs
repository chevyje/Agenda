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
using Agenda.UserControls;

namespace Agenda.Forms.Klanten
{
    public partial class InfoByCustomerForm : Form
    {
        public InfoByCustomerForm()
        {
            InitializeComponent();


        }

        public void LoadInfo(Customer k, List<Appointment> a)
        {
            UC_Klant ucKlant = new UC_Klant();
            container.Controls.Clear();
            container.Controls.Add(ucKlant);
            ucKlant.loadInfo(k);

            foreach (Appointment aspraak in a)
            {
                UC_DetailedAfspraak ucAfspraak = new UC_DetailedAfspraak();
                container.Controls.Add(ucAfspraak);
                ucAfspraak.LoadInfo(aspraak);
            }
        }
    }
}
