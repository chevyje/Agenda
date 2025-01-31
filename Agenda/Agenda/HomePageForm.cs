using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


using Agenda.UserControls;
using Agenda.Properties;
using Agenda.Classes.Objects;
using System.Diagnostics;
using Agenda.Classes;
using Agenda.Classes.Querys;
using Agenda.LocalAppSettings;
using Agenda.Forms;

namespace Agenda
{
    public partial class HomePageForm : Form
    {
        // Class met alle settings
        public static LocalApplicationSettings settings;

        // Lijsten met alle gegevens
        public static List<Customer> Klanten = new List<Customer>();
        public static List<GiftCard> Bonnen = new List<GiftCard>();
        public static List<Appointment> Afspraken = new List<Appointment>();
        public static List<WaitList> WachtLijst = new List<WaitList>();

        // Alle Usercontrol pagina's die maar 1x gebruikt hoeven te worden
        public static UC_Agenda agenda = new UC_Agenda();
        public static UC_Klanten klant = new UC_Klanten();
        public static UC_KadoBonnen UC_bonnen = new UC_KadoBonnen();
        public static UC_Settings UC_settings = new UC_Settings();

        public HomePageForm()
        {
            InitializeComponent();
            LoadAll();
            Settings.Default.dbPath = "C:\\Users\\jurre\\OneDrive\\Projecten\\Agenda\\Agenda.accdb";
            Settings.Default.Save();
        }

        // Roep functies zodat gegevens uit database worden geladen
        public async void LoadAll()
        {
            Settings.Default.Reload();
            if (string.IsNullOrEmpty(Settings.Default.dbPath) || string.IsNullOrEmpty(Settings.Default.SettingsPath))
            {
                AddSettingsForm form = new AddSettingsForm();
                form.ShowDialog();
                LoadAll();
                return;
            }
            // Laad alle gegevens
            settings = await AccessSettings.LoadSettings();
            Afspraken = await AppointmentQuery.GetAppointments();
            Klanten = await CustomerQuery.GetCustomers();
            Bonnen = await GiftCardQuery.GetGiftCards();
            WachtLijst = await WaitListQuery.GetWaitList();

            // Laad alle pagina's 1x
            agenda.LoadInfo();
            klant.LoadInfo();
            UC_bonnen.LoadInfo();
            
            LoadPage("Afspraken");
        }


        private void LoadPage(string a)
        {
            Container.Controls.Clear();
            switch (a)
            {
                case "Afspraken": Container.Controls.Add(agenda); break;
                case "Klanten": Container.Controls.Add(klant); break;
                case "KadoBonnen": Container.Controls.Add(UC_bonnen); break;
                case "Settings": Container.Controls.Add(UC_settings); UC_settings.LoadInfo(); break;
                default: Container.Controls.Add(agenda); break;
            }
        }

        // Buttons
        private void btn_Agenda_Click(object sender, EventArgs e)
        {
            LoadPage("Afspraken");
        }

        private void btn_Klanten_Click(object sender, EventArgs e)
        {
            LoadPage("Klanten");
        }

        private void btn_CadeauBonnen_Click(object sender, EventArgs e)
        {
            LoadPage("KadoBonnen");
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            LoadPage("Settings");
        }
    }
}
