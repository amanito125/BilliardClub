using BilliardClub.Data;
using BilliardClub.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BilliardClub.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            int allUsersCount = _context.User.Count();
            int allTablesCount = _context.Table.Count();
            int allReservationsCount = _context.Reservation.Count();
            ViewData["AllUsersCount"] = allUsersCount;
            ViewData["AllTablesCount"] = allTablesCount;
            ViewData["AllReservationsCount"] = allReservationsCount;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
