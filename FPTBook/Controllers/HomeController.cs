using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FPTBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment)
        {
            dbContext = context;

            _logger = logger;
            webHostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return dbContext.Book != null ?
                        View(await dbContext.Book.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Book'  is null.");
        }

        public async Task<IActionResult> AddToCart(int? Id)
        {
            Book b;
            CartItem item = new CartItem();
            if (Id != null)
            {
                b = dbContext.Book.FirstOrDefault(b => b.Id == Id);
                item.Book = b;
                item.BookName = b.Name;
                item.Quantity = 1;
                item.Price = b.Price * item.Quantity;
            }
            dbContext.Add(item);
            await dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}