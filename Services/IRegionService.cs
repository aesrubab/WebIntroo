using WebApiIntro.Entites;

namespace WebApiIntro.Services;

public interface IRegionService
{
    Region Add(Region region);
    Region Update(Region region);
    bool Delete(int id);
    Region GetById(int id);
    List<Region> GetAll();
}
