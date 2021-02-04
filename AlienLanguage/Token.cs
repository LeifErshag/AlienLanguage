using System;
using System.Collections.Generic;
using System.Text;

namespace AlienLanguage
{
    public class Token
    {
        
        public Token(char ch)
        {
            this.Pattern = new string(ch, 1);
        }

        public Token(List<char> token)
        {
            Pattern = new string(token.ToArray());
        }

        public string Pattern { get; set; }
    }
}
