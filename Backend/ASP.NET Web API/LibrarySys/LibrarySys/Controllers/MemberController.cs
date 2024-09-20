using LibrarySys.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly LibraryContext _context;

        public MemberController(LibraryContext context)
        {
            _context = context;
        }

        // GET: api/Member
        [HttpGet]
        public async Task<IActionResult> GetMembers()
        {
            var members = await _context.Members.ToListAsync();
            return Ok(members);
        }

        // GET: api/Member/{code}
        [HttpGet("{code}")]
        public async Task<IActionResult> GetMember(string code)
        {
            var member = await _context.Members.FindAsync(code);
            if (member == null)
                return NotFound();

            var borrowedBooksCount = await _context.Borrowings
                .CountAsync(b => b.MemberCode == code && b.ReturnedAt == null);

            return Ok(new
            {
                Member = member,
                BorrowedBooksCount = borrowedBooksCount
            });
        }
    }
}
