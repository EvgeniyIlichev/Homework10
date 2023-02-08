using Homework10Console.Clients;
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
            BaseClients baseClients = new BaseClients();

            Console.WriteLine(baseClients.ToString());

            Console.ReadLine();

        }

        



    }


}
