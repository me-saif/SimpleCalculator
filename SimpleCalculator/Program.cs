using System;

namespace SimpleCalculator
{
    class Program
    {
         static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.Write("Please Enter First Number: ");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Please Enter First Number: ");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Please Enter Operation: ");
                Console.WriteLine("Follow the prefix for operation: (+) or (add), (-) or (subtract), (*) or (multiply) and (/) or (divide) ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                //In real world we would want to log this message.
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
