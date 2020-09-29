using Lab1_COMP212.Classes;
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
    public partial class Publish_Notifcation : Form
    {
        public Publish_Notifcation()
        {
            InitializeComponent();
        }

        private void txtcontent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpub_Click(object sender, EventArgs e)
        {
            //using textbox to send to publishMessage variable
            string publishMessage = txtcontent.Text;
            string message = string.Empty;

            del d1 = DelegateMethod1;
            d1(message, publishMessage);

        }

        public delegate void del(string msg, string publishMsg);

        public static void DelegateMethod1(string message, string publishMessage)
        {
            foreach (String subscriber in SendViaEmail.emailList)
            {
                message += $"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - " +
                    $"The message {publishMessage} has been sent to {subscriber}" +
                    Environment.NewLine;
            }

            foreach (String subscriber in SendViaMobile.mobileList)
            {
                message += $"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - " +
                    $"The message {publishMessage} has been sent to {subscriber}" +
                    Environment.NewLine;
            }

            //shows the message box :)
            MessageBox.Show(message);
        }


        private void btnexit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
