using WebApiIntro.Entites;

namespace WebApiIntro.Services;

public interface ICustomerService
{
    Customer Add(Customer customer);
    Customer Update(Customer customer);
    Customer GetById(string id);
    List<Customer> GetAll();
    bool Delete(string id);
}