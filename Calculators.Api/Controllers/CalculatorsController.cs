using Calculators.Features;
using Microsoft.AspNetCore.Mvc;


namespace Calculators.Api.Controllers
{
    public class CalculatorsController : Controller
    {
        private readonly ISimpleCalculator<decimal> _simpleCalculator;

        public CalculatorsController(ISimpleCalculator<decimal> simpleCalculator)
        {
            _simpleCalculator = simpleCalculator;
        }

        [HttpGet("Add")]
        public IActionResult Add([FromQuery] decimal a, [FromQuery] decimal b)
        {
            decimal result = _simpleCalculator.Add(a, b);
            return Ok(result);
        }

        [HttpGet("Subtract")]
        public IActionResult Subtract([FromQuery] decimal a, [FromQuery] decimal b)
        {
            decimal result = _simpleCalculator.Subtract(a, b);
            return Ok(result);
        }

        [HttpGet("Multiply")]
        public IActionResult Multiply([FromQuery] decimal a, [FromQuery] decimal b)
        {
            decimal result = _simpleCalculator.Multiply(a, b);
            return Ok(result);
        }

        [HttpGet("Divide")]
        public IActionResult Divide([FromQuery] decimal a, [FromQuery] decimal b)
        {
            try
            {
                decimal result = _simpleCalculator.Divide(a, b);
                return Ok(result);
            }
            catch (DivideByZeroException)
            {
                return BadRequest("Cannot divide by zero");
            }
        }
    }
}