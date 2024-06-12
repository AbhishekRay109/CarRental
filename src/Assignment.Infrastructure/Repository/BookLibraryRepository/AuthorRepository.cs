using Assignment.Api;
using Assignment.Api.Interfaces.BookLibraryInterfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.BookLibrary
{
    public class AuthorRepository : GenericRepository<Author>, IDBAuthorRepository
    {
        private readonly RaidenDBContext _context;

        public AuthorRepository(RaidenDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Author>> GetAllAuthorsAsync()
        {
            return await _context.Authors.ToListAsync();
        }

        public async Task<Author> GetAuthorByIdAsync(int authorId)
        {
            return await _context.Authors.FirstOrDefaultAsync(a => a.AuthorId == authorId);
        }

        public async Task<Author> AddAuthorAsync(Author author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return author;
        }

        public async Task<bool> CheckAuthorName(string authorName)
        {
            return await _context.Authors.AnyAsync(a => a.AuthorName == authorName);
        }

        public async Task<bool> DeleteAuthorAsync(int authorId)
        {
            var existingAuthor = await GetAuthorByIdAsync(authorId);

            if (existingAuthor == null)
            {
                return false;
            }

            _context.Authors.Remove(existingAuthor);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateAuthorAsync(int authorId, Author author)
        {
            var existingAuthor = await GetAuthorByIdAsync(authorId);

            if (existingAuthor == null)
            {
                return false;
            }

            existingAuthor.AuthorName = author.AuthorName;
            existingAuthor.AuthorBio = author.AuthorBio;

            _context.Update(existingAuthor);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Author>> GetAuthorByName(string name)
        {
            return await _context.Authors.Where(a => a.AuthorName == name).ToListAsync();
        }

        public async Task<List<Author>> GetAuthorByIdandName(int id, string name)
        {
            return await _context.Authors.Where(a => a.AuthorName == name).ToListAsync();
        }
    }
}
