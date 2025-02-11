using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiIntro.Entites;
using WebApiIntro.Services;

namespace WebApiIntro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController(ICaetgoryServices categoryService) : ControllerBase
{
    private readonly ICaetgoryServices _categoryService = categoryService;

    [HttpPost]
    [Route("AddCategory")]
    public IActionResult Create([FromBody] Categories category)
    {
        var newCategory = _categoryService.Add(category);
        return Ok(newCategory);
    }
    [HttpDelete]
    [Route("DeleteCategory")]
    public IActionResult Delete([FromBody] int id)
    {
        var isDelete = _categoryService.Delete(id);
        return Ok(isDelete);
    }
    [HttpGet]
    [Route("GetCategory")]
    public IActionResult GetAll()
    {
        var category = _categoryService.GetAll();
        return Ok(category);
    }
    [HttpPost]
    [Route("UpdateCategory")]
    public IActionResult Update(Categories category)
    {
        var updatedCategory = _categoryService.Update(category);
        return Ok(updatedCategory);
    }
}
