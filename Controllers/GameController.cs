using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Dinozavr.Data;
using Dinozavr.Models;

namespace Dinozavr.Controllers
{
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GameController(ApplicationDbContext context)
        {
            _context = context;
        }
        // Метод для сохранения очков
        [HttpPost]
        public async Task<IActionResult> SaveScore([FromBody] GameScore score)
        {
            if (ModelState.IsValid)
            {
                _context.GameScores.Add(score);
                await _context.SaveChangesAsync();
                return Ok(new { success = true, message = "Score saved!" });
            }
            return BadRequest(new { success = false, message = "Invalid data" });
        }
    }
}
