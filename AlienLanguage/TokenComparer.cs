using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AlienLanguage
{
    internal class TokenComparer : IEqualityComparer<Token>
    {
        public bool Equals([AllowNull] Token x, [AllowNull] Token y)
        {
            if (x.Pattern.Equals(y.Pattern))
                return true;
            return (x.Pattern.Contains(y.Pattern));
        }

        public int GetHashCode([DisallowNull] Token obj)
        {
            return obj.Pattern.GetHashCode();
        }
    }
}