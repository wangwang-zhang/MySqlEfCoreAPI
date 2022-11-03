using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI.Dao;

public interface ISuperHeroDao
{
    public Task<List<SuperHero>> Get();
    public Task<SuperHero> Get(int id);
    public Task<List<SuperHero>> AddHero(SuperHero hero);
    public Task<List<SuperHero>> UpdateHero(SuperHero hero);
    public Task<List<SuperHero>> Delete(int id);
}