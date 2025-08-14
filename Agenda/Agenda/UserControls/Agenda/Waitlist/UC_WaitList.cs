using Agenda.Classes.Objects;
using Agenda.Forms.Agenda.Waitlist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.UserControls.Agenda
{
    public partial class UC_WaitList : UserControl
    {
        WaitList w;
        public UC_WaitList()
        {
            InitializeComponent();
        }

        public void LoadInfo(WaitList w)
        {
            this.w = w;
            string[] naamDelen = w.Naam.Split(' ');
            if(naamDelen.Length <= 1)
            {
                lbl_name.Text = w.Naam;
            }
            else
            {
                lbl_name.Text = naamDelen[0].Substring(0, 1) + ". ";
                for (int i = 1; i < naamDelen.Length; i++)
                {
                    lbl_name.Text += naamDelen[i] + " ";
                }
            }
            lbl_voorkeur.Text = w.Voorkeur;
        }

        private void Edit(object sender, EventArgs e)
        {
            WaitlistForm form  = new WaitlistForm();
            form.ChangeWaitlist(w);
            form.ShowDialog();
        }
    }
}
