using System;

namespace HomeWork37
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 1;
            for (int i = 11; i < 10000; i++)
            {
                if (IsFindNumer(i))
                {
                    sum += i;
                    count++;
                }
                if (count == 11)
                    break;
            }
            Console.ReadKey();
        }

        private static bool IsSimpleNumber(int number)
        {
            bool result = true;
            int newNumber = (int)Math.Sqrt(number);
            for(int i=2; i<= newNumber;i++)
                if(newNumber % i == 0)
                {
                    result = false;
                    break;
                }
            return result;
        }

        private static bool IsFindNumer(int number)
        {
            bool result = false;
            for(int i = 1; 1 < number; i *= 10)
            {
                number /= i;
                if (number <= i)
                    break;
                if (!IsSimpleNumber(number))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
