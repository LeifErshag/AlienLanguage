using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlienLanguage
{
    public class Data
    {
        public int LenghtOfWords { get; set; }
        public int SizeOfDictionary { get; set; }
        public int NumberOfTestCases { get; set; }
        public List<TokenString> Dictionary { get; set; } = new List<TokenString>();
        public List<TokenString> TestCases { get; set; } = new List<TokenString>();

        public void ReadInput(string input)
        {
            StringReader reader = new StringReader(input);
            string[] metadata = reader.ReadLine().Split(" ");
            LenghtOfWords = int.Parse(metadata[0]);
            SizeOfDictionary = int.Parse(metadata[1]);
            NumberOfTestCases = int.Parse(metadata[2]);
            for (int i = 0; i < SizeOfDictionary; i++)
            {
                Dictionary.Add(new TokenString(reader.ReadLine()));
            }
            for (int i = 0; i < NumberOfTestCases; i++)
            {
                TestCases.Add(new TokenString(reader.ReadLine()));
            }
        }
    }
}
