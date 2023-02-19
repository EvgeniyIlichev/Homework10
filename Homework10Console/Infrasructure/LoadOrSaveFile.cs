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
                BaseClients baseClients = new BaseClients();
                DataSaveJson.SerializeBaseJson();
                return _base;
            }
                _base = DataLoadJson.DeserializeBaseJson();
                return _base;
            
        }
    }
}
