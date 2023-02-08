using Homework10Console.Clients;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10Console.Infrasructure
{
    internal class DataSaveJson : BaseClients 
    {
        public static void SerializeOrganizationJson()
        {
            string baseJson = JsonConvert.SerializeObject(_base);
            string json = baseJson;
            File.WriteAllText("base.json", json);
        }
    }
}
