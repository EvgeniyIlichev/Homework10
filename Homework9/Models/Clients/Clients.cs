﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10.Models.Clients
{
    internal class Clients
    {
        private int id = 0;

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string DataPassport { get; set; }

        public Clients(
            string Surname,
            string Name,
            string Patronymic,
            string PhoneNumber,
            string DataPassport)
        {
            Id = id++;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.PhoneNumber = PhoneNumber;
            this.DataPassport = DataPassport;
        }
        public Clients()
        {
            Id = id++;
            Surname = $"Фамилия {id}";
            Name = $"Имя {id}";
            Patronymic = $"Отчество {id}";

        }

        public string RandomPnoneNumber()
        {
            string[] phoneNumber = new string[15];
            int randonInt;
            Random random = new Random();
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (i == 1 || i == 5 || i == 9 || i == 12)
                {
                    phoneNumber[i] = "-";
                }
                else
                {
                    randonInt = random.Next(0, 9);
                    phoneNumber[i] = randonInt.ToString();
                }
            }
            PhoneNumber = phoneNumber.ToString();
            return PhoneNumber;
        }

    }
}