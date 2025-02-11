using WebApiIntro.Context;
using WebApiIntro.Entites;

namespace WebApiIntro.Repositories;

public class CategoryRepository(AppDbContext context) : ICategoryRepository
{
    private readonly AppDbContext _context = context;

    public Categories Add(Categories categories)
    {
        _context.Add(categories);
        _context.SaveChanges();
        return categories;
    }

    public bool Delete(int id)
    {
        var category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);
        if (category != null)
        {
            _context.Remove(category);
            _context.SaveChanges();
            return true;
        }
        return false;

    }

    public IQueryable<Categories> GetAll()
    {
        return _context.Categories;
    }

    public Categories GetById(int id)
    {
        var category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);
        return category;
    }

    public Categories Update(Categories categories)
    {
        var category = _context.Categories.FirstOrDefault(x => x.CategoryID == categories.CategoryID);
        if (category != null)
        {
            _context.Update(categories);
            _context.SaveChanges();
            return categories;
        }
        return null;
    }
}
