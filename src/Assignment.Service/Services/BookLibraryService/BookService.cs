using Assignment.Api;
using Assignment.Api.Interfaces.BookLibraryInterfaces;
using Assignment.Service.Model.BookLibrary;
using Assignment.Service.Model.ResponseHandler;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.BookLibraryService
{
    public class BookService
    {
        private readonly IDBBookRepository _bookRepository;
        private readonly ILogger<BookService> _logger;

        public BookService(IDBBookRepository bookRepository, ILogger<BookService> logger)
        {
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            try
            {
                return await _bookRepository.GetAllBooksAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Book> GetBookByIdAsync(int bookId)
        {
            try
            {
                return await _bookRepository.GetBookByIdAsync(bookId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Book> AddBookAsync(BookRQ book)
        {
            try
            {

                if (await _bookRepository.CheckBookTitle(book.Title))
                {
                    throw new ArgumentException("Book with the same title already exists");
                }

                if (await _bookRepository.CheckISBN(book.Isbn))
                {
                    throw new ArgumentException("ISBN already exists");
                }

                var bookEntity = new Book()
                {
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    Genre = book.Genre,
                    Isbn = book.Isbn,
                    Availability = book.Availability
                };

                var addedBook = await _bookRepository.AddBookAsync(bookEntity);
                return addedBook;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<bool> DeleteBookAsync(int bookId)
        {
            try
            {
                var existingBook = await _bookRepository.GetBookByIdAsync(bookId);

                if (existingBook == null)
                {
                    return false;
                }

                await _bookRepository.DeleteBookAsync(existingBook.BookId);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateBookAsync(int bookId, BookUpdateRQ book)
        {
            try
            {
                var existingBook = new Book();
                existingBook.Title = book.Title;
                existingBook.Genre = book.Genre;
                existingBook.Availability = book.Availability;

                var isUpdated = await _bookRepository.UpdateBookAsync(bookId, existingBook);
                return isUpdated;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
