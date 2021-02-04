using AlienLanguage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlienLanguageTest
{
    class CompareTokenStringTests
    {
        [Test]
        public void CompareIdenticalOneLetterStrings()
        {
            TokenString testCase = new TokenString("a");
            TokenString word = new TokenString("a");
            Assert.IsTrue(testCase.Matches(word));
        }

        [Test]
        public void TwoLetterTokensMatchWordTokenIfItContainsTheLetter()
        {
            TokenString testCase = new TokenString("(ab)");
            TokenString word = new TokenString("a");
            Assert.IsTrue(testCase.Matches(word));
        }

        [Test]
        public void TwoLetterTokensDoNotMatchIfWordTokenDontContainTheLetter()
        {
            TokenString testCase = new TokenString("(ab)");
            TokenString word = new TokenString("c");
            Assert.IsFalse(testCase.Matches(word));
        }

        [Test]
        public void TwoSetsOfTokensMatchIfBothMatch()
        {
            TokenString testCase = new TokenString("(ab)(cd)");
            TokenString word = new TokenString("bc");
            Assert.IsTrue(testCase.Matches(word));

        }

        [Test]
        public void TwoSetsOfTokensDontMatchIfNotBothMatch()
        {
            TokenString testCase = new TokenString("(ab)(cd)");
            TokenString word = new TokenString("bb");
            Assert.IsFalse(testCase.Matches(word));

        }
    }
}
