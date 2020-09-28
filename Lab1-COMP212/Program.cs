using Lab1_COMP212.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Created By: Michael Asemota, Hasan Khan, Michael Magtibay, Prince Chauhan
/// 
/// This is an application that mimics a notification management system
/// </summary>
namespace Lab1_COMP212
{
    static class Program
    {

        public static ManageSubscription manageSub;
        public static Form1 notifManager;
        public static Publish_Notifcation publishNotif;
        public static Subscriber subscriber;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            manageSub = new ManageSubscription();
            notifManager = new Form1();
            publishNotif = new Publish_Notifcation();
            subscriber = new Subscriber();

            Application.Run(notifManager);
        }
    }
}
