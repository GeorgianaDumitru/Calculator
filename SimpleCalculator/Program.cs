namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNum = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                double secondNum = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNum, secondNum);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }

        }


    }
}