using Assignment.Api;
using Assignment.Service.Model.BookLibrary;
using Assignment.Service.Model.ResponseHandler;
using Assignment.Service.Services.BookLibraryService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Assignment.Api.Controllers
{
    /// <summary>
    /// Controller for managing authors.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : BaseController
    {
        private readonly AuthorService _authorService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorController"/> class.
        /// </summary>
        /// <param name="authorService">The service for managing authors.</param>
        /// <param name="logger">The logger instance.</param>
        public AuthorController(AuthorService authorService, Serilog.Core.Logger logger)
            : base(logger)
        {
            _authorService = authorService ?? throw new ArgumentNullException(nameof(authorService));
        }


        /// <summary>
        /// Retrieves all the authors from the collection.
        /// </summary>
        /// <returns>Returns a list of authors.</returns>
        /// <response code="200">OK - Success.</response>
        /// <response code="400">Bad Request.</response> 
        /// <response code="500">Internal Server Error.</response>
        /// <response code="401">Unauthorized.</response>
        /// <response code="403">Forbidden.</response>
        /// <response code="404">Not Found.</response>

        [HttpGet]
        [CustomAuthorize("book-admin")]

        public async Task<IActionResult> GetAllAuthors()
        {
            try
            {
                var authors = await _authorService.GetAllAuthorsAsync();

                Log.Information("Authors: {@Authors}", authors);

                return Ok(ResponseHandler.HandleSuccess<List<Author>>("Successfully fetched authors", authors));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<List<Author>>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }


        /// <summary>
        /// Retrieves an author by their unique identifier.
        /// </summary>
        /// <param name="authorId">The ID of the author to retrieve.</param>
        /// <returns>Returns the author with the specified ID.</returns>
        /// <response code="200">OK - Success.</response>
        /// <response code="400">Bad Request.</response> 
        /// <response code="500">Internal Server Error.</response>
        /// <response code="401">Unauthorized.</response>
        /// <response code="403">Forbidden.</response>
        /// <response code="404">Not Found.</response>

        [HttpGet("{authorId}")]
        [CustomAuthorize("book-user")]

        public async Task<IActionResult> GetAuthorById(int authorId)
        {
            try
            {
                var author = await _authorService.GetAuthorByIdAsync(authorId);
                if (author == null)
                    return NotFound(ResponseHandler.HandleError<Author>("NotFound", $"Author with ID {authorId} not found"));

                return Ok(ResponseHandler.HandleSuccess<Author>("Successfully fetched author", author));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<Author>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }


        /// <summary>
        /// Adds a new author to the collection.
        /// </summary>
        /// <param name="author">The author information to add.</param>
        /// <returns>Returns the added author with its unique identifier.</returns>
        /// <response code="200">OK - Success.</response>
        /// <response code="400">Bad Request.</response> 
        /// <response code="500">Internal Server Error.</response>
        /// <response code="401">Unauthorized.</response>
        /// <response code="403">Forbidden.</response>
        /// <response code="404">Not Found.</response>

        [HttpPost]
        [CustomAuthorize("book-admin")]

        public async Task<IActionResult> AddAuthor([FromBody] AuthorRQ author)
        {
            try
            {
                var addedAuthor = await _authorService.AddAuthorAsync(author);

                if (addedAuthor != null)
                {
                    return Ok(ResponseHandler.HandleSuccess<Author>("Author added successfully", addedAuthor));
                }
                else
                {
                    return Ok(ResponseHandler.HandleError<Author>("AlreadyExist", "Author already exists"));
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<Author>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }


        /// <summary>
        /// Deletes an author by its unique identifier.
        /// </summary>
        /// <param name="authorId">The ID of the author to delete.</param>
        /// <returns>Returns a message indicating the success of the deletion.</returns>
        /// <response code="200">OK - Success.</response>
        /// <response code="400">Bad Request.</response> 
        /// <response code="500">Internal Server Error.</response>
        /// <response code="401">Unauthorized.</response>
        /// <response code="403">Forbidden.</response>
        /// <response code="404">Not Found.</response>

        [HttpDelete("{authorId}")]
        [CustomAuthorize("book-admin")]

        public async Task<IActionResult> DeleteAuthor(int authorId)
        {
            try
            {
                var isDeleted = await _authorService.DeleteAuthorAsync(authorId);
                if (isDeleted)
                {
                    return Ok(ResponseHandler.HandleSuccess<string>("Author deleted successfully"));
                }
                else
                {
                    return Ok(ResponseHandler.HandleError<Author>("NotFound", $"Author with ID {authorId} not found"));
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<Author>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }


        /// <summary>
        /// Updates an existing author by its unique identifier.
        /// </summary>
        /// <param name="authorId">The ID of the author to update.</param>
        /// <param name="author">The updated author information.</param>
        /// <returns>Returns a message indicating the success of the update.</returns>
        /// <response code="200">OK - Success.</response>
        /// <response code="400">Bad Request.</response> 
        /// <response code="500">Internal Server Error.</response>
        /// <response code="401">Unauthorized.</response>
        /// <response code="403">Forbidden.</response>
        /// <response code="404">Not Found.</response>

        [HttpPut("{authorId}")]
        [CustomAuthorize("book-admin")]

        public async Task<IActionResult> UpdateAuthor(int authorId, [FromBody] AuthorUpdateRQ author)
        {
            try
            {
                var isUpdated = await _authorService.UpdateAuthorAsync(authorId, author);

                if (isUpdated)
                {
                    return Ok(ResponseHandler.HandleSuccess<string>("Author updated successfully", $"Author with ID {authorId} updated"));
                }
                else
                {
                    return Ok(ResponseHandler.HandleError<Author>("NotFound", $"Author with ID {authorId} not found"));
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<Author>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }
    }
}
