using API_Movie_Tunes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Movie_Tunes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FilmesController(AppDbContext context)
        {
            _context = context; 
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Filmes.ToListAsync();
            return Ok(model);
        }
        [HttpPost]
        public async Task<ActionResult> Create(Filmes model)
        {
            _context.Filmes.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }
    }
}
