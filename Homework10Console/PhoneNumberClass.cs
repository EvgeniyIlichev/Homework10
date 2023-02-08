using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10Console
{
    internal class PhoneNumberClass
    {
        public string PhoneNumber { get; set; }
        public PhoneNumberClass() 
        {
           this.PhoneNumber = RandomPnoneNumber();
        }

        public override string ToString()
        {
            return String.Format("{0,15}",
                this.PhoneNumber);
        }

        public static string RandomPnoneNumber()
        {
            string phoneNumber = "8-9";
            Random random = new Random();
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
            }
            return phoneNumber;
        }
    }
}
