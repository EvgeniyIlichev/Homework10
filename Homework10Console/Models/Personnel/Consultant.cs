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
        public readonly static string baseWithHiddenPassportData = HidingPassportData().ToString();
        /// <summary>
        /// Скрытие паспортных данных
        /// </summary>
        /// <returns></returns>
        public static BaseClients HidingPassportData()
        {
            List<Client> listClients = LoadOrSaveFile.FileExistenceCheck();
            foreach (var client in listClients)
            {
                client.DataPassport = "** ** ******";
            }
            BaseClients baseClientsWithHiddenPassportData = new BaseClients(listClients);
            return baseClientsWithHiddenPassportData;
            
        }
        
    }
}
