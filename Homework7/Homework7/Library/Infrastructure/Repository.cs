using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public class Repository
    {

        static Random rand = new Random();
        static public Note[] GetRepository()
        {
            int count = rand.Next(10, 15);
            Note[] t = new Note[count];
            for(int i = 0;i < count; i++)
            {
                t[i] = new Note
                {
                    Id = i + 1,
                    Date = DateTime.Now + new TimeSpan(days: rand.Next(28), hours:0, minutes:0, seconds:0),
                    Title = $"Заголовок_{i + 1}",
                    Text = Guid.NewGuid().ToString(),
                    FullName = $"Имя_{i + 1}",
                };
            }

            return t;
        }
    }
}
