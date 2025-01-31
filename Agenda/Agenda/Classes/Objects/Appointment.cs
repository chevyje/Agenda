using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes.Objects
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public DateTime Tijd { get; set; }
        public string Lengte { get; set; }
        public string Naam { get; set; }
        public string Behandeling { get; set; }
        public string Beschrijving { get; set; }
        public Appointment(int id, DateTime datum, DateTime tijd, string lengte, string naam, string behandeling, string beschrijving)
        {
            Id = id;
            Datum = datum;
            Tijd = tijd;
            Lengte = lengte;
            Naam = naam;
            Behandeling = behandeling;
            Beschrijving = beschrijving;
        }
    }
}
