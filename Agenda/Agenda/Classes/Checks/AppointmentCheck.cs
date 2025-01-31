using Agenda.Classes.Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes.Checks
{
    internal class AppointmentCheck
    {
        public static bool DubbleAppointments(Appointment a, int id = -1)
        {
            foreach (Appointment appointment in HomePageForm.Afspraken)
            {
                if (appointment.Datum.Date == a.Datum.Date && appointment.Tijd.TimeOfDay == a.Tijd.TimeOfDay && appointment.Id != id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
