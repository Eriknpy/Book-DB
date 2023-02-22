using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_DB.Model
{
    internal class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }

        public Author(string firstName, string lastName, DateOnly birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return new string($"{Id}, {FirstName}, {LastName}, {BirthDate: MM/dd/yyyy}");
        }
    }
}
