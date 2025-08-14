using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Classes.Objects;

namespace Agenda.Classes.Checks
{
    internal class CustomerCheck
    {
        public static bool ExistingCustomer (string Name, int id = -1)
        {
            Name.Replace(" ", "");
            foreach (Customer c in HomePageForm.Klanten)
            {
                string cname = c.name.Replace(" ", "");
                if(cname == Name && c.id != id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
