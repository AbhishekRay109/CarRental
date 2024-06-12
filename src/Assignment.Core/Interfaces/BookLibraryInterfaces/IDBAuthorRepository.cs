using Assignment.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.BookLibraryInterfaces
{
    public interface IDBAuthorRepository
    {
        Task<List<Author>> GetAllAuthorsAsync();

        Task<Author> GetAuthorByIdAsync(int authorId);

        Task<List<Author>> GetAuthorByName(string name);

        Task<Author> AddAuthorAsync(Author author);

        Task<bool> CheckAuthorName(string authorName);

        Task<bool> DeleteAuthorAsync(int authorId);

        Task<bool> UpdateAuthorAsync(int authorId, Author author);
    }
}
