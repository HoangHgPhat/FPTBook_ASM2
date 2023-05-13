using FPTBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FPTBook.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FPTBook.Models.Author> Author { get; set; } = default!;
        public DbSet<FPTBook.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<FPTBook.Models.Book> Book { get; set; } = default!;
    }
}