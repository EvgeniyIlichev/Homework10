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
        public readonly static string viewBaseData = ViewBaseData().ToString();
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
0 - Cохранить 
1 - Добавить 
2 - Удалить 
3 - Показать 
4 - Импорт 
5 - Выход 
6 - Сортировка 
7 - Редактировать 
");
                switch (Console.ReadLine())
                {
                    case "0": break;
                    case "1": break;
                    case "2": break;
                    case "3": Console.WriteLine(Manager.viewBaseData); break;
                    case "4": break;
                    case "5": exit = false; break;
                    case "6": break;
                    case "7":
                        {
                            break;
                        }
                    default:
                        Console.WriteLine("Угу, так и сделаем");
                        break;
                }
            }
        }
    }
}
