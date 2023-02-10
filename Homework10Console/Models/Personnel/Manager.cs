using Homework10Console.Clients;
using Homework10Console.Infrasructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10Console.Models.Personnel
{
    internal class Manager : Personnel
    {
        public readonly static string baseWithHiddenPassportData = HidingPassportData().ToString();
        /// <summary>
        /// Скрытие паспортных данных
        /// </summary>
        /// <returns></returns>
        public static BaseClients HidingPassportData()
        {
            List<Client> baseCompared = LoadOrSaveFile.FileExistenceCheck();
            BaseClients baseClients = new BaseClients(baseCompared);
            return baseClients;
        }
    }
}
