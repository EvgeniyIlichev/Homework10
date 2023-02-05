using Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public class DataLoad
    {
        private Note[] notes;
        string path;
        int index;
        public DataLoad(string path)
        {
            this.path = path;
            this.index = 0;
            this.notes = new Note[2];
        }
        /// <summary>
        /// Если размера массива недостаточно, то данный метод увеличивает его размер
        /// </summary>
        /// <param name="Flag"></param>
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.notes, this.notes.Length + 1);
            }
        }
        /// <summary>
        /// Добавление строки в массив
        /// </summary>
        /// <param name="ConcreteNote"></param>
        public void Add(Note ConcreteNote)
        {
            this.Resize(index >= this.notes.Length);
            this.notes[index] = ConcreteNote;
            this.index++;
        }
        /// <summary>
        /// Загрузка из файла
        /// </summary>
        public Note[] Load()
        {
            using (StreamReader sr = new StreamReader(this.path, Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split(',');

                    Add(new Note(Convert.ToInt32(args[0]), args[1], args[2], Convert.ToDateTime(args[3]),args[4]));
                }
            }
            return notes;
        }
        
    }
}
