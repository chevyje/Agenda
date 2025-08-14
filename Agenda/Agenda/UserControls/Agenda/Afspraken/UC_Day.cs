using Agenda.UserControls;
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

namespace Agenda
{
    public partial class UC_Day : UserControl
    {
        public int afsprakenInDag;
        public UC_Day()
        {
            InitializeComponent();
        }

        public void SetDay(DateTime datum)
        {
            if (datum == DateTime.Today)
            {
                this.BackColor = Colors.currentDay;
            }

            lb_dag.Text = datum.ToString("dd");
        }

        public void SetAfspraken(Appointment afspraak)
        {
            UC_Afspraak UC = new UC_Afspraak();
            afspraakContainer.Controls.Add(UC);
            UC.SetTime(afspraak);
        }

        public void SetDrukteIndex()
        {
            lb_index.Text = afsprakenInDag.ToString();
        }
    }
}
