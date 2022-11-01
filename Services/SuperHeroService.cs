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
}