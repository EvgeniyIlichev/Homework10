using System;
using Homework10Console.Clients;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10.Models.Clients
{
    class BaseClients
    {
        protected List<Client> _base = new List<Client>(); 

        public BaseClients()
        {
            for (int i = 0; i < 10; i++)
            {
                Client client = new Client();
                _base.Add(client);
            }
        }

        public override string ToString()
        {
            string outputBase = string.Empty;
            foreach (var client in _base)
            {
                outputBase += String.Format("Id:{0,3} | Surname:{1,10} | Name:{2,6} | Patronymic:{3,14} \n PhoneNumber:{4,15} | DataPassport:{5,12} \n\n",
                client.Id,
                client.Surname,
                client.Name,
                client.Patronymic,
                client.PhoneNumber,
                client.DataPassport);
            }
            return outputBase;
        }
    }
}
