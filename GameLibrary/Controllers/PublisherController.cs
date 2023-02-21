using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameLibrary.Data;
using GameLibrary.Models;

namespace GameLibrary.Controllers
{
    public class PublisherController : Controller
    {
        private readonly DbContext _context;
        public PublisherController(DbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
