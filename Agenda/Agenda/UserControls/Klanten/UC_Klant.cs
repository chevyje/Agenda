using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agenda.Classes.Objects;
using Agenda.Forms.Klanten;

namespace Agenda
{
    public partial class UC_Klant : UserControl
    {
        Customer customer;
        public UC_Klant()
        {
            InitializeComponent();
        }

        public void loadInfo(Customer k)
        {
            if (k == null) {return;}
            customer = k;
            lb_Naam.Text = k.Naam;
            lb_gbDatum.Text = k.gbDatum.ToString("dd-MM-yyyy");
            lb_Nummer.Text = k.TelefoonNummer;
            lb_Email.Text = k.Email;
            lb_Adres.Text = k.Adres;
            AdjustFontSizeToFit(lb_Naam);
            AdjustFontSizeToFit(lb_Email);
            AdjustFontSizeToFit(lb_Adres);
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

        private void btn_change_Click(object sender, EventArgs e)
        {
            ChangeCustomerForm form = new ChangeCustomerForm();
            form.LoadInfo(customer);
            form.ShowDialog();
        }
    }
}
