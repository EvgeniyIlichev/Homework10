using Library;
using Library.Models;
using Library.Infrastructure;
using System;

namespace Homework7
{
    partial class Program
    {
        class Application
        {

            static int id = 1000;
            static Notepad notepad = new Notepad(Repository.GetRepository());


            /// <summary>
            /// Метод вывода меню
            /// </summary>
            public static void Start()
            {
                Menu();
            }
            /// <summary>
            /// Метод ввода заметки при добавление заметки в блокнот
            /// </summary>
            /// <returns></returns>
            static Note GetAddNote()
            {
                Note note = new Note();
                note.Id = id++;
                Console.Write("Текст: ");
                note.Text = Console.ReadLine();

                Console.Write("Имя: ");
                note.FullName = Console.ReadLine();

                Console.Write("Заголовок: ");
                note.Title = Console.ReadLine();

                DateTime dt = new DateTime();
                bool r = false;
                do
                {
                    Console.Write("Дата: ");
                    r = DateTime.TryParse(Console.ReadLine(), out dt);
                } while (!r);

                note.Date = dt;

                return note;
            }
            public static int GetIndex()
            {
                int index;
                bool r = false;
                do
                {
                    Console.Write("Индекс: ");
                    r = int.TryParse(Console.ReadLine(), out index);
                } while (!r);

                return index;
            }
            /// <summary>
            /// Метод замены заметки
            /// </summary>
            /// <param name="newIndex"></param>
            /// <returns></returns>
            static Note GetEditNote(int newIndex)
            {
                Note note = new Note();
                note.Id = newIndex;
                Console.Write("Имя: ");
                note.FullName = Console.ReadLine();

                Console.Write("Заголовок: ");
                note.Title = Console.ReadLine();

                Console.Write("Текст: ");
                note.Text = Console.ReadLine();

                DateTime dt = new DateTime();
                bool r = false;
                do
                {
                    Console.Write("Дата: ");
                    r = DateTime.TryParse(Console.ReadLine(), out dt);
                } while (!r);

                note.Date = dt;

                return note;
            }
            static void Menu()
            {
                bool exit = true;
                while (exit)
                {
                    Console.Write(@"Что делать ? 
0 - Cохранить 
1 - Добавить 
2 - Удалить 
3 - Показать 
4 - Импорт 
5 - Выход 
6 - Сортировка 
7 - Редактировать 
");
                    switch (Console.ReadLine())
                    {
                        case "0": new DataSaver(notepad.Notes).Save(GetPath()); break;
                        case "1": notepad.Add(GetAddNote()); break;
                        case "2": notepad.Remove(GetIndex()); break;
                        case "3": Console.WriteLine(notepad.Print()); break;
                        case "4": notepad.ImportMassive(new DataLoad(GetPath())); break;
                        case "5": exit = false; break;
                        case "6": notepad.Sort(); break;    
                        case "7": 
                            {
                                int index = GetIndex();
                                notepad.Edit(index, GetEditNote(index)); break; 
                            }
                        default: Console.WriteLine("Угу, так и сделаем");
                            break;
                    }
                }
            }

            static string GetPath()
            {
                string path = String.Empty;
                do
                {
                    Console.Write("Имя файла:  ");
                    path = Console.ReadLine();
                    bool f = true;
                    for (int i = 0; i < path.Length; i++)
                    {
                        if(!Char.IsLetterOrDigit(path[i]))
                        {
                            f = false;
                            break;
                        }
                    }
                    if (f) break;
                } while (true);
                return $"{path}.csv";
            }

        }
    }
}
