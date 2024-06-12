using Assignment.Api;
using Assignment.Api.Interfaces.BookLibraryInterfaces;
using Assignment.Service.Model.BookLibrary;
using Assignment.Service.Model.ResponseHandler;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assignment.Service.Services.BookLibraryService
{
    public class AuthorService
    {
        private readonly IDBAuthorRepository _authorRepository;
        private readonly ILogger<AuthorService> _logger;

        public AuthorService(IDBAuthorRepository authorRepository, ILogger<AuthorService> logger)
        {
            _authorRepository = authorRepository ?? throw new ArgumentNullException(nameof(authorRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<Author>> GetAllAuthorsAsync()
        {
            try
            {
                var authors = await _authorRepository.GetAllAuthorsAsync();

                _logger.LogInformation("Authors retrieved: {@Authors}", authors);

                return authors;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetAllAuthorsAsync");
                throw;
            }
        }

        public async Task<Author> GetAuthorByIdAsync(int authorId)
        {
            try
            {
                return await _authorRepository.GetAuthorByIdAsync(authorId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Author> AddAuthorAsync(AuthorRQ author)
        {
            try
            {
                if (await _authorRepository.CheckAuthorName(author.AuthorName))
                {
                    throw new ArgumentException("Author with the same name already exists");
                }

                var authorEntity = new Author()
                {
                    AuthorName = author.AuthorName,
                    AuthorBio = author.AuthorBio
                };

                var addedAuthor = await _authorRepository.AddAuthorAsync(authorEntity);
                return addedAuthor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteAuthorAsync(int authorId)
        {
            try
            {
                var existingAuthor = await _authorRepository.GetAuthorByIdAsync(authorId);

                if (existingAuthor == null)
                {
                    return false;
                }

                await _authorRepository.DeleteAuthorAsync(existingAuthor.AuthorId);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateAuthorAsync(int authorId, AuthorUpdateRQ author)
        {
            try
            {
                var existingAuthor = new Author()
                {
                    AuthorName = author.UpdatedAuthorName,
                    AuthorBio = author.UpdatedAuthorBio
                };

                var isUpdated = await _authorRepository.UpdateAuthorAsync(authorId, existingAuthor);
                return isUpdated;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
