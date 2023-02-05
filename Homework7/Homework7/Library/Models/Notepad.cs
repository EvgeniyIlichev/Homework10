using Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Notepad
    {
        Col cols;
        bool compare;

        public Note[] Notes { get { return cols.db; } }

        public Notepad(params Note[] args)
        {
            cols = new Col(args);
        }
        public void Add(Note note)
        {
            cols.Add(note);
        }
        public void ImportMassive(DataLoad dataLoad)
        {
            foreach (var item in dataLoad.Load())
            {
                for (int i = 0; i < cols.db.Length; i++)
                {
                    if (cols.db[i].Text == item.Text)
                    {
                        compare = true;
                        break;
                    }
                }
                if (compare == false)
                {
                    Array.Resize(ref cols.db, cols.db.Length + 1);
                    cols.db[cols.db.Length - 1] = item;
                    cols.db[cols.db.Length - 1].Id = cols.SourceLargIndex() + 1;
                }
                compare = false;
            }
        }
        public void Remove(int index)
        {
            cols.Remove(index);
        }
        /// <summary>
        /// Метод редактирования
        /// </summary>
        /// <param name="index"></param>
        /// <param name="note"></param>
        public void Edit(int index, Note note)
        {
            cols.Edit(index, note);
        }

        /// <summary>
        /// Метод вывода строк
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            StringBuilder t = new StringBuilder();
            int count = cols.Count;
            for (int i = 0; i < count; i++)
            {
                t.Append($"{cols[i]} \n");
            }

            return t.ToString();
        }

        public void Sort()
        {
            Console.Write(@"По какому полю сортировать?
0 - По дате
1 - По индексу
       ");
            switch (Console.ReadLine())
            {
                case "0": SortToDate(); break;
                case "1": SortToIndex(); break;
                default: Console.WriteLine("Угу, так и сделаем"); break;
            }
        }
        /// <summary>
        /// Метод сортировки по дате
        /// </summary>
        public void SortToDate()
        {
            Array.Sort(cols.db, sortByDate);
        }
        /// <summary>
        /// Метод с механикой сортировки по дате
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private int sortByDate(Note x, Note y)
        {
            return x.Date < y.Date ? -1 : x.Date == y.Date ? 0 : 1;
        }
        /// <summary>
        /// Метод сортировки по индексу
        /// </summary>
        public void SortToIndex()
        {
            Array.Sort(cols.db, sortByIndex);
        }
        /// <summary>
        /// Метод с механикой сортировки по индексу
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private int sortByIndex(Note x, Note y)
        {
            return x.Id < y.Id ? -1 : x.Id == y.Id ? 0 : 1;
        }
        
    }
 
}
