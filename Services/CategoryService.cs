using WebApiIntro.Entites;
using WebApiIntro.Repositories;

namespace WebApiIntro.Services;

public class CategoryService(ICategoryRepository categoryRepository) : ICaetgoryServices
{
    private readonly ICategoryRepository _categoryRepository = categoryRepository;

    public Categories Add(Categories categories)
    {
        var newCategory = _categoryRepository.Add(categories);
        return newCategory;
    }

    public bool Delete(int id)
    {
        var isDeleted = _categoryRepository.Delete(id);
        return isDeleted;
    }

    public List<Categories> GetAll()
    {
        var categoryList = _categoryRepository.GetAll();
        return [.. categoryList];
    }

    public Categories GetById(int id)
    {
        var region = _categoryRepository.GetById(id);
        return region;
    }

    public Categories Update(Categories categories)
    {
        var regionUpdate = _categoryRepository.Update(categories);
        return regionUpdate;
    }
}
