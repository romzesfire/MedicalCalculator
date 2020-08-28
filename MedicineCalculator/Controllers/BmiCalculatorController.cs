using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicineCalculator.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicineCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BmiCalculatorController : ControllerBase
    {
        private IBmiCalculator _calculator;
        public BmiCalculatorController(IBmiCalculator calculator)
        {
            _calculator = calculator;
        }
        [HttpGet("calculate-bmi")]
        public IActionResult CalculateBmi(string bodyHeightMeters, string bodyWeightKilogram)
        {
            if(!double.TryParse(bodyHeightMeters, out var heightOut) | !double.TryParse(bodyWeightKilogram, out var weightOut))            
                return BadRequest("Введены недопустимые данные!");

            var result = _calculator.Calculate(heightOut, weightOut);
            
            if(result.Value == -1)            
                return BadRequest("Введены недопустимые значения!");

            return Ok(result);
        }
    }
}