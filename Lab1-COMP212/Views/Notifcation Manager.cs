using Lab1_COMP212.Classes;
using Lab1_COMP212.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1_COMP212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.manageSub.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (SendViaEmail.emailList.Count.Equals(0) || SendViaMobile.mobileList.Equals(0))
            {
                btnpn.Enabled = false;
            }
            else
            {
                btnpn.Enabled = true;
            }
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (SendViaEmail.emailList.Count.Equals(0) && SendViaMobile.mobileList.Count.Equals(0))
            {
                btnpn.Enabled = false;
            }
            else
            {
                btnpn.Enabled = true;
            }
        }

        private void btnpn_Click(object sender, EventArgs e)
        {
            Program.publishNotif.Show();
            this.Hide();
        }
    }
}
