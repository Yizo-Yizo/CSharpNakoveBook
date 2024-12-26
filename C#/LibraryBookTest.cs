using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class LibraryBookTest
    {
        public void Test()
        {
            Library library = new Library();

            // Correctly initializing DateTime objects
            Book book1 = new Book("The Shining", "Stephen King", "NWA", new DateTime(1977, 1, 28), "9780385121675");
            Book book2 = new Book("Misery", "Stephen King", "Viking", new DateTime(1987, 6, 8), "9780450417399");
            Book book3 = new Book("The Catcher in the Rye", "J.D. Salinger", "Little, Brown and Company", new DateTime(1951, 7, 16), "9780316769488");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.WriteLine("Books in the Library:");
            foreach (var book in library.GetBooks()) // Use GetBooks() method to access the list
            {
                Console.WriteLine(book.DisplayBookInfo());
                Console.WriteLine();
            }

            // Removing all books by Stephen King
            List<Book> booksToRemove = new List<Book>();

            foreach (var book in library.GetBooks())
            {
                if (book.Author == "Stephen King")
                {
                    booksToRemove.Add(book);
                }
            }

            foreach (var book in booksToRemove)
            {
                library.RemoveBook(book);
            }

            Console.WriteLine("Remaining Books in the Library:");
            foreach (var book in library.GetBooks())
            {
                Console.WriteLine(book.DisplayBookInfo());
                Console.WriteLine();
            }
        }
    }
}
