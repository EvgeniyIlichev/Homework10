using Homework10Console.Clients;
using Homework10Console.Infrasructure;
using System;
using System.Collections.Generic;
using System.IO;
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
            List<Client> baseCompared = Application.Compare();

            BaseClients baseClients = new BaseClients(baseCompared);
            Console.WriteLine(baseClients.ToString());
            

            Console.ReadLine();

        }

        



    }


}
