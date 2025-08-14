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
using Agenda.Forms.Agenda;
using Agenda.Forms.Klanten;

namespace Agenda
{
    public partial class UC_Klanten : UserControl
    {
        public UC_Klanten()
        {
            InitializeComponent();
            LoadInfo();
        }

        public void LoadInfo() {
            KlantenContainer.Controls.Clear();
            KlantenContainer.SuspendLayout();
            foreach (Customer k in HomePageForm.Klanten)
            {
                UC_Klant klant = new UC_Klant();
                KlantenContainer.Controls.Add(klant);
                klant.loadInfo(k);
            }
            KlantenContainer.ResumeLayout();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.TopMost = true;
            search.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
