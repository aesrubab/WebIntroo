using Microsoft.AspNetCore.Mvc;
using WebApiIntro.DTOs;
using WebApiIntro.Entites;

namespace WebApiIntro.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class UserController : ControllerBase
{
    List<User> users = [

        new User(){ Id=1 , Name="Nizami" , Surname = "Amirov" , Email="nizami@gmail.com"},
        new User(){ Id=2 , Name="Rubab" , Surname = "Huseynova" , Email="huseynova@gmail.com"},
        new User(){ Id=3 , Name="Aqshin" , Surname = "Ehmedli" , Email="ehmedli@gmail.com"}

        ];

    [HttpGet]
    public List<User> GetAllUser()
    {
        return users;
    }

    [HttpGet("{id}")]
    public User GetById([FromRoute]int id)
    {
        var currentUser = users.FirstOrDefault(x => x.Id == id);
        return currentUser;
    }

    [HttpDelete]
    public List<User> Delete(int id)
    {
        var currentUser = users.FirstOrDefault(x => x.Id == id);
        users.Remove(currentUser);
        return users;
    }

    [HttpPost]
    public List<User> Create([FromBody] User model)
    {
        users.Add(model);
        return users;
    }

    [HttpPut]
    public IActionResult Update(User user)
    {
        var currentUser = users.FirstOrDefault(x => x.Id == user.Id);

        if (currentUser == null)
            return NotFound("user does not exist with provided Id");

        currentUser.Name= user.Name;
        currentUser.Surname = user.Surname;
        currentUser.Email = user.Email;

        return Ok(users);

    }

    [HttpGet]
    public InitialUserDataDto GetInitialData(int id)
    {
        var currentUser = users.FirstOrDefault(x => x.Id == id);
        return new InitialUserDataDto()
        {
            Id = currentUser.Id,
            Name = currentUser.Name,
        };
    }
}
