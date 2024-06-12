using Assignment.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.BookLibraryInterfaces
{
    public interface IDBBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();

        Task<Book> GetBookByIdAsync(int bookId);

        Task<Book> AddBookAsync(Book book);

        Task<bool> IsISBNUniqueAsync(string isbn);

        Task<Book> GetBookByISBNAsync(string isbn);

        Task<bool> CheckBookTitle(string title);

        Task<bool> CheckISBN(string isbn);

        Task<bool> DeleteBookAsync(int bookId);

        Task<bool> UpdateBookAsync(int bookId, Book book);
    }
}