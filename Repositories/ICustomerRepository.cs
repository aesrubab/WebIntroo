using WebApiIntro.Entites;

namespace WebApiIntro.Repositories;

public interface ICustomerRepository
{
    Customer Add(Customer customer);
    Customer Update(Customer customer);
    Customer GetById(string id);
    List<Customer> GetAll();
    bool Delete(string id);
}