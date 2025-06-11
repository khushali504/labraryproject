using LibraryProject.Models;
using LibraryProject.Services;
using System;

namespace LibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookService = new BookService();
            var books = bookService.GetBooks();

            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }
    }
}
