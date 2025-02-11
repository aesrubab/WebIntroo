using WebApiIntro.Entites;

namespace WebApiIntro.Services;

public interface ICaetgoryServices
{
    Categories Add(Categories categories);
    Categories Update(Categories categories);
    bool Delete(int id);
    Categories GetById(int id);
    List<Categories> GetAll();
}
