using Assignment.Api;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.BookLibraryInterfaces
{
    public interface IDBBookUserRepository
    {
        Task<List<BookUser>> GetAllUsersAsync();

        Task<BookUser> GetUserByIdAsync(int userId);

        Task<BookUser> GetUserByUserNameAsync(string userName);

        Task<BookUser> CreateUserAsync(BookUser user);

        Task<bool> UpdateUserAsync(int userId, BookUser updatedUser);

        Task<bool> DeleteUserAsync(int userId);
    }
}
