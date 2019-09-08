using System;

namespace HomeWork37
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong sum = 0, count = 0,iterator=10;
            while (count < 11)
            {
                if (IsInterestingIterator(iterator))
                {
                    count++;
                    sum += iterator;
                    Console.WriteLine(sum);
                }
                iterator++;
                
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        private static bool IsInterestingIterator(ulong number)
        {
            var numberLenth = FindNumberLenth(number);
            if (!IsSimpleNumber(number)) return false;
            if (numberLenth <= 1) return false;
            ulong test1 = number, test2 = number;
            for (ulong i = numberLenth - 1; i > 0; i--)
                if (!IsSimpleNumber(test2 = test2 % (ulong)(Math.Pow(10, i))))
            return false;
            for (ulong i = 1; i < numberLenth; i++)
                if (!IsSimpleNumber(test1 /= 10))
                    return false;
            return true;
        }

        private static ulong FindNumberLenth(ulong number)
        {
            ulong i;
            for (i = 1; (number /= 10) == 0; ++i) ;
            return i;
        }

        private static bool IsSimpleNumber(ulong number)
        {
            ulong newNumber = (ulong)Math.Sqrt(number);
            for (ulong i = 2; i <= newNumber; i++)
                if (newNumber % i == 0)
                    return false;
            return true; ;
        }
    }
}
