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
        public static bool LegitEmail(string Email)
        {
            return !Email.Contains("@");
        }

        public static bool DutchPhoneNumber(string PhoneNumber)
        {
            return !PhoneNumber.Contains("06") && PhoneNumber.Length <= 10 && PhoneNumber.Length >= 11;
        }

        public static bool ExistingCustomer (string Name, int id = -1)
        {
            Name.Replace(" ", "");
            foreach (Customer c in HomePageForm.Klanten)
            {
                string cname = c.Naam.Replace(" ", "");
                if(cname == Name && c.Id != id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
