using Homework10Console.Clients;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10Console.Infrasructure
{
    class Application
    {
        public static List<Client> Compare()
        {
            List<Client> baseClient;
            string adressBase = @"..\Debug\base.json";
            if (!File.Exists(adressBase)) 
            {
                BaseClients baseClients = new BaseClients();
                baseClient = DataSaveJson.SerializeBaseJson();
            }
            else
            {
                baseClient = DataLoadJson.DeserializeBaseJson();
            }
            return baseClient;
        }
    }
}
