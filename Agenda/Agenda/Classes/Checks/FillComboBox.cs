using Agenda.Classes.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Classes.Checks
{
    internal class FillComboBox
    {
        public static void CustomersNames(ComboBox combo)
        {
            combo.Items.Clear();
            foreach (Customer c in HomePageForm.Klanten)
            {
                combo.Items.Add(c.name);
            }
        }
    }
}
