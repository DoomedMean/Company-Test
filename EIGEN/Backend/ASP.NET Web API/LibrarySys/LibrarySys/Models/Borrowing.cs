using System.ComponentModel.DataAnnotations;

namespace LibrarySys.Models
{
    public class Borrowing
    {
        [Key]
        public int Id { get; set; } // Primary key for Borrowing

        [Required]public string BookCode { get; set; } // Foreign key to Book
        public Book Book { get; set; } // Navigation property

        [Required]public string MemberCode { get; set; } // Foreign key to Member
        public Member Member { get; set; } // Navigation property

        public DateTime BorrowedAt { get; set; }
        public DateTime? ReturnedAt { get; set; }
    }
}
