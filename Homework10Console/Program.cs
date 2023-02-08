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
            PhoneNumberClass phoneNumber = new PhoneNumberClass();
            Clients client = new Clients();
            Clients client2 = new Clients("Petrov", "Ivan", "Ivanovich", "8-911-333-33-33", "2211");
            DataPassportClass dataPassport = new DataPassportClass();
            Console.WriteLine(client.ToString());
            Console.WriteLine(client2.ToString());
            Console.ReadLine();

        }

        



    }


}
