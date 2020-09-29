using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_COMP212
{
    public class Subscriber
    {

        public String Email {get; set;}
        public long phoneNumber { get; set; }

        public static List<Subscriber> SubscriberList = new List<Subscriber>();
    }
}
