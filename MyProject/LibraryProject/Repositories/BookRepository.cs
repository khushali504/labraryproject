using LibraryProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryProject.Repositories
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Id = 2, Title = "Brave New World", Author = "Aldous Huxley", Year = 1932 }
        };

        public List<Book> GetAllBooks() => books;

        public Book GetBookById(int id) => books.FirstOrDefault(b => b.Id == id);

        public void AddBook(Book book) => books.Add(book);
    }
}
