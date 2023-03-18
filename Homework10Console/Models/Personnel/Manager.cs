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
        // <summary>
        /// Просмотр данных
        /// </summary>
        /// <returns></returns>
        public static BaseClients ViewBaseData()
        {
            List<Client> baseCompared = LoadOrSaveFile.FileExistenceCheck();
            BaseClients baseClients = new BaseClients(baseCompared);
            return baseClients;
        }

        static void EditDataClient()
        {
            string id;
            bool idBool = false;
            string phoneNumber;
            List<Client> baseCompared = LoadOrSaveFile.FileExistenceCheck();
            //Выполняется пока не совпадет айди
            while (!idBool)
            {
                Console.WriteLine(@"Введите ID клиента, данные 
которого хотите изменить?
Для выхода в прошлое меню нажмите Enter");
                id = Console.ReadLine();
                if (id == "")
                {
                    break;
                }
                Int32.TryParse(id, out int idInt);
                foreach (var client in baseCompared)
                {
                    if (client.Id == idInt)
                    {
                        bool lengthNumber = false;
                        //Выполняется пока длина вводимого номера не будет соотвествовать неободимому формату
                        while (!lengthNumber)
                        {
                            Console.WriteLine(@"Введите номер телефона(11 цифр в формате 89181234567)
Для выхода в прошлое меню нажмите Enter");
                            phoneNumber = Console.ReadLine();
                            if (phoneNumber == "")
                            {
                                break;
                            }
                            char[] phoneNumberChar = phoneNumber.ToArray();
                            if (phoneNumberChar.Length == 11)
                            {
                                client.PhoneNumber = PhoneNumberClass.InputPhoneNumber(phoneNumberChar);
                                Console.WriteLine("Номер изменен");
                                BaseClients baseClients = new BaseClients(baseCompared);
                                DataSaveJson.SerializeBaseJson();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Не верное количество цифр в номере, введите заново");
                            }
                        }
                        idBool = true;
                        break;
                    }
                }
                if (!idBool)
                {
                    Console.WriteLine("Клиент не найден");
                }
            }
        }

        public static void Menu()
        {
            bool exit = true;
            while (exit)
            {
                Console.Write(@"Что делать ? 
0 - Показать
1 - Изменить данные  
2 - Выход 
");
                switch (Console.ReadLine())
                {
                    case "0": Console.WriteLine(ViewBaseData().ToString()); break;
                    case "1": EditDataClient(); break;
                    case "2": exit = false; break;
                    default:
                        Console.WriteLine("Угу, так и сделаем");
                        break;
                }
            }
        }
    }
}
