using System;

namespace AndreMarcondesTeixeira
{
    public partial class Currency
    {
        public string ISOCode { get; }
        public string ISONumber { get; }
        public byte DefaultDecimalPlaces { get; }
        public string Name { get; }
        public string Country { get; }

        public Currency(string ISOCode, string ISONumber, byte defaultDecimalPlaces, string name)
        {
            this.ISOCode = ISOCode;
            this.ISONumber = ISONumber;
            this.DefaultDecimalPlaces = defaultDecimalPlaces;
            this.Name = name;
        }

        public static Money ConvertTo(Currency currency, Money money, decimal conversionFactor)
        {
            return new Money(money.Amount * conversionFactor, currency);
        }
    }
}