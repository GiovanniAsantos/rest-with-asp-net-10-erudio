using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10Erudio.Services;

namespace RestWithASPNET10Erudio.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_personService.FindAll());
    }
    
    [HttpGet ("{id}")]
    public IActionResult GetById(long id)
    {
        var person = _personService.FindById(id);
        
        if (person == null)
        {
            return NotFound();
        }
        
        return Ok(person);
    }
}