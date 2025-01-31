using Agenda.Classes.Querys;
using Agenda.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Forms.KadoBonnen
{
    public partial class AddGiftCardForm : Form
    {
        int BonId;
        public AddGiftCardForm()
        {
            InitializeComponent();
        }

        public void LoadInfo()
        {
            int LastBonNum = Properties.Settings.Default.LastBonNum;
            if (LastBonNum >= 999) { LastBonNum = 0; }
            string BonNum = $"{DateTime.Now:MM}{(LastBonNum + 1).ToString("D3")}{DateTime.Now:yy}{DateTime.Now:dd}";
            BonId = Convert.ToInt32(BonNum);
            lbl_BonId.Text = BonNum;
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_waarde.Text)) { MessageBox.Show("Er is geen waarde ingevuld"); return; }
            Properties.Settings.Default.LastBonNum++;
            Properties.Settings.Default.Save();

            float result;
            if (float.TryParse(txtbox_waarde.Text.Replace(".", ","), out result))
            {
                await GiftCardQuery.InsertGiftCard(BonId, result);
                this.Close();
            }
            else
            {
                MessageBox.Show("De waarde die is ingevuld kan niet worden opgeslagen");
            }
        }
    }
}
