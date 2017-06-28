using System;

namespace AndreMarcondesTeixeira
{
    public partial class Currency
    {
        public string Code { get; }
        public byte MinorUnits { get; }
        public string Name { get; }
        public string Number { get; }

        /// <summary>
        /// Use the static, lazy loaded properties of
        /// the Currency class instead of the constructor
        /// </summary>
        /// <example>
        /// This sample shows you how to get an instance of a currency:
        /// <code>
        /// var currency = Currency.XXX;
        /// </code>
        /// </example>
        private Currency(string code, string number, byte minorUnits, string name)
        {
            this.Code = code;
            this.Number = number;
            this.MinorUnits = minorUnits;
            this.Name = name;
        }
    }
}