using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_COMP212
{
    public class Subscriber
    {

        public String Email { get; set; }
        public long phoneNumber { get; set; }

        public static List<String> SubscriberList = new List<string>();
        private int returnValue = 0;
        private string returnMessage = string.Empty;


    }
}
