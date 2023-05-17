using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string? BookURL { get; set; }
    }
}
