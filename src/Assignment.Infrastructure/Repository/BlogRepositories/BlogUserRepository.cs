using Amazon.Util.Internal.PlatformServices;
using Assignment.Api.Interfaces;
using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Api.Models;
using Assignment.Api.Models.BlogModels;
using Assignment.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.BlogRepositories
{
    public class BlogUserRepository : GenericRepository<BlogUsers>, IDBBlogUserRepository
    {
        private readonly RaidenDBContext _context;

        public BlogUserRepository(RaidenDBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<BlogUsers> GetUsernameByIdAsync(string username)
        {
            var userEntity = await _context.BlogUsers.FirstOrDefaultAsync(o => o.Username == username);
            return userEntity;
        }

        public async Task<BlogUsers> GetUserIdByIdAsync(int userId)
        {
            var applicationEntity = await _context.BlogUsers.FirstOrDefaultAsync(e => e.UserId == userId);
            return applicationEntity;
        }

        public async Task UpdatePostAsync(BlogPosts blogPosts)
        {
            _context.Entry(blogPosts).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<BlogUsers> GetUserByUsernameAsync(string username)
        {
            return await _context.BlogUsers.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<BlogUsers> GetUserByIdAsync(int userId)
        {
            return await _context.BlogUsers.FindAsync(userId);
        }

        public async Task<BlogUsers> UpdateUserAsync(BlogUsers user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
    
    
