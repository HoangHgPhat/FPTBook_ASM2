using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(10, ErrorMessage = "{0} length must be exactly {1}",
            MinimumLength = 10)]

        public string? UCN { get; set; }
    }
}
