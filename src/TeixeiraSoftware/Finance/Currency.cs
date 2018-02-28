using System;

namespace TeixeiraSoftware.Finance
{
    /// <summary>
    ///     The <see cref="Currency" /> class follows the ISO 4217:2015 specification,
    ///     providing an easy way to represent ISO currencies.
    /// </summary>
    /// <remarks>
    ///     All currencies are represented, except for "ANTARCTICA", "PALESTINE, STATE OF"
    ///     and "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", because ISO describes those
    ///     currencies as "no universal currency", and gives them no identification codes.
    ///     <para>
    ///         For more information:
    ///         <see href="https://www.currency-iso.org/en/home.html">
    ///             https://www.currency-iso.org/en/home.html
    ///         </see> and
    ///         <see href="https://www.iso.org/standard/64758.html">
    ///             https://www.iso.org/standard/64758.html
    ///         </see>
    ///     </para>
    /// </remarks>
    public partial struct Currency : ICurrency
    {
        /// <summary>
        /// The alphabetic ISO code of the currency.
        /// This property is always the same as <see cref="AlphabeticCode"/>
        /// </summary>
        public string Symbol { get; }

        /// <summary>
        /// The name of the currency
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The alphabetic ISO code of the currency.
        /// This property is always the same as <see cref="Symbol"/>
        /// </summary>
        public string AlphabeticCode {
            get {
                return Symbol;
            }
        }

        /// <summary>
        /// The ISO numeric code of the currency
        /// </summary>
        public string NumericCode { get; }

        /// <summary>
        /// The minor units of the currency
        /// </summary>
        public byte MinorUnits { get; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        /// <remarks>
        ///     Instead of using the constructor, consider using the static, lazy loaded
        ///     properties of the <see cref="Currency" /> class.
        /// </remarks>
        /// <example>
        ///     This sample shows you how to get an instance of a currency, where "XXX" is
        ///     the 3 letters ISO code of the currency, and "999" is the 3 digits numeric
        ///     ISO code of the currency:
        ///     <code>
        ///         var currency = Currency.XXX;
        ///         var currency = Currency.GetByLetterCode("XXX");
        ///         var currency = Currency.GetByNumericCode("999");
        ///     </code>
        /// </example>
        /// <param name="alphabeticCode">The 3 letters ISO code of the Currency.</param>
        /// <param name="numericCode">The 3 digits numeric ISO code of the Currency.</param>
        /// <param name="minorUnits">The ISO minor units of the Currency.</param>
        /// <param name="name">The ISO name of the Currency.</param>
        public Currency(
            string alphabeticCode,
            string numericCode,
            byte minorUnits,
            string name
        )
        {
            Symbol = alphabeticCode;
            NumericCode = numericCode;
            MinorUnits = minorUnits;
            Name = name;
        }
    }
}