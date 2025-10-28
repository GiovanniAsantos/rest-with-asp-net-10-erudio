using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10Erudio.Model;
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
    
    [HttpPost]
    public IActionResult CreatePerson([FromBody] Person person)
    {
        var createdPerson = _personService.Create(person);
        if (createdPerson == null) return BadRequest();
        return Created("Person created", createdPerson);
    }
    
    [HttpPut]
    public IActionResult UpdatePerson([FromBody] Person person)
    {
        var updatedPerson = _personService.Update(person);
        if (updatedPerson == null) return BadRequest();
        return Ok(updatedPerson);
    }  
    
    [HttpDelete ("{id}")]
    public IActionResult DeletePerson(long id)
    {
       _personService.Delete(id);
       return NoContent();
    }
}