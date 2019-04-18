using System;

namespace TeixeiraSoftware.Finance
{
    public partial struct Currency : ICurrency, IComparable, IComparable<ICurrency>
    {
        /// <summary>Compares two currencies for sorting purposes</summary>
        /// <param name="other">An object to compare against</param>
        /// <returns>
        ///     -1 if this current currency comes before the other currency.
        ///     0 if this current currency is equal to the other currency.
        ///     1 if this current currency comes after the other currency.
        /// </returns>
        public int CompareTo(object other)
        {
            if (other is ICurrency) {
                return this.Symbol.CompareTo(((ICurrency) other).Symbol);
            }

            throw new ArgumentException(
                $"{other.ToString()} is not an instance of TeixeiraSoftware.Finance.ICurrency"
            );
        }

        /// <summary>Compares two currencies for sorting purposes</summary>
        /// <param name="other">An <see cref="ICurrency"/> instance</param>
        /// <returns>
        ///     -1 if this current currency comes before the other currency.
        ///     0 if this current currency is equal to the other currency.
        ///     1 if this current currency comes after the other currency.
        /// </returns>
        public int CompareTo(ICurrency other)
        {
            return this.Symbol.CompareTo(other.Symbol);
        }
    }
}