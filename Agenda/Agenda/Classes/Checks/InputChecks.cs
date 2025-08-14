using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Classes.Checks
{
    internal static class InputChecks
    {
        public static Boolean ValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            try 
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch 
            {
                return false;
            }
        }

        public static Boolean ValidPhoneNumber(string nummer)
        {
            if (string.IsNullOrEmpty(nummer)) return false;

            nummer.Replace(" ", "");
            nummer.Replace("-", "");
            nummer.Replace("+", "");
            if (nummer.Length < 9 || nummer.Length > 11) return false;
            return true;
        }

        public static Boolean emptyFields(Guna.UI2.WinForms.Guna2TextBox[] requiredFields)
        {
            if (requiredFields.Any(tb => string.IsNullOrWhiteSpace(tb.Text)))
            {
                DialogResult result = MessageBox.Show("Een of meerdere waardes zijn niet ingevuld! \n\n Weet je zeker dat je door wilt gaan?", "Bevestiging", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) return false;
                else return true;
            }
            else return true;
        }
    }
}
