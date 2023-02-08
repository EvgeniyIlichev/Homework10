using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework10Console
{
    internal class DataPassportClass
    {
        public string DataPassport { get; set; }
        public DataPassportClass()
        {
            this.DataPassport = RandomDataPassport();
        }

        public override string ToString()
        {
            return String.Format("{0,12}",
                this.DataPassport);
        }

        public static string RandomDataPassport()
        {
            string dataPassport = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                if (i == 2 || i == 5)
                {
                    dataPassport += " ";
                }
                else
                {
                    dataPassport += random.Next(0, 9).ToString();
                }
                Thread.Sleep(10);
            }
            return dataPassport;
        }
    }
}
