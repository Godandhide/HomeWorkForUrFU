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
            var stream = File.Open(@"D:\ProjectForVisualStudia\HomeWork_22\HomeWork_22\p022_names.txt", FileMode.OpenOrCreate);
            var arrayStream = new byte[stream.Length];
            stream.Read(arrayStream, 0, arrayStream.Length);
            var textFromFile = Encoding.Default.GetString(arrayStream)
                                    .Replace('\"', ' ')
                                    .Split(',')
                                    .OrderBy(x => x);
            Console.WriteLine(CountWeightAllName(textFromFile.ToList()));
            Console.ReadKey();

        }

        public static long CountWeightAllName(List<string> names)
        {
            var alphabet = GetAlphbet();

            long countAllNames = 0;
            for(int j = 0; j < names.Count; j++)
            {
                long count = 0;
                for(int i =0; i< names[j].Length;i++)
                {
                    count += alphabet.Where(x => x.Key == names[j][i])
                                     .FirstOrDefault()
                                     .Value;
                }
                countAllNames += count * (j + 1);
            }
            return countAllNames;
        }

        public static Dictionary<char,int> GetAlphbet()
        {
            var alphbet = new Dictionary<char, int>();
            int i = 0;
            for(var c = 'A'; c <= 'Z'; ++c, i++)
            {
                alphbet.Add(c, i);
            }
            return alphbet;
        }
    }
}
