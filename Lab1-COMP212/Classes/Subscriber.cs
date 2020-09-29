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


        public delegate string SubscribeDel(string _value, string _value2);

        public SubscribeDel GetSubscribeTypeDel(string subscribeType)
        {
            SubscribeDel subscribeDel = null;
            switch (subscribeType.ToLower())
            {
                case "email":

                    break;
                case "phone":
                    subscribeDel = SubscribeMobile;
                    break;
                default: break;
            }
            return subscribeDel;
        }

        //Subscribe mobile
        private string SubscribeMobile(string value, string value2)
        {
            // ** Call mobile class
            Classes.SendViaMobile sendViaMobile = new Classes.SendViaMobile(value);

            switch (value2.ToLower())
            {
                case "subscribe":
                    this.returnValue = sendViaMobile.Subscribe(SubscriberList);
                    if (this.returnValue == 1)
                    {
                        this.returnMessage = $"ERROR: {value} has already been created.";
                    }
                    else
                    {
                        this.returnMessage = $"Successfully {value2} {value}.";
                    }
                    break;
                case "unsubscribe":
                    this.returnValue = sendViaMobile.Unsubscribe(SubscriberList);
                    if (this.returnValue < 0)
                    {
                        this.returnMessage = $"ERROR: {value} does not exist.";
                    }
                    else
                    {
                        this.returnMessage = $"Successfully {value2} {value}.";
                    }
                    break;
                default: break;
            }

            return this.returnMessage;
        }

        private string SubscribeEmail(string _value, string _value2)
        {
            // ** Call SendViaEmail class
            SendViaEmail _sendViaEmail = new SendViaEmail(_value);
           
            switch (_value2.ToLower())
            {
                case "subscribe":
                    this._returnValue = _sendViaEmail.Subscribe(SubscribersList);
                    if (this._returnValue == 1)
                    {
                        this._returnMessage = $"{_value} already exist!";
                    }
                    else
                    {
                        this._returnMessage = $"Successfully {_value2} {_value}.";
                    }
                    break;
                case "unsubscribe":
                    this._returnValue = _sendViaEmail.Unsubscribe(SubscribersList);
                    if (this._returnValue < 0)
                    {
                        this._returnMessage = $"{_value} does not exist!";
                    }
                    else
                    {
                        this._returnMessage = $"Successfully {_value2} {_value}.";
                    }
                    break;
                default:
                    this._returnMessage = "Unable to process request.";
                    break;
            }

            return this._returnMessage;
        }
    }
}
