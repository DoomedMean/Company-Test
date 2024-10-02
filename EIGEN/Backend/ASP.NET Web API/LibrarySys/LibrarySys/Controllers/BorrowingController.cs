using LibrarySys.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowingController : ControllerBase
    {
        private readonly LibraryContext _context;

        public BorrowingController(LibraryContext context)
        {
            _context = context;
        }

        // POST: api/Borrowing/borrow
        [HttpPost("borrow")]
        public async Task<IActionResult> BorrowBook([FromBody] Borrowing borrowing)
        {
            if (string.IsNullOrEmpty(borrowing.BookCode) || string.IsNullOrEmpty(borrowing.MemberCode))
            {
                return BadRequest("BookCode and MemberCode are required.");
            }

            var book = await _context.Books.FindAsync(borrowing.BookCode);
            if (book == null || book.Stock <= 0)
                return NotFound("Book not available.");

            var member = await _context.Members.FindAsync(borrowing.MemberCode);
            if (member == null)
                return NotFound("Member not found.");

            var borrowedBooksCount = await _context.Borrowings
                .CountAsync(b => b.MemberCode == borrowing.MemberCode && b.ReturnedAt == null);

            if (borrowedBooksCount >= 2)
                return BadRequest("Member has already borrowed 2 books.");

            borrowing.BorrowedAt = DateTime.UtcNow;
            _context.Borrowings.Add(borrowing);
            book.Stock--;
            await _context.SaveChangesAsync();

            return Ok(borrowing);
        }

        // POST: api/Borrowing/return
        [HttpPost("return")]
        public async Task<IActionResult> ReturnBook([FromBody] Borrowing borrowing)
        {
            var borrowed = await _context.Borrowings
                .FirstOrDefaultAsync(b => b.BookCode == borrowing.BookCode &&
                                          b.MemberCode == borrowing.MemberCode &&
                                          b.ReturnedAt == null);

            if (borrowed == null)
                return NotFound("No record of borrowed book.");

            borrowed.ReturnedAt = DateTime.UtcNow;
            var book = await _context.Books.FindAsync(borrowing.BookCode);
            book.Stock++;
            await _context.SaveChangesAsync();

            return Ok(borrowed);
        }
    }
}
