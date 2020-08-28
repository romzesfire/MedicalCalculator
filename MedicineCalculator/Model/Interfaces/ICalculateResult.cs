using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineCalculator.Model.Interfaces
{
    public interface ICalculateResult
    {
        public string CalculatorName { get; }
        public double Value { get; }
        public string Unit { get; }
    }
}
