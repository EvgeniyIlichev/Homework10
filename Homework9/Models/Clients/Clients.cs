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
        public PhoneNumberClass PhoneNumber { get; set; }
        public string DataPassport { get; set; }

        public Clients(
            string Surname,
            string Name,
            string Patronymic,
            PhoneNumberClass PhoneNumber,
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
            PhoneNumber = new PhoneNumberClass();
        }

        

    }
}
