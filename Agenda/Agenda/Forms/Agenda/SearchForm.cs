using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Agenda.Classes;
using Agenda.Classes.Objects;
using Agenda.Forms.Klanten;

namespace Agenda.Forms.Agenda
{
    public partial class SearchForm : Form
    {
        private List<Customer> klanten = HomePageForm.Klanten;
        private List<Appointment> afspraken = HomePageForm.Afspraken;
        public SearchForm()
        {
            InitializeComponent();
            foreach (Customer k in klanten)
            {
                combox_klanten.Items.Add(k.name);
            }
        }

        private void btn_zoeken_Click(object sender, EventArgs e)
        {
            List<Appointment> afsprakenOpNaam = new List<Appointment>();
            Customer klantInfo = null;
            foreach (Appointment a in afspraken)
            {
                if (a.Naam.Trim() == combox_klanten.Text.Trim())
                {
                    afsprakenOpNaam.Add(a);
                }
            }

            foreach (Customer k in klanten)
            {
                if(k.name.Trim() == combox_klanten.Text.Trim())
                {
                    klantInfo = k;
                }
            }

            if (klantInfo == null)
            {
                MessageBox.Show("Er is geen klant met deze naam, controleer of je het goed hebt gespeld");
                return;
            }

            this.Hide();

            InfoByCustomerForm klantInfoForm = new InfoByCustomerForm();
            klantInfoForm.LoadInfo(klantInfo, afsprakenOpNaam);
            klantInfoForm.TopMost = true;
            klantInfoForm.Show();
        }
    }
}
