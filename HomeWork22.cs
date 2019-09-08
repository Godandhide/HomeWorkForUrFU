using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace HomeWork_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFromFile = File.ReadAllText(@"D:\ProjectForVisualStudia\HomeWork_22\HomeWork_22\p022_names.txt")
                                    .Replace('\"', ',')
                                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                                    .OrderBy(x => x)
                                    .ToList();
            Console.WriteLine(CountWeightAllName(textFromFile));
            Console.ReadKey();
        }

        public static long CountWeightAllName(List<string> names)
        {
            var alphabet = GetAlphbet();

            long countAllNames = 0;
            int countName = 0;
            for (int j = 0; j < names.Count(); j++)
            {
                foreach (var letter in names[j])
                {
                    countName += alphabet[letter];
                }
                countAllNames += countName * (j + 1);
                countName = 0;
            }
            return countAllNames;
        }

        public static Dictionary<char, int> GetAlphbet()
        {
            var alphbet = new Dictionary<char, int>();
            int i = 1;
            for (var c = 'A'; c <= 'Z'; ++c, i++)
            {
                alphbet.Add(c, i);
            }
            return alphbet;
        }
    }
}
