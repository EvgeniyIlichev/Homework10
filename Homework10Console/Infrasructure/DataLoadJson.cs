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
        public static List<Client> DeserializeBaseJson()
        {
            string json = File.ReadAllText("base.json");
            List<Client> _baseLoad;
            _baseLoad = JsonConvert.DeserializeObject<List<Client>>(json);
            _base.Clear();
            foreach (var client in _baseLoad)
            {
                 _base.Add(client);
            }
            return _base;
        }
        
    }
}
