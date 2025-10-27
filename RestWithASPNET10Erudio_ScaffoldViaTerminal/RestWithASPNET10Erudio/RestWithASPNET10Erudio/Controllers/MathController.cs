using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10Erudio.Services;
using RestWithASPNET10Erudio.Utils;

namespace RestWithASPNET10Erudio.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    private readonly MathService _mathService;
    public MathController(MathService mathService)
    {
        _mathService = mathService;
    }
    
    [HttpGet ("sum/{firstNumber}/{secondNumber}")]
    public IActionResult GetSum(string firstNumber, string secondNumber)
    {
        if(NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
        {
            var sum = _mathService.Sum(NumberHelper.ConvertToDecimal(firstNumber),
                NumberHelper.ConvertToDecimal(secondNumber));
            return Ok(sum);
        }
        
        return BadRequest("Invalid Input"); 
    }
    
    [HttpGet ("sub/{firstNumber}/{secondNumber}")]
    public IActionResult GetSub(string firstNumber, string secondNumber)
    {
        if(NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
        {
            var sub = _mathService.Sub(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
            return Ok(sub);
        }
        
        return BadRequest("Invalid Input");
    }  
    
    [HttpGet ("div/{firstNumber}/{secondNumber}")]
    public IActionResult GetDiv(string firstNumber, string secondNumber)
    {
        if(NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
        {
            var div = _mathService.Div(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
            return Ok(div);
        }
        
        return BadRequest("Invalid Input");
    }
    
    [HttpGet ("mult/{firstNumber}/{secondNumber}")]
    public IActionResult GetMult(string firstNumber, string secondNumber)
    {
        if(NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
        {
            var mult = _mathService.Mult(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
            return Ok(mult);
        }
        
        return BadRequest("Invalid Input");
    }    
    
    [HttpGet ("media/{firstNumber}/{secondNumber}")]
    public IActionResult GetMedia(string firstNumber, string secondNumber)
    {
        if(NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
        {
            var media = _mathService.Media(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
            return Ok(media);
        }
        
        return BadRequest("Invalid Input");
    } 
    
    [HttpGet ("raiz/{firstNumber}")]
    public IActionResult GetRaiz(string firstNumber)
    {
        if(NumberHelper.IsNumeric(firstNumber))
        {
            var raiz =_mathService.Raiz(NumberHelper.ConvertToDecimal(firstNumber));
            return Ok(raiz);
        }
        return BadRequest("Invalid Input");
    }
}