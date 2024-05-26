
namespace Calculator
{
    public class Calculator<T>
    {
        public T Add(T num1, T num2)
        {
            double result = num1 + num2;
            return result;
        }

        public T Subtract(T num1, T num2)
        {
            double result = num1 - num2;
            return result;
        }

        public T Multiply(T num1, T num2)
        {
            double result = num1 * num2;
            return result;
        }

        public T Divide(T num1, T num2)
        {
            if (Convert.ToDouble(num2) == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            double result = num1 / num2;
            return result;
        }
    }
}