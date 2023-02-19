using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework10Console
{
    internal class PhoneNumberClass
    {
        Random random;
        private string PhoneNumber { get; set; }
        public PhoneNumberClass() 
        {
           PhoneNumber = RandomPnoneNumber();
        }

        public override string ToString()
        {
            return String.Format("{0,15}",
                PhoneNumber);
        }

        private string RandomPnoneNumber()
        {
            string phoneNumber = "8-9";
            random = new Random();
            for (int i = 0; i < 12; i++)
            {
                if (i == 2 || i == 6 || i == 9)
                {
                    phoneNumber += "-";
                }
                else
                {
                    phoneNumber += random.Next(0, 9).ToString();
                }
                Thread.Sleep(10);
            }
            return phoneNumber;
        }

        public static string InputPhoneNumber(char[] phoneNumberChar)
        {
            string newPhoneNumber = string.Empty;
            for (int i = 0; i < phoneNumberChar.Length; i++)
            {
                if (i == 0 || i == 3 || i == 6 || i == 8)
                {
                    newPhoneNumber += phoneNumberChar[i];
                    newPhoneNumber += "-";
                }
                else
                {
                    newPhoneNumber += phoneNumberChar[i];
                }
                Thread.Sleep(10);
            }
            return newPhoneNumber;
        }
    }
}
