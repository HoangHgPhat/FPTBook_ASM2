using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FPTBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context,ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment)
        {
            dbContext = context;
            _logger = logger;
            webHostEnvironment = hostEnvironment;
        }

       
        public IActionResult Index()
        {
            
            return View();
        }

       
    }
}