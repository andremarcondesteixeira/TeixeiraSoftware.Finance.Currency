namespace TeixeiraSoftware.Finance
{
    public partial class Currency : ICurrency
    {
        /// <summary>Compares the equality of two currencies.</summary>
        /// <remarks>
        ///     The instances of <see cref="Currency" /> class are compared through their
        ///     whole set of properties.
        /// </remarks>
        /// <param name="currency">An instance of <see cref="Currency" /></param>
        public override bool Equals(object currency)
        {
            return AreEquivalent(this, (ICurrency)currency);
        }

        /// <summary>Compares the equality of two currencies.</summary>
        /// <remarks>
        ///     The instances of <see cref="ICurrency" /> class are compared through their
        ///     whole set of properties.
        /// </remarks>
        /// <param name="currency">An instance of <see cref="ICurrency" /></param>
        public override bool Equals(ICurrency currency)
        {
            return AreEquivalent(this, currency);
        }

        /// <remarks>The hash code is taken from the base class Object.</remarks>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
