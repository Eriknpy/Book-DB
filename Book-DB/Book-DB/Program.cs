using Book_DB.Manager;
using Book_DB.View;

namespace Book_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ui = new UserInterface();
            var bookDbManager = new BookDbManager(ui);
            bookDbManager.Run();
        }
    }
}