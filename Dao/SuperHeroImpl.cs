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
    public Task<List<SuperHero>> Get()
    {
        return  _context.SuperHeroes.ToListAsync();
    }
}