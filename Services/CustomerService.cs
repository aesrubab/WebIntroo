using WebApiIntro.Entites;
using WebApiIntro.Repositories;

namespace WebApiIntro.Services;

public class CustomerService(ICustomerRepository customerRepository) : ICustomerService
{
    private readonly ICustomerRepository _customerRepository = customerRepository;

    public Customer Add(Customer customer)
    {
        var newCustomer = _customerRepository.Add(customer);
        return newCustomer;
    }

    public bool Delete(string id)
    {
        var isDeleted = _customerRepository.Delete(id);
        return isDeleted;
    }

    public List<Customer> GetAll()
    {
        return _customerRepository.GetAll();
    }

    public Customer GetById(string id)
    {
        return _customerRepository.GetById(id);
    }

    public Customer Update(Customer customer)
    {
        return _customerRepository.Update(customer);
    }
}