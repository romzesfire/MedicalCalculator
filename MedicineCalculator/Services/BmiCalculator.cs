using MedicineCalculator.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineCalculator.Services
{
    public interface IBmiCalculator : ICalculator
    {
        public ICalculateResult Calculate(double bodyHeightMeters, double bodyWeightKilogram);
    }
    public class BmiCalculator : IBmiCalculator
    {
        public string CalculatorName { get; set; } = "Индекс массы тела";

        public BmiCalculator()
        {

        }
        public BmiCalculator(string calculatorName)
        {
            CalculatorName = calculatorName;
        }
        public ICalculateResult Calculate(double bodyHeightMeters, double bodyWeightKilogram)
        {
            if(bodyHeightMeters > 3 || bodyHeightMeters < 1 || bodyWeightKilogram < 20 || bodyWeightKilogram > 400)
            {
                return new CalculationResult(CalculatorName, -1, "kg/m2");
            }
            var result = bodyWeightKilogram / (bodyHeightMeters * bodyHeightMeters);
            return new CalculationResult(CalculatorName, result, "kg/m2");
        }
    }
}
