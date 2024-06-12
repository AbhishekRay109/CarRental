using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Assignment.Api;
using Assignment.Infrastructure;
using Assignment.Api.Interfaces.BookLibraryInterfaces;

namespace Assignment.Infrastructure.Repository.BookLibrary
{
    public class BorrowedBookRepository : IDBBorrowedBookRepository
    {
        private readonly RaidenDBContext _context;

        public BorrowedBookRepository(RaidenDBContext context)
        {
            _context = context;
        }

        public async Task<List<BorrowedBook>> GetAllBorrowedBooksAsync()
        {
            return await _context.BorrowedBooks.ToListAsync();
        }

        public async Task<BorrowedBook> GetBorrowedBookByIdAsync(int id)
        {
            return await _context.BorrowedBooks.FindAsync(id);
        }

        public async Task<BorrowedBook> AddBorrowedBookAsync(BorrowedBook borrowedBook)
        {
            int lastBorrowedId = await _context.BorrowedBooks
        .OrderByDescending(b => b.BorrowId)
        .Select(b => b.BorrowId)
        .FirstOrDefaultAsync();
            int newBorrowedId = lastBorrowedId + 1;

            // Set the new BorrowedId for the borrowedBook
            borrowedBook.BorrowId = newBorrowedId;
            _context.BorrowedBooks.Add(borrowedBook);
            await _context.SaveChangesAsync();
            return borrowedBook;
        }

        public async Task<BorrowedBook> UpdateBorrowedBookAsync(int id, BorrowedBook borrowedBook)
        {
            if (id != borrowedBook.BorrowId)
            {
                throw new ArgumentException("Invalid ID");
            }

            _context.Entry(borrowedBook).State = EntityState.Modified;

            try
            {
                _context.Update(borrowedBook);
                await _context.SaveChangesAsync();
                return borrowedBook;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BorrowedBookExists(id))
                {
                    throw new KeyNotFoundException("Borrowed book not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task DeleteBorrowedBookAsync(int id)
        {
            var borrowedBook = await _context.BorrowedBooks.FindAsync(id);
            if (borrowedBook == null)
            {
                throw new KeyNotFoundException("Borrowed book not found");
            }

            _context.BorrowedBooks.Remove(borrowedBook);
            await _context.SaveChangesAsync();
        }

        private bool BorrowedBookExists(int id)
        {
            return _context.BorrowedBooks.Any(e => e.BorrowId == id);
        }
    }
}
