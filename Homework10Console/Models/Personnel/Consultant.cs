using Homework10Console.Clients;
using Homework10Console.Infrasructure;
using Homework10Console.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10Console.Models.Personnel
{
    internal class Consultant : Personnel
    {
        public readonly static string viewdata = HidePassportData().ToString();

        public static BaseClients HidePassportData()
        {
            List<Client> baseCompared = Application.Compare();

            foreach (var client in baseCompared)
            {
                client.DataPassport = "** ** ******";
            }

            BaseClients baseClients = new BaseClients(baseCompared);
            return baseClients;
        }
        
    }
}
