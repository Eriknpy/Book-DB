using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_DB.Model
{
    internal class Book
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public string Title { get; set; }

        public Book(Author author, string title)
        {
            Author = author;
            Title = title;
        }

        public override string ToString()
        {
            return new string($"{Id}, {Title}, {Author.FirstName}, {Author.LastName}");
        }
    }
}
