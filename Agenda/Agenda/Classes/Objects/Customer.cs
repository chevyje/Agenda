using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes.Objects
{
    public class Customer
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string TelefoonNummer { get; set; }
        public string Email { get; set; }
        public DateTime gbDatum { get; set; }

        public Customer(int Id, string Naam, string Adres, string Telefoon, string Email, DateTime gbDatum)
        {
            this.Id = Id;
            this.Naam = Naam;
            this.Adres = Adres;
            this.TelefoonNummer = Telefoon;
            this.Email = Email;
            this.gbDatum = gbDatum;
        }

    }
}
