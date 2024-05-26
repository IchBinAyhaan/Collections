

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> intCalculator = new Calculator<int>();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an operation:");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    continue;
                }

                if (choice == 5)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                Console.WriteLine("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result;
                switch (choice)
                {
                    case 1:
                        result = intCalculator.Add(num1, num2);
                        break;
                    case 2:
                        result = intCalculator.Subtract(num1, num2);
                        break;
                    case 3:
                        result = intCalculator.Multiply(num1, num2);
                        break;
                    case 4:
                        try
                        {
                            result = intCalculator.Divide(num1, num2);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                Console.WriteLine("Result: " + result);
            }
        }
    }
}
