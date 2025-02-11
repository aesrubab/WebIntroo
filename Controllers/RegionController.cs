using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiIntro.Entites;
using WebApiIntro.Services;

namespace WebApiIntro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegionController(IRegionService regionService) : ControllerBase
{
    private readonly IRegionService _regionService = regionService;
    [HttpPost]
    [Route("AddRegion")]
    public IActionResult Create([FromBody] Region region)
    {
        var newRegion = _regionService.Add(region);
        return Ok(newRegion);
    }
    [HttpDelete]
    [Route("DeleteRegion")]
    public IActionResult Delete([FromBody] int id)
    {
        var isDelete = _regionService.Delete(id);
        return Ok(isDelete);
    }
    [HttpGet]
    [Route("GetRegion")]
    public IActionResult GetAll()
    {
        var regions = _regionService.GetAll();
        return Ok(regions);
    }
    [HttpPost]
    [Route("UpdateRegion")]
    public IActionResult Update(Region region)
    {
        var updatedRegion = _regionService.Update(region);
        return Ok(updatedRegion);
    }
}