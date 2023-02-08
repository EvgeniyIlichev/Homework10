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
    internal class DataLoadJson : BaseClients 
    {
        public static void DeserializeBaseJson()
        {
            string json = File.ReadAllText("base.json");
            List<Client> _base = new List<Client>();
            _base = JsonConvert.DeserializeObject<List<Client>>(json);
            foreach (var item in _base)
            {
                BaseClients._base.Add(item);
            }
        }
    }
}
