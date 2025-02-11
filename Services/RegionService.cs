using WebApiIntro.Entites;
using WebApiIntro.Repositories;

namespace WebApiIntro.Services;

public class RegionService(IRegionRepository regionRepository) : IRegionService
{
    private readonly IRegionRepository _regionRepository = regionRepository;

    public Region Add(Region region)
    {
        var newRegion = _regionRepository.Add(region);
        return newRegion;
    }

    public bool Delete(int id)
    {
        var isDeleted = _regionRepository.Delete(id);
        return isDeleted;
    }

    public Region GetById(int id)
    {
        return _regionRepository.GetById(id);
    }

    public Region Update(Region region)
    {
        var updateRegion = _regionRepository.Update(region);
        return updateRegion;
    }

    List<Region> IRegionService.GetAll()
    {
        var regionList = _regionRepository.GetAll();
        return [.. regionList];
    }

}
