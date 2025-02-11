using WebApiIntro.Entites;

namespace WebApiIntro.Repositories;

public interface IRegionRepository
{
    Region Add(Region region);
    Region Update(Region region);
    bool Delete(int id);
    Region GetById(int id);
    IQueryable<Region> GetAll();
}
