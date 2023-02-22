using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameLibrary.Data;
using GameLibrary.Models;

namespace GameLibrary.Controllers
{
    public class PublisherController : Controller
    {
        private readonly GameContext _context;
        public PublisherController(GameContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var list = View(_context.Publishers
                                .Include(b => b.BoardGames)
                                .ToList());
            return View();
        }


        public ActionResult GameDetails(int publisherId)
        {
            if (publisherId == null)
            {
                return NotFound();
            }
            var game = _context.BoardGames
                .Where(b => b.Id == publisherId)
                .ToList();

            return View(game);
        }
    }
}
