using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Homework10Console
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string phoneNumber = RandomPnoneNumber();
            Console.WriteLine(phoneNumber);
            Console.ReadLine();

        }

        public static string RandomPnoneNumber()
        {
            string phoneNumber = string.Empty;
            int randonInt;
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                if (i == 1 || i == 5 || i == 9 || i == 12)
                {
                    phoneNumber += "-";
                }
                else
                {
                    randonInt = random.Next(0, 9);
                    phoneNumber += randonInt.ToString();
                }
            }
            return phoneNumber;
        }



    }


}
