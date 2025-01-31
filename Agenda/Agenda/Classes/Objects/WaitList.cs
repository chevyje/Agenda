using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes.Objects
{
    public class WaitList
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voorkeur { get; set; }

        public WaitList(int Id, string Naam, string Voorkeur)
        {
            this.Id = Id;
            this.Naam = Naam;
            this.Voorkeur = Voorkeur;
        }

    }
}
