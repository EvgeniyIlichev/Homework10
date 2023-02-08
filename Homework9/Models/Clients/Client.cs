using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10.Models.Clients
{
    internal class Client
    {
        private static int id;

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string DataPassport { get; set; }

        public Client(
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
        public Client()
        {
            Id = id++;
            Surname = $"Фамилия {id}";
            Name = $"Имя {id}";
            Patronymic = $"Отчество {id}";
            PhoneNumber = new PhoneNumberClass().ToString();
            DataPassport = new DataPassportClass().ToString();
        }

        public override string ToString()
        {
            return String.Format("Id:{0,3} | Surname:{1,10} | Name:{2,6} | Patronymic:{3,14} \n PhoneNumber:{4,15} | DataPassport:{5,12}",
                this.Id,
                this.Surname,
                this.Name,
                this.Patronymic,
                this.PhoneNumber,
                this.DataPassport);
        }



    }
}
