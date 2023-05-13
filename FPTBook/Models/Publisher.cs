using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Publisher
    {
        public string? ProfileURL { get; set; }
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
