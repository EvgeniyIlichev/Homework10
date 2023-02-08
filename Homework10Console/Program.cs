using Homework10Console.Clients;
using Homework10Console.Infrasructure;
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

            DataSaveJson.SerializeBaseJson();
            DataLoadJson.DeserializeBaseJson();

            Console.WriteLine(baseClients.ToString());

            Console.ReadLine();

        }

        



    }


}
