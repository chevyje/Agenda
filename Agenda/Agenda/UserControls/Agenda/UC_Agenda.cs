using Agenda.UserControls;
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

using Agenda.Classes.Objects;
using Agenda.Forms.Agenda;

namespace Agenda
{
    public partial class UC_Agenda : UserControl
    {
        DateTime datum;
        List<Appointment> afspraakList = HomePageForm.Afspraken;
        List<Appointment> afspraken = new List<Appointment>();
        Appointment selectedAfspraak;

        public UC_Agenda()
        {
            InitializeComponent();
            datum = DateTime.Today;
            LoadInfo();
        }
        public void LoadInfo()
        {
            afspraakList = HomePageForm.Afspraken;
            FilterAfspraakPerMonth();
            LoadDays();
        }

        public void DetailedAfspraak(Appointment afspraak)
        {
            selectedAfspraak = afspraak;
            afspraakDetails.Visible = true;
            lb_details_datum.Text = afspraak.Datum.ToString("dd-MM-yyyy");
            lb_details_tijd.Text = afspraak.Tijd.ToString("HH:mm") + " - " + afspraak.Tijd.AddHours(1).ToString("HH:mm");
            lb_details_naam.Text = afspraak.Naam;
            lb_details_behandeling.Text = afspraak.Behandeling;
            lb_details_beschrijving.Text = afspraak.Beschrijving;
            AdjustFontSizeToFit(lb_details_naam);
            AdjustFontSizeToFit(lb_details_beschrijving);
        }

        private void AdjustFontSizeToFit(Label label)
        {
            float fontSize = label.Font.Size;

            using (Graphics g = label.CreateGraphics())
            {
                Size labelSize = label.ClientSize;
                SizeF textSize;

                while (fontSize > 1)
                {
                    using (Font font = new Font(label.Font.FontFamily, fontSize))
                    {
                        textSize = g.MeasureString(label.Text, font, labelSize.Width);

                        if (textSize.Height <= labelSize.Height)
                        {
                            label.Font = font;
                            break;
                        }

                        fontSize -= 1;
                    }
                }
            }
        }

        public void FilterAfspraakPerMonth()
        {
            afspraken.Clear();
            foreach (Appointment afspr in afspraakList)
            {
                if (afspr.Datum.Month == datum.Month)
                {
                    afspraken.Add(afspr);
                }
            }

        }
        private int GetDaysBefore(string DayOfWeek)
        {
            switch (DayOfWeek)
            {
                case "Monday": return 0;
                case "Tuesday": return 1;
                case "Wednesday": return 2;
                case "Thursday": return 3;
                case "Friday": return 4;
                case "Saturday": return 5;
                case "Sunday": return 6;
                default: return 0;
            }
        }
        private string GetMonthName(int MonthNumber)
        {
            switch(MonthNumber){
                case 1: return "Januari";
                case 2: return "Februari";
                case 3: return "Maart";
                case 4: return "April";
                case 5: return "Mei";
                case 6: return "Juni";
                case 7: return "Juli";
                case 8: return "Augustus";
                case 9: return "September";
                case 10: return "Oktober";
                case 11: return "November";
                case 12: return "December";
                default: return null;
            }
        }
        public void LoadDays()
        {
            DagenContainer.Controls.Clear();
            int aantalDagen = 42;

            // Past de labels van maand en jaar aan naar het juiste getal
            lb_Maand.Text = GetMonthName(datum.Month);
            lb_Jaar.Text = datum.Year.ToString();

            // krijg de dagen voor het begin van de maand om deze eerder toe te voegen met een andere kleur
            // Krijg hoeveel dagen eerst moeten voor de maand begint
            DateTime beginOfMonth = new DateTime(datum.Year, datum.Month, 1);
            string dayInWeek = beginOfMonth.DayOfWeek.ToString();
            int daysbefore = GetDaysBefore(dayInWeek);

            // Krijg hoeveel dagen vorige maand had en tel af
            int PreviousMonth = datum.AddMonths(-1).Month;
            int daysInPreviousMonth = DateTime.DaysInMonth(datum.Year, PreviousMonth);
            for (int i = 0; i < daysbefore; i++)
            {
                DateTime dateTime = new DateTime(datum.Year, PreviousMonth, daysInPreviousMonth - daysbefore + i + 1);
                if(dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    continue;
                }
                UC_Day DayBefore = new UC_Day();
                DayBefore.BackColor = Color.FromArgb(169, 201, 202);
                DagenContainer.Controls.Add(DayBefore);
                DayBefore.SetDay(dateTime);

                aantalDagen--;
            }

            // geeft alle dagen in de maand
            int daysInCurrentMonth = DateTime.DaysInMonth(datum.Year, datum.Month);
            for (int i = 0; i < daysInCurrentMonth; i++)
            {
                aantalDagen--;
                DateTime DayOfMonth = new DateTime(datum.Year, datum.Month, i + 1);
                if (DayOfMonth.DayOfWeek == DayOfWeek.Sunday || DayOfMonth.DayOfWeek == DayOfWeek.Saturday)
                {
                    continue;
                }
                UC_Day Day = new UC_Day();
                DagenContainer.Controls.Add(Day);
                if (afspraken.Count != 0)
                {
                    foreach (Appointment afspr in afspraken)
                    {
                        if (DayOfMonth == afspr.Datum)
                        {
                            Day.SetDay(afspr.Datum);
                            Day.SetAfspraken(afspr);
                            Day.afsprakenInDag++;
                            Day.SetDrukteIndex();
                        }
                        else
                        {
                            Day.SetDay(DayOfMonth);
                        }
                    }
                }
                else
                {
                    Day.SetDay(DayOfMonth);
                }
            }

            //Geeft alle legen vakken de dagen van volgende maand
            int NextMonth = datum.AddMonths(1).Month;
            for (int i = 0; i < aantalDagen; i++)
            {
                DateTime dateTime = new DateTime(datum.Year, NextMonth, i + 1);
                if (dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    continue;
                }
                UC_Day DayBefore = new UC_Day();
                DayBefore.BackColor = Color.FromArgb(169, 201, 202);
                DagenContainer.Controls.Add(DayBefore);
                DayBefore.SetDay(dateTime);
            }
        }

        // Buttons 
        private void NextMonth_Click(object sender, EventArgs e)
        {
            datum = datum.AddMonths(1);
            FilterAfspraakPerMonth();
            LoadDays();
        }

        private void PreviousMonth_Click(object sender, EventArgs e)
        {
            datum = datum.AddMonths(-1);
            FilterAfspraakPerMonth();
            LoadDays();
        }

        public void lb_details_close_Click(object sender, EventArgs e)
        {
            afspraakDetails.Visible = false;
        }

        private async void btn_details_wijzigen_Click(object sender, EventArgs e)
        {
            afspraakDetails.Visible = false;
            ChangeAppointmentForm changeAppointment = new ChangeAppointmentForm();
            await changeAppointment.FillComboBox();
            changeAppointment.FillInfo(selectedAfspraak);
            changeAppointment.ShowDialog();
        }

        private void btn_PlusAfspraak_Click(object sender, EventArgs e)
        {
            AddAppointmentForm makeAppointment = new AddAppointmentForm();
            makeAppointment.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.TopMost = true;
            search.ShowDialog();
        }

        // Nieuwe gemaakt afsrpaak toevoegen
        public void AddNewAfspraak(List<Appointment> afspraak)
        {
            afspraakList = afspraak;
            FilterAfspraakPerMonth();
            LoadDays();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
