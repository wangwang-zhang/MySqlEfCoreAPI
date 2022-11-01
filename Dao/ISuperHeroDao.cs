using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI.Dao;

public interface ISuperHeroDao
{
    public Task<List<SuperHero>> Get();
    
}