using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET10Erudio.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    [HttpGet ("sum/{firstNumber}/{secondNumber}")]
    public IActionResult GetSum(string firstNumber, string secondNumber)
    {
        if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
            return Ok(sum);
        }
        
        return BadRequest("Invalid Input");
    }
    
    [HttpGet ("sub/{firstNumber}/{secondNumber}")]
    public IActionResult GetSub(string firstNumber, string secondNumber)
    {
        if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
            return Ok(sub);
        }
        
        return BadRequest("Invalid Input");
    }  
    
    [HttpGet ("div/{firstNumber}/{secondNumber}")]
    public IActionResult GetDiv(string firstNumber, string secondNumber)
    {
        if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
            return Ok(div);
        }
        
        return BadRequest("Invalid Input");
    }
    
    [HttpGet ("mult/{firstNumber}/{secondNumber}")]
    public IActionResult GetMult(string firstNumber, string secondNumber)
    {
        if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var mult = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
            return Ok(mult);
        }
        
        return BadRequest("Invalid Input");
    }    
    
    [HttpGet ("media/{firstNumber}/{secondNumber}")]
    public IActionResult GetMedia(string firstNumber, string secondNumber)
    {
        if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var media = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
            return Ok(media);
        }
        
        return BadRequest("Invalid Input");
    } 
    
    [HttpGet ("raiz/{firstNumber}")]
    public IActionResult GetRaiz(string firstNumber)
    {
        if(IsNumeric(firstNumber))
        {
            var raiz = Math.Sqrt((double)ConvertToDecimal(firstNumber));
            return Ok(raiz);
        }
        return BadRequest("Invalid Input");
    }

    private decimal ConvertToDecimal(string strNumber)
    {
        decimal decimalValue;
        if (
            decimal.TryParse(
                strNumber, 
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue))
        {
            return decimalValue;
        }

        return 0;
    }

    private bool IsNumeric(string strNumber)
    {
        decimal decimalValue = 0;
        bool isNumber = decimal.TryParse(
            strNumber,
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo,
            out decimalValue
        );
        return isNumber;
    }
}