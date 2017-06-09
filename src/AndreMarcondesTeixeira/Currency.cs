using System;

namespace AndreMarcondesTeixeira
{
    public partial class Currency
    {
        public string Code { get; }
        public byte MinorUnits { get; }
        public string Name { get; }
        public string Number { get; }

        public Currency(string code, string number, byte minorUnits, string name)
        {
            this.Code = code;
            this.Number = number;
            this.MinorUnits = minorUnits;
            this.Name = name;
        }
    }
}