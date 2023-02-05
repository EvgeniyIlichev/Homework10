using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public struct Col
    {

        public Note this[int index]
        {
            get { return db[index]; }
        }
        public int Count { get { return db.Length; } }
        public Note[] db;

        public Col(string name)
        {
            db = new Note[0];
        }

        public Col(Note[] arg)
        {
            db = arg;
        }
        /// <summary>
        /// Метод добавления заметки
        /// </summary>
        /// <param name="arg"></param>
        public void Add(Note arg)
        {
            Array.Resize(ref db, db.Length + 1);
            db[db.Length - 1] = arg;  
        }

        /// <summary>
        /// Метод удаления строки
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            int count = db.Length; //Длина массива
            int findIndex = -1;    

            //Поиск строки для удаления
            for (int i = 0; i < count; i++)
            {
                if (db[i].Id == index)
                {
                    findIndex = i;
                    break;
                } 
            }
            if (findIndex == -1)
                return;
                
            for (int i = findIndex; i < count - 1; i++)
            {
                 db[i] = db[i + 1];
                 db[i].Id -= 1;
            }
            Array.Resize(ref db, db.Length - 1);
        }

        public void Edit(int index, Note note)
        {
            if(index != 0)
            {
                for (int i = 0; i < db.Length; i++)
                {
                    if (db[i].Id == index)
                    {
                        db[i] = note;
                        break;
                    }

                }
            }
            if(index == 0)
            {
                for (int i = 0; i < db.Length; i++)
                {
                    if (db[i].Id == 0)
                    {
                        db[i] = note;
                        db[i].Id = SourceLargIndex() + 1;
                        break;
                    }
                }
            }

        }
        public int SourceLargIndex()
        {
            int countId = 0;
            for (int i = 1; i < db.Length; i++)
            {
                if (db[i].Id > db[i - 1].Id)
                {
                    countId = db[i].Id;
                }
            }
            return countId;
        }
    }
}
