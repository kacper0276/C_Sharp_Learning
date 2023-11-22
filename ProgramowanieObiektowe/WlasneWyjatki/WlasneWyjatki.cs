namespace ProgramowanieObiektowe.WlasneWyjatki
{
    public class WlasneWyjatki
    {
        public WlasneWyjatki()
        {
            Console.WriteLine("Hello in Program!");
            Console.WriteLine("You can divide two numbers");
            Console.WriteLine("Input first");
            var firstInputValue = Console.ReadLine();
            var isParsed = double.TryParse(firstInputValue, out var firstValue);
            if (isParsed is false)
            {
                Console.WriteLine("Given invalid firstNumber");
                return;
            }

            Console.WriteLine("Input second");
            var secondInputValue = Console.ReadLine();
            isParsed = double.TryParse(secondInputValue, out var secondValue);
            if (isParsed is false)
            {
                Console.WriteLine("Given invalid secondNumber");
                return;
            }

            try
            {
                if (secondValue == 0)
                {
                    throw new CustomException("Cannot divide by 0");
                }

                var result = firstValue / secondValue;
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
