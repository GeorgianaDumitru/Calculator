using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumberic(string argTextInput)
        {
            double convertedNum;
            if (!double.TryParse(argTextInput, out convertedNum)) throw new ArgumentException("Expected a numeric value.");
            return convertedNum;
        }
    }
}
