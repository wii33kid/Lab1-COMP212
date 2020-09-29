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
using Lab1_COMP212.Classes;

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

            SendViaEmail sendViaEmail = new SendViaEmail();
            SendViaMobile sendViaMobile = new SendViaMobile();
            int correctSyntax = 0;
            int expected = 0;

            if (chkemail.Checked)
            {
                expected++;
            }
            if (chksms.Checked)
            {
                expected++;
            }
            //sendViaMobile.mobile = mobile;

            if (chkemail.Checked)
            {
                String email = txtemail.Text;
                if (IsValid(email, "email") && !SendViaEmail.emailList.Contains(email))
                {
                    SendViaEmail.emailList.Add(email);
                    correctSyntax++;
                }
                else
                {
                    lblinvalid.ForeColor = Color.Red;
                }
            }
            

            if (chksms.Checked)
            {
                String mobile = txtsms.Text;
                if (!SendViaMobile.mobileList.Contains(mobile) && IsValid(mobile, "phone"))
                {
                    SendViaMobile.mobileList.Add(mobile);
                    correctSyntax++;
                }
                else
                {
                    MessageBox.Show("Invalid phone number");
                }
            }

            if (expected.Equals(correctSyntax))
            {
                Program.notifManager.Show();
                this.Hide();
            }
        }
        //validation Email & Phone
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
                        "^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]\\d{3}[\\s.-]\\d{4}$");
                    break;
            }

            return isValid;
        }

        private void btnun_Click(object sender, EventArgs e)
        {

            if (chkemail.Checked)
            {
                String email = txtemail.Text;
                if (IsValid(email, "email") && SendViaEmail.emailList.Contains(email))
                {
                    SendViaEmail.emailList.Remove(email);
                    MessageBox.Show("Email removed from list");
                }
                else
                {
                    lblinvalid.ForeColor = Color.Red;
                }
            }


            if (chksms.Checked)
            {
                String mobile = txtsms.Text;
                if (SendViaMobile.mobileList.Contains(mobile) && IsValid(mobile, "phone"))
                {
                    SendViaMobile.mobileList.Remove(mobile);
                    MessageBox.Show("Mobile is removed from list");
                }
                else
                {
                    MessageBox.Show("Invalid phone number");
                }
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Program.notifManager.Show();
            this.Hide();
        }
    }

}