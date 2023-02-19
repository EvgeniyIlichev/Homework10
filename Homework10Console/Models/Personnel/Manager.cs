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
        private static string viewBaseData = ViewBaseData().ToString();
        /// <summary>
        /// Скрытие паспортных данных
        /// </summary>
        /// <returns></returns>
        public static BaseClients ViewBaseData()
        {
            List<Client> baseCompared = LoadOrSaveFile.FileExistenceCheck();
            BaseClients baseClients = new BaseClients(baseCompared);
            return baseClients;
        }

        public static void Menu()
        {
            bool exit = true;
            while (exit)
            {
                Console.Write(@"Что делать ? 
0 - Показать
1 - Cохранить 
2 - Загрузить 
3 - Изменить номер телефона  
4 - Выход 
");
                switch (Console.ReadLine())
                {
                    case "0": Console.WriteLine(viewBaseData); break;
                    case "1":
                        {
                            DataSaveJson.SerializeBaseJson();
                            Console.WriteLine("Base saved");
                            break; 
                        }
                    case "2": break;
                    case "3": break;
                    case "4": exit = false; break;
                    default:
                        Console.WriteLine("Угу, так и сделаем");
                        break;
                }
            }
        }
    }
}
