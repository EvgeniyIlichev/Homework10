using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public struct Note
    {
        private int id;
        private string title;
        private string fullName;
        private DateTime date;
        private string text;

        public Note(int Id, string Fullname, string Title, DateTime Date, string Text)
        {
            id = Id;
            fullName = Fullname;
            title = Title;
            date = Date;
            text = Text;
        }

        public int Id { get { return id; } set { id = value; } }
        public string FullName { get {return fullName; } set {fullName = value; } }
        public string Title { get { return title; } set { title = value; } }
        public DateTime Date { get {return date; } set {date = value; } }
        public string Text { get { return text; } set { text = value; } }

        public override string ToString()
        {
            return $"{Id,4} {FullName,15} {Title,15} {Date,20} {Text}";
        }
    }
}
