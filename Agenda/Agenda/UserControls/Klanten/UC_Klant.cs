using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Classes;
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

        public void loadInfo(Customer c)
        {
            if (c == null) return;
            customer = c;

            txt_name.Text = c.name;

            txt_address.Text = c.address;
            txt_postalCode.Text = c.postalCode;
            txt_city.Text = c.city;

            int emptyCount = 0;
            if (string.IsNullOrEmpty(c.mobilePhoneNumber)) emptyCount++;
            if (string.IsNullOrEmpty(c.phoneNumber)) emptyCount++;
            switch (emptyCount)
            {
                case 0:
                    txt_nummer1.Text = c.mobilePhoneNumber;
                    txt_nummer2.Text = c.phoneNumber;
                    break;
                case 1:
                    if (string.IsNullOrEmpty(c.mobilePhoneNumber))
                    {
                        lbl_nummer1.Text = "Vast nummer:";
                        txt_nummer1.Text = c.phoneNumber;
                    }
                    if(string.IsNullOrEmpty(c.phoneNumber))
                    {
                        lbl_nummer1.Text = "Mobiel nummer:";
                        txt_nummer1.Text = c.mobilePhoneNumber;
                    }
                    lbl_nummer2.Visible = false;
                    txt_nummer2.Visible = false;
                    break;
                case 2:
                    lbl_nummer1.Visible = false;
                    txt_nummer1.Visible = false;
                    lbl_nummer2.Visible = false;
                    txt_nummer2.Visible = false;
                    break;
            }
            txt_emailAddress.Text = c.emailAddress;
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
