using SuperHeroAPI.Dao;

namespace SuperHeroAPI.Services;

public class SuperHeroService
{
    private readonly ISuperHeroDao _superHeroDao;

    public SuperHeroService(ISuperHeroDao superHeroDao)
    {
        _superHeroDao = superHeroDao;
    }

    public Task<List<SuperHero>> GetSuperHeroes()
    {
        return _superHeroDao.Get();
    }

    public Task<SuperHero> GetSuperHeroesById(int id)
    {
        return _superHeroDao.Get(id);
    }

    public Task<List<SuperHero>> AddSuperHero(SuperHero superHero)
    {
        return _superHeroDao.AddHero(superHero);
    }

    public Task<List<SuperHero>> UpdateSuperHero(SuperHero superHero)
    {
        return _superHeroDao.UpdateHero(superHero);
    }

    public Task<List<SuperHero>> DeleteSuperHero(int id)
    {
        return _superHeroDao.Delete(id);
    }
}