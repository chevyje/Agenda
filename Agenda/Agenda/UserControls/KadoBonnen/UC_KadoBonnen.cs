using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Forms.KadoBonnen;

using Agenda.Classes.Objects;

namespace Agenda.UserControls
{
    public partial class UC_KadoBonnen : UserControl
    {
        public UC_KadoBonnen()
        {
            InitializeComponent();
            LoadInfo();
        }

        public void LoadInfo()
        {
            if(HomePageForm.Bonnen == null) { return; }
            BonnenContainer.Controls.Clear();
            foreach (GiftCard b in HomePageForm.Bonnen)
            {
                if (b.isGebruikt == true) { continue; }
                UC_KadoBon bon = new UC_KadoBon();
                BonnenContainer.Controls.Add(bon);
                bon.loadInfo(b);
            }

        }

        private void btn_AddGiftCard_Click(object sender, EventArgs e)
        {
            AddGiftCardForm form = new AddGiftCardForm();
            form.LoadInfo();
            form.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
