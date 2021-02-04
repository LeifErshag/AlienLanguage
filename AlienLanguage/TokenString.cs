using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlienLanguage
{
    public class TokenString : IEnumerable<Token>
    {
        readonly List<Token> theString = new List<Token>();

        public IEnumerator<Token> GetEnumerator()
        {
            return theString.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return theString.GetEnumerator();
        }

        public bool Matches(TokenString word)
        {
            return theString.SequenceEqual(word, new TokenComparer());
        }

        public TokenString(string v)
        {
            var rawTestCase = v.ToCharArray();
            for (int i = 0; i<v.Length; i++)
            {
                char ch = rawTestCase[i];
                if (ch == '(')
                {
                    ch = rawTestCase[++i];
                    List<char> token = new List<char>();
                    while (ch != ')')
                    {
                        token.Add(ch);
                        ch = rawTestCase[++i];
                    }
                    theString.Add(new Token(token));
                    continue;
                }

                theString.Add(new Token(ch));
            }
        }


    }
}
