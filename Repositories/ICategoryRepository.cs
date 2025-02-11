using WebApiIntro.Entites;

namespace WebApiIntro.Repositories;

public interface ICategoryRepository
{
    Categories Add(Categories categories);
    Categories Update(Categories categories);
    bool Delete(int id);
    Categories GetById(int id);
    IQueryable<Categories> GetAll();
}
