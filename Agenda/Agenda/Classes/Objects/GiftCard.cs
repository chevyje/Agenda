using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes.Objects
{
    public class GiftCard
    {
        public int Id { get; set; }
        public int BonId { get; set; }
        public float Waarde { get; set; }
        public bool isGebruikt { get; set; }
        public GiftCard(int Id, int BonId, float Waarde, bool isGebruikt)
        {
            this.Id = Id;
            this.BonId = BonId;
            this.Waarde = Waarde;
            this.isGebruikt = isGebruikt;
        }
    }
}
