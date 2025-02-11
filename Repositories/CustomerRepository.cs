using Microsoft.EntityFrameworkCore;
using WebApiIntro.Context;
using WebApiIntro.Entites;

namespace WebApiIntro.Repositories;

public class CustomerRepository(AppDbContext context) : ICustomerRepository
{
    private readonly AppDbContext _context = context;

    public Customer Add(Customer customer)
    {
        _context.Add(customer);
        _context.SaveChanges();
        return customer;
    }

    public bool Delete(string id)
    {
        var currentUser = _context.Customers.FirstOrDefault(x => x.CustomerId == id);
        if (currentUser != null)
        {
            _context.Remove(currentUser);
            _context.SaveChanges();
            return true;
        }
        return false;

    }

    public List<Customer> GetAll()
    {
        return _context.Customers.ToList();
    }

    public Customer GetById(string id)
    {
        var currentUser = _context.Customers.FirstOrDefault(x => x.CustomerId == id);
        return currentUser;
    }

    public Customer Update(Customer customer)
    {
        _context.Customers.Update(customer);
        _context.SaveChanges();
        return customer;
    }
}