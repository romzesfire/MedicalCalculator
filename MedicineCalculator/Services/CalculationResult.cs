using MedicineCalculator.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineCalculator.Services
{
    public class CalculationResult : ICalculateResult
    {
        public string CalculatorName { get; }
        public double Value { get; }
        public string Unit { get; }
        public CalculationResult(string calculatorName, double result, string unit)
        {
            CalculatorName = calculatorName;
            Value = result;
            Unit = unit;
        }
    }
}
