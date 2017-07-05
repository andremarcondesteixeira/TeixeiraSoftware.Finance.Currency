using System;

namespace AndreMarcondesTeixeira
{
    public partial struct Currency
    {
        /// <summary>
        /// The instances of <see cref="Currency" /> class are compared through their
        /// whole set of properties.
        /// </summary>
        public static bool operator == (Currency a, Currency b)
        {
            return AreEquivalent(a, b);
        }

        /// <summary>
        /// The instances of <see cref="Currency" /> class are compared through their
        /// whole set of properties.
        /// </summary>
        public static bool operator != (Currency a, Currency b)
        {
            return !AreEquivalent(a, b);
        }

        /// <summary>
        /// The instances of <see cref="Currency" /> class are compared through their
        /// whole set of properties.
        /// </summary>
        public override bool Equals(object obj)
        {
            return AreEquivalent(this, (Currency) obj);
        }

        /// <summary>
        /// The hash code is taken from the base class Object.
        /// </summary>
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

            return
                a.Number == b.Number
                && a.Code == b.Code
                && a.MinorUnits == b.MinorUnits
                && a.Name == b.Name;
        }
    }
}