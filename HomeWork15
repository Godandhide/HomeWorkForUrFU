using System;

namespace HomeWork15
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = CrearteArray(int.Parse(Console.ReadLine()));
            int N = arr.GetLength(0);
            for (int i = 1; i < N; i++)
                for (int j = 1; j < N; j++)
                    arr[i, j] = arr[i, j - 1] + arr[i - 1, j];

            Console.WriteLine(arr[N - 1, N - 1]);
            Console.ReadKey();
        }
        private static int[,] CrearteArray(int n)
        {
            var array = new int[n + 1, n + 1];
            for (var i = 0; i <= n; i++)
                for (var j = 1; j <= n; j++)
                {
                    array[0, i] = 1;
                    array[j, 0] = 1;
                }
            return array;
        }
    }
}
