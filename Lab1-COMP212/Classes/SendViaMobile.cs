using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_COMP212.Classes
{
    class SendViaMobile
    {
        public String mobile { get; set; }
        public int i = 1;

        public SendViaMobile() { }
        public SendViaMobile(string mobile)
        {
            this.mobile = mobile;
        }

        //subscribe
        public int Subscribe(List<string> subscriberList)
        {
            bool mobilecheck = subscriberList.Contains(this.mobile);
            int i = 0;

            if (mobilecheck)
            {
                i = 0;
            }
            else
            {
                subscriberList.Add(this.mobile);

            }

            return i;
        }

        //Unsubscribe 
        public int Unsubscribe(List<string> subscriberList)
        {
            int i = subscriberList.IndexOf(this.mobile);

            if (i > 0 || i == 0)
            {
                subscriberList.RemoveAt(i);

            }

            return i;
        }

    }
}
