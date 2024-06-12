using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment.Api;
using Assignment.Infrastructure;
using Assignment.Infrastructure.Repository;
using Assignment.Service.Model.BookLibrary;
using Assignment.Api.Interfaces.BookLibraryInterfaces;

namespace Assignment.Service.Services.BookLibraryService
{
    public class BorrowedBookService
    {
        private readonly IDBBorrowedBookRepository _borrowedbookRepo;

        public BorrowedBookService(IDBBorrowedBookRepository borrowedbookRepo)
        {
            _borrowedbookRepo = borrowedbookRepo;
        }

        public async Task<List<BorrowedBook>> GetAllBorrowedBooksAsync()
        {
            return await _borrowedbookRepo.GetAllBorrowedBooksAsync();
        }

        public async Task<BorrowedBook> GetBorrowedBookByIdAsync(int id)
        {
            return await _borrowedbookRepo.GetBorrowedBookByIdAsync(id);
        }

        public async Task<BorrowedBookRQ> AddBorrowedBookAsync(BorrowedBookRQ borrowedBook)
        {
            var PostBook = new BorrowedBook
            {
                UserId = borrowedBook.UserId,
                
                BookId = borrowedBook.BookId,
                BorrowDate = borrowedBook.BorrowDate,
                ReturnDate = borrowedBook.ReturnDate
            };
            PostBook = await _borrowedbookRepo.AddBorrowedBookAsync(PostBook);
            var borrowedBooklist = await _borrowedbookRepo.GetAllBorrowedBooksAsync();
            if(borrowedBooklist.Any(e=>e.BookId==borrowedBook.BookId))
                {
                throw new ArgumentException("book already borrowed");
            }
            var PostBookRS = new BorrowedBookRQ
            {
                UserId = PostBook.UserId,
                BookId = PostBook.BookId,
                BorrowDate = PostBook.BorrowDate,
                ReturnDate = PostBook.ReturnDate
            };
            return PostBookRS;
        }

        public async Task<BorrowedBook> UpdateBorrowedBookAsync(int id, UpdateBorrowedBookRQ borrowedBook)
        {
            var existingBook = await _borrowedbookRepo.GetBorrowedBookByIdAsync(id);
            existingBook.ReturnDate = borrowedBook.ReturnDate;
            var response = await _borrowedbookRepo.UpdateBorrowedBookAsync(id, existingBook);
            return response;
        }

        public async Task DeleteBorrowedBookAsync(int id)
        {
            await _borrowedbookRepo.DeleteBorrowedBookAsync(id);
        }
    }
}
