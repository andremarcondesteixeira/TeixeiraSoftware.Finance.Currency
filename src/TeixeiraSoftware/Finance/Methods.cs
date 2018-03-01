using System;
using System.Linq;

namespace TeixeiraSoftware.Finance
{
    public partial struct Currency : ICurrency, IComparable, IComparable<ICurrency>
    {
        /// <summary>Gets a currency by its ISO alphabetic code</summary>
        /// <param name="alphabeticCode">The ISO alphabetic code of the desired currency</param>
        /// <exception cref="ArgumentException">
        ///     Thrown when no currency is found with the specified ISO alphabetic code
        /// </exception>
        /// <returns>A <see cref="Currency"/> instance</returns>
        public static Currency ByAlphabeticCode(string alphabeticCode)
        {
            var filteredCurrencies = AllCurrencies.Where(
                currency => currency.Symbol == alphabeticCode
            );

            if (filteredCurrencies.Count() > 0)
            {
                var currency = filteredCurrencies.First();

                return new Currency(
                    currency.AlphabeticCode,
                    currency.NumericCode,
                    currency.MinorUnits,
                    currency.Name
                );
            }

            throw new ArgumentException(
                $"There is no registered currency with the alphabetic code {alphabeticCode}"
            );
        }

        /// <summary>Gets a currency by its ISO numeric code</summary>
        /// <param name="numericCode">The ISO numeric code of the desired currency</param>
        /// <exception cref="ArgumentException">
        ///     Thrown when no currency is found with the specified ISO numeric code
        /// </exception>
        /// <returns>A <see cref="Currency"/> instance</returns>
        public static Currency ByNumericCode(string numericCode)
        {
            var filteredCurrencies = AllCurrencies.Where(
                currency => currency.NumericCode == numericCode
            );

            if (filteredCurrencies.Count() > 0)
            {
                var currency = filteredCurrencies.First();

                return new Currency(
                    currency.AlphabeticCode,
                    currency.NumericCode,
                    currency.MinorUnits,
                    currency.Name
                );
            }

            throw new ArgumentException(
                $"There is no registered currency with the numeric code {numericCode}"
            );
        }

        /// <summary>Compares two <see cref="ICurrency"/> instances</summary>
        /// <param name="left">An <see cref="ICurrency"/> instance</param>
        /// <param name="right">An <see cref="ICurrency"/> instance</param>
        /// <returns>True of false</returns>
        private static bool AreEquivalent(ICurrency left, ICurrency right)
        {
            return left.Symbol == right.Symbol;
        }
    }
}