using Fibonacci.Service.Interface;

namespace Fibonacci.Service
{
    public class CalculateService : ICalculateService
    {
        public long CalculateFibonacci(int number)
        {
            if (number <= 0)
            {
                return 0;
            }

            if (number == 1 || number == 2)
            {
                return 1;
            }

            long a = 1;
            long b = 1;
            long result = 0;

            for (int i = 3; i <= number; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }
    }
}
