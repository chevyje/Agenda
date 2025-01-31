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
using Agenda.Classes.Querys;

namespace Agenda.UserControls
{
    public partial class UC_KadoBon : UserControl
    {
        GiftCard card;
        public UC_KadoBon()
        {
            InitializeComponent();
        }

        public void loadInfo(GiftCard b)
        {
            card = b;
            if (b == null) { return; }
            lb_BonNum.Text = b.BonId.ToString();
            lb_Waarde.Text = "\u20AC" + b.Waarde.ToString("F2");
        }

        private async void btn_check_Click(object sender, EventArgs e)
        {
            await GiftCardQuery.UpdateGiftCard(card.Id);
        }
    }
}
