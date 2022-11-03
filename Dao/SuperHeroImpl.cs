using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Dao;

public class SuperHeroImpl : ISuperHeroDao
{
    private readonly DataContext _context;

    public SuperHeroImpl(DataContext context)
    {
        _context = context;
    }
    public async Task<List<SuperHero>> Get()
    {
        return  await _context.SuperHeroes.ToListAsync();
    }
    public async Task<SuperHero> Get(int id)
    {
        return await _context.SuperHeroes.FindAsync(id);
    }
}