using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_DB.Model.Interfaces
{
    internal interface IBookDao
    {
        /// <summary>
        /// Adds a new object to the database and sets the new ID.
        /// </summary>
        /// <param name="book">A new object, with ID not yet set (null).</param>
        public void Add(Book book);

        /// <summary>
        /// Updates existing object's data in the database.
        /// </summary>
        /// <param name="book">An object from the database, with ID already set.</param>
        public void Update(Book book);

        /// <summary>
        /// Get object by ID.
        /// </summary>
        /// <param name="id">ID to search by</param>
        /// <returns>An object with a given ID, or null if not found.</returns>
        public Book Get(int id);

        /// <summary>
        /// Get all objects.
        /// </summary>
        /// <returns>List of all objects of this type in the database.</returns>
        List<Book> GetAll();
    }
}
