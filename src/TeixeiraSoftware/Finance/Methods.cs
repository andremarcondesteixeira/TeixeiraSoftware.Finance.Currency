using System;
using System.Linq;

namespace TeixeiraSoftware.Finance
{
    public partial struct Currency : ICurrency
    {
        /// <summary>Gets a currency by its alphabetic code.</summary>
        /// <param name="alphabeticCode">The letter code of the desired currency.</param>
        /// <exception cref="ArgumentException">
        ///     Thrown when no currency is found with the specified letter code.
        /// </exception>
        public static ICurrency ByAlphabeticCode(string alphabeticCode)
        {
            var filteredCurrencies = AllCurrencies.Where(currency => currency.Symbol == alphabeticCode);

            if (filteredCurrencies.Count() > 0)
            {
                var currency = filteredCurrencies.First();

                return new Currency(currency.AlphabeticCode, currency.NumericCode, currency.MinorUnits, currency.Name);
            }

            throw new ArgumentException($"There is no registered currency with the alphabetic code {alphabeticCode}.");
        }

        /// <summary>Gets a currency by its numeric code.</summary>
        /// <param name="numericCode">The numeric code of the desired currency.</param>
        /// <exception cref="ArgumentException">
        ///     Thrown when no currency is found with the specified numeric code.
        /// </exception>
        public static ICurrency ByNumericCode(string numericCode)
        {
            var filteredCurrencies = AllCurrencies.Where(currency => currency.NumericCode == numericCode);

            if (filteredCurrencies.Count() > 0)
            {
                var currency = filteredCurrencies.First();

                return new Currency(currency.AlphabeticCode, currency.NumericCode, currency.MinorUnits, currency.Name);
            }

            throw new ArgumentException($"There is no registered currency with the numeric code {numericCode}.");
        }

        /// <summary>
        /// Compares two ICurrency instances based on their whole set of properties
        /// </summary>
        /// <param name="left">An ICurrency instance</param>
        /// <param name="right">An ICurrency instance</param>
        /// <returns>True of false</returns>
        private static bool AreEquivalent(Currency left, Currency right)
        {
            return
                left.NumericCode == right.NumericCode
                && left.AlphabeticCode == right.AlphabeticCode
                && left.MinorUnits == right.MinorUnits
                && left.Name == right.Name;
        }
    }
}