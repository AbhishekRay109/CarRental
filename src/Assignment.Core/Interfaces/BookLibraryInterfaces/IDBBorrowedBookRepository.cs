using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Api;

namespace Assignment.Api.Interfaces.BookLibraryInterfaces
{
    public interface IDBBorrowedBookRepository
    {
        Task<List<BorrowedBook>> GetAllBorrowedBooksAsync();

        Task<BorrowedBook> GetBorrowedBookByIdAsync(int id);

        Task<BorrowedBook> AddBorrowedBookAsync(BorrowedBook borrowedBook);

        Task<BorrowedBook> UpdateBorrowedBookAsync(int id, BorrowedBook borrowedBook);

        Task DeleteBorrowedBookAsync(int id);
    }
}
