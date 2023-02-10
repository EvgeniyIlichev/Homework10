using Homework10Console.Clients;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10Console.Infrasructure
{
    class LoadOrSaveFile : BaseClients
    {
        
        public static List<Client> FileExistenceCheck()
        {
            string adressBase = @"..\Debug\base.json";
            if (!File.Exists(adressBase)) 
            {
                List<Client> baseClient;
                BaseClients baseClients = new BaseClients();
                baseClient = DataSaveJson.SerializeBaseJson();
                return baseClient;
            }
            else
            {
                _base = DataLoadJson.DeserializeBaseJson();
                return _base;
            }
        }
    }
}
