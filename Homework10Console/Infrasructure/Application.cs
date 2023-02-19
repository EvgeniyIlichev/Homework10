using Homework10Console.Models.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10Console.Infrasructure
{
    internal class Application
    {
                /// <summary>
                /// Метод вывода меню
                /// </summary>
                public static void Start()
                {
                    Menu();
                }
                static void Menu()
                {
                    bool exit = true;
                    while (exit)
                    {
                        Console.Write(@"Добро пожаловать, укажите уровень доступа: 
0 - Менеджер 
1 - Консультант   
2 - Выход 
");
                        switch (Console.ReadLine())
                        {
                            case "0": Manager.Menu(); break;
                            case "1": Consultant.Menu(); break;
                            case "2": exit = false; break;
                            default:
                                Console.WriteLine("Угу, так и сделаем");
                                break;
                        }
                    }
                }


            
     }
}

