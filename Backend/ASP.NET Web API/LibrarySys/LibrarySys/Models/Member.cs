using System.ComponentModel.DataAnnotations;

namespace LibrarySys.Models
{
    public class Member
    {
        [Key]
        public string Code { get; set; } // Primary key for Member

        public string Name { get; set; }
    }
}
