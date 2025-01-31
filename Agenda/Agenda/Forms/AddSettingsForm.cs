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

namespace Agenda.Forms
{
    public partial class AddSettingsForm : Form
    {
        public AddSettingsForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.dbPath = txt_PathDb.Text;
            settings.Password = txt_Password.Text;
            settings.SettingsPath = txt_PathSettings.Text;
            settings.Save();

            this.Close();
        }
    }
}
