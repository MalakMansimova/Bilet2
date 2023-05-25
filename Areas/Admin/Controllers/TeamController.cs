using BZLAND.Areas.Admin.ViewModel;
using BZLAND.DAL;
using BZLAND.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BZLAND.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        private readonly AddDbContext _context;
        public TeamController(AddDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Team>Teams=await _context.Teams.ToListAsync();
        
            return View();
        }
    }
}
