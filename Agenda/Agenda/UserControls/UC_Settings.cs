using Agenda.LocalAppSettings;
using Agenda.Properties;
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
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
            LoadInfo();
        }

        public async void LoadInfo()
        {
            LocalApplicationSettings appSettings = await AccessSettings.LoadSettings();
            Settings settings = Properties.Settings.Default;

            txt_PathDb.Text = settings.dbPath.Replace(@"\\", @"\"); ;
            txt_Password.Text = settings.Password;
            txt_PathSettings.Text = settings.SettingsPath.Replace(@"\\", @"\"); ;
            txt_BonId.Text = settings.LastBonNum.ToString("D3");
            txt_ChosableTime.Text = StringFromList(appSettings.ChosableTime);
            txt_TypesOfMassages.Text = StringFromList(appSettings.TypesOfMassages);
            txt_Length.Text = StringFromList(appSettings.Length);
        }

        private string RemoveEnter(string s)
        {
            return s.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
        }

        private int StringToInt(string s)
        {
            s.Trim();
            if (int.TryParse(s, out int result))
            {
                return result;
            }
            else
            {
                MessageBox.Show("Het bonnummer wat is ingevuld is niet in het juiste formaat");
                return -1;
            }
        }

        private string StringFromList(List<string> a)
        {
            string time = "";
            foreach (string s in a)
            {
                time += $"{s}, \n";
            }
            return time;
        }

        private List<string> ListFormString(string s)
        {
            List<string> result = s.Split(',').Select(a => a.Trim()).ToList();
            result.RemoveAll(a => a.Length <= 1);
            return result;
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            Settings settings = Properties.Settings.Default;

            settings.dbPath = txt_PathDb.Text;
            settings.Password = txt_Password.Text;
            settings.SettingsPath = txt_PathSettings.Text;
            if(StringToInt(txt_BonId.Text) == -1) { return; }
            settings.LastBonNum = StringToInt(txt_BonId.Text);
            settings.Save();
            await AccessSettings.SaveSettings(new LocalApplicationSettings(chosableTime: ListFormString(txt_ChosableTime.Text), typesOfMassages: ListFormString(txt_TypesOfMassages.Text), length: ListFormString(txt_Length.Text)));
        }
    }
}
