using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Homework10.Models.Clients
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
    }
}
