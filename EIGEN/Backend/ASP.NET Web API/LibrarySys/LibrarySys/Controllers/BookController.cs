using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibrarySys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly LibraryContext _context;

        public BookController(LibraryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            //    var books = new List<object>
            //{
            //    new { Code = "JK-45", Title = "Harry Potter", Author = "J.K Rowling", Stock = 1 },
            //    new { Code = "SHR-1", Title = "A Study in Scarlet", Author = "Arthur Conan Doyle", Stock = 1 }
            //};
            var books = await _context.Books.ToListAsync();
            return Ok(books);
        }
    }
}
