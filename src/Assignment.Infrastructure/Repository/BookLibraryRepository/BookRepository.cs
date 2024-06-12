using Assignment.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment.Api.Interfaces.BookLibraryInterfaces;

namespace Assignment.Infrastructure.Repository.BookLibrary
{
    public class BookRepository : GenericRepository<Book>, IDBBookRepository
    {
        private readonly RaidenDBContext _context;

        public BookRepository(RaidenDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int bookId)
        {
            return await _context.Books.FirstOrDefaultAsync(x => x.BookId == bookId);
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<bool> IsISBNUniqueAsync(string isbn)
        {
            var existingBook = await GetBookByISBNAsync(isbn);
            return existingBook == null;
        }

        public async Task<Book> GetBookByISBNAsync(string isbn)
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.Isbn == isbn);
        }

        public async Task<bool> CheckBookTitle(string title)
        {
            return await _context.Books.AnyAsync(b => b.Title == title);
        }

        public async Task<bool> CheckISBN(string isbn)
        {
            var check = await _context.Books.FirstOrDefaultAsync(b => b.Isbn.Equals(isbn));
            if (check != null)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteBookAsync(int bookId)
        {
            var existingBook = await GetBookByIdAsync(bookId);

            if (existingBook == null)
            {
                return false;
            }

            _context.Books.Remove(existingBook);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateBookAsync(int bookId, Book book)
        {
            var existingBook = await GetBookByIdAsync(bookId);

            if (existingBook == null)
            {
                return false;
            }

            existingBook.Title = book.Title;
            existingBook.Genre = book.Genre;
            existingBook.Availability = book.Availability;
            _context.Update(existingBook);

            await _context.SaveChangesAsync();

            return true;
        }

        public static Task GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}

