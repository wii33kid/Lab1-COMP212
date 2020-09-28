using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_COMP212.Views
{
    public partial class ManageSubscription : Form
    {
        public ManageSubscription()
        {
            InitializeComponent();
        }

        private void chkemail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkemail.Checked)
            {
                txtemail.Enabled = true;
            }
            else
            {
                txtemail.Enabled = false;
            }

        }

        private void chksms_CheckedChanged(object sender, EventArgs e)
        {
            if (chksms.Checked)
            {
                txtsms.Enabled = true;
            }
            else
            {
                txtsms.Enabled = false;
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Subscriber subscriber = new Subscriber();
            subscriber.Email = txtemail.Text;
            subscriber.phoneNumber = Convert.ToInt32(txtsms.Text);

            Subscriber.SubscriberList.Add(subscriber);
            Program.publishNotif.Show();
            this.Hide();

        }
    }
}
