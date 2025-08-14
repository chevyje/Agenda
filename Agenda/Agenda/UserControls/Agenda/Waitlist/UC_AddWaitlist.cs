using Agenda.Forms.Agenda.Waitlist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.UserControls.Agenda.Waitlist
{
    public partial class UC_AddWaitlist : UserControl
    {
        public UC_AddWaitlist()
        {
            InitializeComponent();
        }

        private void AddToWaitlist(object sender, EventArgs e)
        {
            WaitlistForm form = new WaitlistForm();
            form.ShowDialog();
        }
    }
}
