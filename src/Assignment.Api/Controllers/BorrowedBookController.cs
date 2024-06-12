using Assignment.Infrastructure;
using Assignment.Service.Model.BookLibrary;
using Assignment.Service.Services.BookLibraryService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assignment.Api.Controllers
{
    /// <summary>
    /// Controller for managing borrowed books.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BorrowedBooksController : ControllerBase
    {
        private readonly BorrowedBookService _borrowedBookService;

        /// <summary>
        /// Initializes a new instance of the <see cref="BorrowedBooksController"/> class.
        /// </summary>
        /// <param name="borrowedBookService">The service.</param>
        public BorrowedBooksController(BorrowedBookService borrowedBookService)
        {
            _borrowedBookService = borrowedBookService;
        }

        /// <summary>
        /// Gets a list of all borrowed books.
        /// </summary>
        /// <returns>A list of borrowed books.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpGet]
        [CustomAuthorize("book-user")]

        public async Task<ActionResult<IEnumerable<BorrowedBook>>> GetBorrowedBooks()
        {
            return await _borrowedBookService.GetAllBorrowedBooksAsync();
        }

        /// <summary>
        /// Gets a specific borrowed book by ID.
        /// </summary>
        /// <param name="id">The ID of the borrowed book.</param>
        /// <returns>The requested borrowed book.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpGet("{id}")]
        public async Task<ActionResult<BorrowedBook>> GetBorrowedBook(int id)
        {
            var borrowedBook = await _borrowedBookService.GetBorrowedBookByIdAsync(id);

            if (borrowedBook == null)
            {
                return NotFound();
            }

            return borrowedBook;
        }

        /// <summary>
        /// Adds a new borrowed book.
        /// </summary>
        /// <param name="borrowedBookRQ">The request object containing borrowed book details.</param>
        /// <returns>The newly created borrowed book.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpPost]
        [CustomAuthorize("book-user")]

        public async Task<ActionResult<BorrowedBookRQ>> PostBorrowedBook(BorrowedBookRQ borrowedBookRQ)
        {
            var addedBookId = await _borrowedBookService.AddBorrowedBookAsync(borrowedBookRQ);
            return Ok(borrowedBookRQ);
        }

        /// <summary>
        /// Updates an existing borrowed book.
        /// </summary>
        /// <param name="id">The ID of the borrowed book to be updated.</param>
        /// <param name="borrowedBook">The updated borrowed book details.</param>
        /// <returns>NoContent if the update is successful; BadRequest if the ID doesn't match the book details.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpPut("{id}")]
        [CustomAuthorize("book-user")]

        public async Task<IActionResult> PutBorrowedBook(int id, UpdateBorrowedBookRQ borrowedBook)
        {
            await _borrowedBookService.UpdateBorrowedBookAsync(id, borrowedBook);
            return Ok(borrowedBook);
        }

        /// <summary>
        /// Deletes a borrowed book by ID.
        /// </summary>
        /// <param name="id">The ID of the borrowed book to be deleted.</param>
        /// <returns>NoContent if the deletion is successful; NotFound if the book is not found.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpDelete("{id}")]
        [CustomAuthorize("book-admin")]

        public async Task<IActionResult> DeleteBorrowedBook(int id)
        {
            await _borrowedBookService.DeleteBorrowedBookAsync(id);
            return Ok("Successfully Deleted");
        }
    }
}
