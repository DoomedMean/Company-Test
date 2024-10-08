using System.ComponentModel.DataAnnotations;

namespace LibrarySys.Models
{
    public class Book
    {
        [Key]
        public string Code { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Stock {  get; set; }
    }
}
