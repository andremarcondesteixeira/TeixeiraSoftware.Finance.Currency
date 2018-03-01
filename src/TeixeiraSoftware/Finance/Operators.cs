using System;
using System.Collections.Generic;

namespace TeixeiraSoftware.Finance
{
    public partial struct Currency : ICurrency, IComparable, IComparable<ICurrency>
    {
        /// <summary>Checks the equality between two currencies</summary>
        /// <remarks>
        ///     The instances of <see cref="Currency" /> are compared through
        ///     the <see cref="Symbol"/> property
        /// </remarks>
        public static bool operator == (Currency a, Currency b)
        {
            return AreEquivalent(a, b);
        }

        /// <summary>Checks the inequality between two currencies</summary>
        /// <remarks>
        ///     The instances of <see cref="Currency" /> are compared through
        ///     the <see cref="Symbol"/> property
        /// </remarks>
        public static bool operator != (Currency a, Currency b)
        {
            return !AreEquivalent(a, b);
        }
    }
}