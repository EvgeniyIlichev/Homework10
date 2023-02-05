using Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public class DataSaver
    {
        private Note[] notes;
        public DataSaver(params Note[] notes)
        {
            this.notes = notes;
        }
        public void Save(string path)
        {
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            foreach (var item in notes)
            {
                sw.WriteLine($"{item.Id}, {item.FullName},{item.Title} ,{item.Date} ,{item.Text} ");
            }
            sw.Close();
        }


    }
}
