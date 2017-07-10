using System;

namespace AndreMarcondesTeixeira
{
    /// <summary>
    ///     The <see cref="Currency" /> class follows ISO 4217:2015, providing an easy way
    ///     to represent ISO currencies.
    /// </summary>
    /// <remarks>
    ///     All currencies are represented, except for "ANTARCTICA", "PALESTINE, STATE OF"
    ///     and "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", because ISO describes those
    ///     as "no universal currency", and gives them no letter codes.
    ///     <para>
    ///         This class does not provide the list of countries that use each currency.
    ///     </para>
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
    public partial struct Currency : IEquatable<Currency>
    {
        /// <summary>The 3 letters ISO code of the currency</summary>
        public string LetterCode { get; }

        /// <summary>The ISO minor units of the currency</summary>
        public byte MinorUnits { get; }

        /// <summary>The ISO name of the currency</summary>
        public string Name { get; }

        /// <summary>The numeric ISO code of the currency</summary>
        public string NumericCode { get; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        /// <remarks>
        ///     Instead of using the constructor, consider using the static, lazy loaded
        ///     properties of the <see cref="Currency" /> class instead.
        ///     <para>
        ///         For a list of the available currencies, use IntelliSense, or:
        ///         <see href="https://www.currency-iso.org/en/home.html">
        ///             https://www.currency-iso.org/en/home.html
        ///         </see>
        ///     </para>
        /// </remarks>
        /// <example>
        ///     This sample shows you how to get an instance of a currency, where "XXX" is
        ///     the 3 letters ISO code of the currency:
        ///     <code>
        ///         var currency = Currency.XXX;
        ///         var customCurrency = new Currency("ZZZ", "999", 0, "Custom Currency");
        ///     </code>
        /// </example>
        /// <param name="letterCode">The 3 letters ISO code of the Currency.</param>
        /// <param name="numericCode">The numeric ISO code of the Currency.</param>
        /// <param name="minorUnits">The ISO minor units of the Currency.</param>
        /// <param name="name">The ISO name of the Currency.</param>
        public Currency(string letterCode, string numericCode, byte minorUnits, string name)
        {
            this.LetterCode = letterCode;
            this.NumericCode = numericCode;
            this.MinorUnits = minorUnits;
            this.Name = name;
        }
    }
}