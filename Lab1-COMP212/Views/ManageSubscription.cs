using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            subscriber.phoneNumber = txtsms.Text;
         
            Subscriber.SubscriberList.Add(subscriber);
            Program.publishNotif.Show();
            this.Hide();

        }        //validation Email & Phone
             private bool IsValid(string _inputValue, string _value)
        {
            bool isValid = true;

            switch (_value.ToLower())
            {
                case "email":
                    isValid = Regex.IsMatch(_inputValue,
                        "^(\\D)+(\\w)*((\\.(\\w)+)?)+@(\\D)+(\\w)*((\\.(\\D)+(\\w)*)+)?(\\.)[a-z]{2,}$");
                    break;
                case "phone":
                    isValid = Regex.IsMatch(_inputValue,
                        "^(\\d{3}) \\d{3}-\\d{2}\\d{2}$");
                    break;
            }

            return isValid;
        }
    }
       
}
