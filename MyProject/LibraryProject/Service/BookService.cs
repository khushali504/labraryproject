using LibraryProject.Models;
using LibraryProject.Repositories;
using System.Collections.Generic;

namespace LibraryProject.Services
{
    public class BookService
    {
        private readonly BookRepository _bookRepository;

        public BookService()
        {
            _bookRepository = new BookRepository();
        }

        public List<Book> GetBooks() => _bookRepository.GetAllBooks();

        public Book GetBook(int id) => _bookRepository.GetBookById(id);

        public void CreateBook(Book book) => _bookRepository.AddBook(book);
    }
}
