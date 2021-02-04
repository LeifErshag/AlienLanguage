using AlienLanguage;
using NUnit.Framework;

namespace AlienLanguageTest
{
    public class ReadingInputTests
    {

        string knownData = @"3 5 4
abc
bca
dac
dbc
cba
(ab)(bc)(ca)
abc
(abc)(abc)(abc)
(zyx)bc
";

        Data sut;

        [SetUp]
        public void Setup()
        {
            sut = new Data();
            sut.ReadInput(knownData);
        }

        [Test]
        public void ReadLengthOfWordsFromInput()
        {
            Assert.AreEqual(3, sut.LenghtOfWords);
        }

        [Test]
        public void ReadSizeOfDictionary()
        {
            Assert.AreEqual(5, sut.SizeOfDictionary);
        }

        [Test]
        public void ReadNumberOfTestCases()
        {
            Assert.AreEqual(4, sut.NumberOfTestCases);
        }

    }
}