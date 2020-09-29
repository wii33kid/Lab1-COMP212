using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_COMP212.Classes
{
    class SendViaEmail
    {
       private string EmailAddress { get; set; }
        private int i = 1;

        public SendViaEmail() { }
        public SendViaEmail(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }

        public int Subscribe(List<string> _subscriberList)
        {
            bool _checkEmail = _subscriberList.Contains(this.EmailAddress);
            int i = 0;

            if (_checkEmail)
            {
                i = 1;
            }
            else
            {
                _subscriberList.Add(this.EmailAddress);
            }

            return i;            
        }

        public int Unsubscribe(List<string> _subscriberList)
        {
            int i = _subscriberList.IndexOf(this.EmailAddress);

            if (i > 0 || i == 0)
            {
                _subscriberList.RemoveAt(i);
            }

            return i;
        }
    }
}
