using Microsoft.AspNetCore.Mvc;
using WebApiIntro.DTOs;
using WebApiIntro.Entites;
using WebApiIntro.Services;

namespace WebApiIntro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController(ICustomerService customerService) : ControllerBase
{
    private readonly ICustomerService _customerService = customerService;
    private static List<Customer> customers = new();

    [HttpPost]
    public IActionResult CreateCustomer(Customer customer)
    {
        var newCustomer = _customerService.Add(customer);
        return Ok(newCustomer);
    }

    [HttpDelete]
    public IActionResult DeleteCustomer(string id)
    {
        var isDeleted = _customerService.Delete(id);
        return Ok(isDeleted);
    }

    [HttpGet]
    public IActionResult GetAllCustomer() {
        var customers = _customerService.GetAll();
        return Ok(customers);
    }

    [HttpGet("{id}")]
    public IActionResult GetCustomerById(string id)
    {
        var customer = _customerService.GetById(id);
        if (customer == null)
        {
            return NotFound("Customer not found");
        }
        return Ok(customer);
    }

    [HttpPut]
    public IActionResult Update(Customer customer)
    {
        var currentCustomer = customers.FirstOrDefault(x => x.CustomerId == customer.CustomerId);

        if (currentCustomer == null)
            return NotFound("Customer does not exist with provided Id");

        currentCustomer.CompanyName = customer.CompanyName;
        currentCustomer.Address = customer.Address;

        return Ok(customers);
    }

   


}