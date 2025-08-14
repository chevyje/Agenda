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

namespace Agenda.Forms.Agenda.Waitlist
{
    public partial class WaitlistForm : Form
    {
        WaitList w;
        public WaitlistForm()
        {
            InitializeComponent();
            FillComboBox.CustomersNames(combox_name);
        }

        public void ChangeWaitlist(WaitList w)
        {
            this.w = w;
            combox_name.Text = w.Naam;
            txtbox_voorkeur.Text = w.Voorkeur;
            aanpassen.Visible = true;
            verwijderen.Visible = true;
            toevoegen.Visible = false;
        }

        private async void InsertWaitlist(object sender, EventArgs e)
        {
            CheckEmpty();
            WaitList a = new WaitList(0, combox_name.Text, txtbox_voorkeur.Text);

            await WaitListQuery.InsertWaitList(a);
            this.Close();
        }

        private async void UpdateWaitlist(object sender, EventArgs e)
        {
            CheckEmpty();
            WaitList a = new WaitList(0, combox_name.Text, txtbox_voorkeur.Text);

            await WaitListQuery.UpdateWaitList(a);
            this.Close();
        }

        private async void DeleteWaitlist(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet je zeker dat je deze persoon \nuit de wachtlijst wilt verwijderen?", "Bevestiging", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                await WaitListQuery.DeleteWaitList(w.Id);
                this.Close();
            }
        }

        private void CheckEmpty()
        {
            if (string.IsNullOrWhiteSpace(combox_name.Text) ||
                string.IsNullOrWhiteSpace(txtbox_voorkeur.Text))
            {
                MessageBox.Show("Een of meerdere velden zijn leeg");
                return;
            }
        }
    }
}
