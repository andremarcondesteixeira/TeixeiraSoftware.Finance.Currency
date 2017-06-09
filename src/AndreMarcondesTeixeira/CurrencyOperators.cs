using System;

namespace AndreMarcondesTeixeira
{
    public partial class Currency
    {
        public static bool operator == (Currency a, Currency b)
        {
            return AreEquivalent(a, b);
        }

        public static bool operator != (Currency a, Currency b)
        {
            return !AreEquivalent(a, b);
        }

        public override bool Equals(object obj)
        {
            return AreEquivalent(this, obj as Currency);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private static bool AreEquivalent(Currency a, Currency b)
        {
            if (Object.ReferenceEquals(a, null) || Object.ReferenceEquals(b, null))
            {
                throw new ArgumentException("Currency must not be null");
            }

            return a.Number == b.Number;
        }
    }
}