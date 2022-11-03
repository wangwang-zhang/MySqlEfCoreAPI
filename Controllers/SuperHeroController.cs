using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Services;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
       // private readonly DataContext _context;
        private readonly SuperHeroService _superHeroService;

        public SuperHeroController(SuperHeroService superHeroService)
        {
            //_context = context;
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return Ok(await _superHeroService.GetSuperHeroes());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> Get(int id)
        {
            var hero = await _superHeroService.GetSuperHeroesById(id);
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            List<SuperHero> superHeroes = await _superHeroService.AddSuperHero(hero);
            return Ok(superHeroes);
        }
        
        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero hero)
        {
            List<SuperHero> superHeroes = await _superHeroService.UpdateSuperHero(hero);
            return Ok(superHeroes);
        }
        
        // [HttpDelete("{id}")]
        // public async Task<ActionResult<List<SuperHero>>> Delete(int id)
        // {
        //     var dbHero = await _context.SuperHeroes.FindAsync(id);
        //     if (dbHero == null)
        //         return BadRequest("Hero not found.");
        //
        //     _context.SuperHeroes.Remove(dbHero);
        //     await _context.SaveChangesAsync();
        //
        //     return Ok(await _context.SuperHeroes.ToListAsync());
        // }

    }
}
