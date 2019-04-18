using System;
using System.Collections.Generic;

namespace TeixeiraSoftware.Finance
{
    public partial struct Currency : ICurrency, IComparable, IComparable<ICurrency>
    {
        /// <summary>Checks the equality between currencies</summary>
        /// <remarks>
        ///     The instances of <see cref="ICurrency"/> are compared
        ///     through the <see cref="Symbol"/> property
        /// </remarks>
        /// <param name="currency">An object to compare against</param>
        /// <returns>True if currencies are the same, false otherwise</returns>
        public override bool Equals(object currency)
        {
            if (currency is ICurrency)
            {
                return AreEquivalent(this, (ICurrency)currency);
            }

            throw new ArgumentException(
                $"{currency.ToString()} is not an instance of TeixeiraSoftware.Finance.ICurrency"
            );
        }

        /// <summary>Checks the equality between currencies</summary>
        /// <remarks>
        ///     The instances of <see cref="ICurrency"/> are compared
        ///     through the <see cref="Symbol"/> property
        /// </remarks>
        /// <param name="currency">An instance of <see cref="ICurrency"/></param>
        /// <returns>True if currencies are the same, false otherwise</returns>
        public bool Equals(ICurrency currency)
        {
            return AreEquivalent(this, currency);
        }

        /// <summary>Gets the hash code</summary>
        /// <returns>The Hash code</returns>
        public override int GetHashCode()
        {
            var hashCode = 2085709600;

            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Hash(Symbol);
            hashCode = hashCode * -1521134295 + Hash(Name);
            hashCode = hashCode * -1521134295 + Hash(AlphabeticCode);
            hashCode = hashCode * -1521134295 + Hash(NumericCode);
            hashCode = hashCode * -1521134295 + Hash(Sign);
            hashCode = hashCode * -1521134295 + MinorUnits.GetHashCode();

            return hashCode;
        }

        /// <summary>Gets the hash code of a string</summary>
        /// <returns>The Hash code of the string</returns>
        private int Hash(string x)
        {
            return EqualityComparer<string>.Default.GetHashCode(x);
        }
    }
}