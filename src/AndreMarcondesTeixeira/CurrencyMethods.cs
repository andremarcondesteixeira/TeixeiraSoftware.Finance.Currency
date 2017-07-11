using System;
using System.Linq;

namespace AndreMarcondesTeixeira
{
    public partial struct Currency : IEquatable<Currency>
    {
        /// <summary>Gets a currency by its letter code.</summary>
        /// <param name="letterCode">The letter code of the desired currency.</param>
        /// <exception cref="System.ArgumentException">
        ///     Thrown when no currency is found with the specified letter code.
        /// </exception>
        public static Currency GetByLetterCode(string letterCode)
        {
            var filteredCurrencies = Currency.referenceCurrencies.Where(currency => currency.LetterCode == letterCode);

            if (filteredCurrencies.Count() > 0)
            {
                return filteredCurrencies.First();
            }

            throw new ArgumentException($"There is no registered currency with the letter code {letterCode}.");
        }

        /// <summary>Gets a currency by its numeric code.</summary>
        /// <param name="numericCode">The numeric code of the desired currency.</param>
        /// <exception cref="System.ArgumentException">
        ///     Thrown when no currency is found with the specified numeric code.
        /// </exception>
        public static Currency GetByNumericCode(string numericCode)
        {
            var filteredCurrencies = Currency.referenceCurrencies.Where(currency => currency.NumericCode == numericCode);

            if (filteredCurrencies.Count() > 0)
            {
                return filteredCurrencies.First();
            }

            throw new ArgumentException($"There is no registered currency with the numeric code {numericCode}.");
        }
    }
}