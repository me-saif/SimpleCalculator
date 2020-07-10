using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextinput) {
            double convertedNumber;
            if (!double.TryParse(argTextinput, out convertedNumber)) throw new ArgumentException("Expected a numeric value");
                return convertedNumber;
        }
    }
}