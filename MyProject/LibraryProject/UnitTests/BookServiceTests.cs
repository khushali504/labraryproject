using LibraryProject.Models;
using LibraryProject.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace LibraryProject.UnitTests
{
    public class BookServiceTests
    {
        private BookService _bookService;

        [SetUp]
        public void Setup()
        {
            _bookService = new BookService();
        }

        [Test]
        public void GetBooks_ReturnsAllBooks()
        {
            var result = _bookService.GetBooks();
            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public void GetBook_ReturnsCorrectBook()
        {
            var result = _bookService.GetBook(1);
            Assert.AreEqual("1984", result.Title);
        }

        [Test]
        public void CreateBook_AddsNewBook()
        {
            var newBook = new Book { Id = 3, Title = "Fahrenheit 451", Author = "Ray Bradbury", Year = 1953 };
            _bookService.CreateBook(newBook);

            var result = _bookService.GetBooks();
            Assert.AreEqual(3, result.Count);
        }
    }
}
