using AlienLanguage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlienLanguageTest
{
    class TokenizerTests
    {
        [Test]
        public void TreatLetterAsToken()
        {
            var sut = new TokenString("a");
            Assert.AreEqual("a", sut.First().Pattern);
        }

        [Test]
        public void TreatConsecutiveLettersAsTokens()
        {
            var sut = new TokenString("ab");
            Assert.AreEqual("b", sut.Last().Pattern);
        }

        [Test]
        public void TreatParentasisAsOneToken()
        {
            var sut = new TokenString("(ab)");
            Assert.AreEqual("ab", sut.First().Pattern);
        }

    }
}
