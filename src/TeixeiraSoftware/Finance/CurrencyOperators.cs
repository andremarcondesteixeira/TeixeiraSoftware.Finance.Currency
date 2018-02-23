using System;

namespace TeixeiraSoftware.Finance
{
    public partial class Currency : ICurrency
    {
        /// <summary>Compares the equality of two currencies.</summary>
        /// <remarks>
        ///     The instances of <see cref="Currency" /> class are compared through their
        ///     whole set of properties.
        /// </remarks>
        public static bool operator == (Currency a, Currency b)
        {
            return AreEquivalent(a, b);
        }

        /// <summary>Compares the inequality of two currencies.</summary>
        /// <remarks>
        ///     The instances of <see cref="Currency" /> class are compared through their
        ///     whole set of properties.
        /// </remarks>
        public static bool operator != (Currency a, Currency b)
        {
            return !AreEquivalent(a, b);
        }
    }
}