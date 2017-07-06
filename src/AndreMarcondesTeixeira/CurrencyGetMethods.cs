using System;
using System.Collections.Generic;

namespace AndreMarcondesTeixeira
{
    public partial struct Currency : IEquatable<Currency>
    {
        private static readonly IList<Currency> referenceCurrencies = new List<Currency>
        {
            Currency.AED,
            Currency.AFN,
            Currency.ALL,
            Currency.AMD
        };

        public static object GetByLetterCode(string v)
        {
            throw new NotImplementedException();
        }

        public static object GetByNumericCode(string v)
        {
            throw new NotImplementedException();
        }
    }
}