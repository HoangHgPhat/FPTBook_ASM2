using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BookName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public virtual Book? Book { get; set; }
    }
}
