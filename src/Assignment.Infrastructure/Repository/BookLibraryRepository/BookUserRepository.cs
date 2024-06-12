using Assignment.Api;
using Assignment.Api.Interfaces.BookLibraryInterfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.BookLibrary
{
    public class BookUserRepository : IDBBookUserRepository
    {
        private readonly RaidenDBContext _context;

        public BookUserRepository(RaidenDBContext context)
        {
            _context = context;
        }

        public async Task<List<BookUser>> GetAllUsersAsync()
        {
            return await _context.BookUsers.ToListAsync();
        }

        public async Task<BookUser> GetUserByIdAsync(int userId)
        {
            return await _context.BookUsers.FindAsync(userId);
        }

        public async Task<BookUser> GetUserByUserNameAsync(string userName)
        {
            return await _context.BookUsers.FirstOrDefaultAsync(u => u.Username == userName);
        }

        public async Task<BookUser> CreateUserAsync(BookUser user)
        {
            _context.BookUsers.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> UpdateUserAsync(int userId, BookUser updatedUser)
        {
            var existingUser = await _context.BookUsers.FindAsync(userId);

            if (existingUser == null)
                return false;

            existingUser.Username = updatedUser.Username;
            existingUser.PasswordHash = updatedUser.PasswordHash;
            existingUser.Role = updatedUser.Role;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await _context.BookUsers.FindAsync(userId);

            if (user == null)
                return false;

            _context.BookUsers.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
