using System;
using System.IO;
using System.Linq;

namespace AlienLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            var indata = File.ReadAllText("språk+från+rymden.txt");
            Data data = new Data();
            data.ReadInput(indata);
            for (var i=0; i< data.NumberOfTestCases; i++)
            {
                var testCase = data.TestCases[i];
                int matches = data.Dictionary.Count(word => testCase.Matches(word));
                Console.WriteLine($"Case #{i + 1}: {matches}");
            }
        }
    }
}
