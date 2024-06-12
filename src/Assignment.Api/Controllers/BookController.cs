using Assignment.Api;
using Assignment.Service.Model.BookLibrary;
using Assignment.Service.Model.ResponseHandler;
using Assignment.Service.Services.BookLibraryService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Assignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : BaseController
    {
        private readonly BookService _bookService;
        private readonly ILogger<BookController> _logger;

        public BookController(BookService bookService, ILogger<BookController> logger, Serilog.Core.Logger serilogLogger)
                    : base(serilogLogger)
        {
            _bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        /// <summary>
        /// Retrieves all the books from the collection.
        /// </summary>
        /// <returns>Returns the book with the specified ID.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpGet]
        [CustomAuthorize("book-user")]

        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                var books = await _bookService.GetAllBooksAsync();
                return Ok(ResponseHandler.HandleSuccess<List<Book>>("Successfully fetched books", books));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving all books");
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<List<Book>>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }

        /// <summary>
        /// Retrieves a book by its unique identifier.
        /// </summary>
        /// <param name="bookId">The ID of the book to retrieve.</param>
        /// <returns>Returns the book with the specified ID.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpGet("{bookId}")]
        [CustomAuthorize("book-user")]

        public async Task<IActionResult> GetBookById(int bookId)
        {
            try
            {
                var book = await _bookService.GetBookByIdAsync(bookId);
                if (book == null)
                    return Ok(ResponseHandler.HandleError<Book>("NotFound", $"Book with ID {bookId} not found"));

                return Ok(ResponseHandler.HandleSuccess<Book>("Successfully fetched book", book));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while retrieving book with ID: {bookId}");
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<Book>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }


        /// <summary>
        /// Adds a new book to the collection.
        /// </summary>
        /// <param name="book">The book information to add.</param>
        /// <returns>Returns the added book with its unique identifier.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpPost]
        [CustomAuthorize("book-user")]

        public async Task<IActionResult> AddBook([FromBody] BookRQ book)
        {
            try
            {
                var addedBook = await _bookService.AddBookAsync(book);

                if (addedBook != null)
                {
                    return Ok(ResponseHandler.HandleSuccess<Book>("Book added successfully", addedBook));
                }
                else
                {
                    return Ok(ResponseHandler.HandleError<Book>("AlreadyExist", "Book already exists"));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding a new book");
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<Book>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }



        /// <summary>
        /// Deletes a book by its unique identifier.
        /// </summary>
        /// <param name="bookId">The ID of the book to delete.</param>
        /// <returns>Returns the book with the specified ID.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpDelete("{bookId}")]
        [CustomAuthorize("book-admin")]

        public async Task<IActionResult> DeleteBook(int bookId)
        {
            try
            {
                var isDeleted = await _bookService.DeleteBookAsync(bookId);
                if (isDeleted)
                {
                    return Ok(ResponseHandler.HandleSuccess<string>("Book deleted successfully"));
                }
                else
                {
                    return Ok(ResponseHandler.HandleError<Book>("NotFound", $"Book with ID {bookId} not found"));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while deleting book with ID: {bookId}");
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<Book>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }


        /// <summary>
        /// Updates a book by its unique identifier.
        /// </summary>
        /// <param name="book">The book to delete.</param>
        /// <returns>Returns the book with the specified ID.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpPut("{bookId}")]
        [CustomAuthorize("book-admin")]

        public async Task<IActionResult> UpdateBook(int bookId, [FromBody] BookUpdateRQ book)
        {
            try
            {
                var isUpdated = await _bookService.UpdateBookAsync(bookId, book);

                if (isUpdated)
                {
                    return Ok(ResponseHandler.HandleSuccess<string>("Book updated successfully", $"Book with ID {bookId} updated"));
                }
                else
                {
                    return Ok(ResponseHandler.HandleError<Book>("NotFound", $"Book with ID {bookId} not found"));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while updating book with ID: {bookId}");
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<Book>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }
    }
}
