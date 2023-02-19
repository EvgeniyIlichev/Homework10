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
        private static string baseWithHiddenPassportData = HidingPassportData().ToString();
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

        static void EditPhoneNumber()
        {
            string id;
            bool idBool = false;
            string phoneNumber;
            
            while(!idBool)
            {
                Console.WriteLine(@"Введите ID клиента, номер телефона которого хотите изменить?
Для выхода в прошлое меню нажмите Enter");
                id = Console.ReadLine();
                if(id == "")
                {
                    break;
                }
                Int32.TryParse(id, out int idInt);
                foreach(var client in _base)
                {
                    if(client.Id == idInt)
                    {
                        bool lengthNumber = false;
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
                            if(phoneNumberChar.Length == 11)
                            {
                                client.PhoneNumber = PhoneNumberClass.InputPhoneNumber(phoneNumberChar);
                                Console.WriteLine("Номер изменен");
                                DataSaveJson.SerializeBaseJson();
                                LoadOrSaveFile.FileExistenceCheck();
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
                if(!idBool)
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
1 - Изменить номер телефона  
2 - Выход 
");
                switch (Console.ReadLine())
                {
                    case "0": Console.WriteLine(baseWithHiddenPassportData); break;
                    case "1": EditPhoneNumber(); break;
                    case "2": exit = false; break;
                    default:
                        Console.WriteLine("Угу, так и сделаем");
                        break;
                }
            }
        }
    }
}
