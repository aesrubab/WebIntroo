using WebApiIntro.Context;
using WebApiIntro.Entites;

namespace WebApiIntro.Repositories;

public class RegionRepository(AppDbContext context) : IRegionRepository
{
    private readonly AppDbContext _context = context;

    public Region Add(Region region)
    {
        _context.Add(region);
        _context.SaveChanges();
        return region;
    }

    public bool Delete(int id)
    {
        var region = _context.Regions.FirstOrDefault(x => x.RegionId == id);
        if (region != null)
        {
            _context.Regions.Remove(region);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<Region> GetAll()
    {
        return _context.Regions;
    }

    public Region GetById(int id)
    {
        var regions = _context.Regions.FirstOrDefault(x => x.RegionId == id);
        return regions;
    }

    public Region Update(Region region)
    {
        var regions = _context.Regions.FirstOrDefault(r => r.RegionId == region.RegionId);
        if (regions != null)
        {
            _context.Regions.Update(region);
            _context.SaveChanges();
            return region;
        }
        return null;
    }
}
