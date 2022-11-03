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
    public async Task<List<SuperHero>> AddHero(SuperHero hero)
    {
        _context.SuperHeroes.Add(hero);
        await _context.SaveChangesAsync();
        return await _context.SuperHeroes.ToListAsync();
    }
    public async Task<List<SuperHero>> UpdateHero(SuperHero request)
    {
        var dbHero = await _context.SuperHeroes.FindAsync(request.Id);
        if (dbHero == null)
            throw new Exception("No such superhero");
        dbHero.Name = request.Name;
        dbHero.FirstName = request.FirstName;
        dbHero.LastName = request.LastName;
        dbHero.Place = request.Place;
        await _context.SaveChangesAsync();
        
        return await _context.SuperHeroes.ToListAsync();
    }
    public async Task<List<SuperHero>> Delete(int id)
    {
        var dbHero = await _context.SuperHeroes.FindAsync(id);
        if (dbHero == null)
            throw new Exception("No such superhero");
        _context.SuperHeroes.Remove(dbHero);
        await _context.SaveChangesAsync();
        
        return await _context.SuperHeroes.ToListAsync();
    }
}