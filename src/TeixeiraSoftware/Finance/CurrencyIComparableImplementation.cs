﻿using System;

namespace TeixeiraSoftware.Finance
{
    public partial class Currency : ICurrency
    {
        /// <summary>
        /// Compares two currencies for sorting purposes
        /// </summary>
        /// <param name="other"></param>
        /// <returns>
        ///     -1 if this current currency comes before the other currency.
        ///     0 if this current currency is equal to the other currency.
        ///     1 if this current currency comes after the other currency.
        /// </returns>
        public override int CompareTo(object other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Compares two currencies for sorting purposes
        /// </summary>
        /// <param name="other"></param>
        /// <returns>
        ///     -1 if this current currency comes before the other currency.
        ///     0 if this current currency is equal to the other currency.
        ///     1 if this current currency comes after the other currency.
        /// </returns>
        public override int CompareTo(ICurrency other)
        {
            throw new NotImplementedException();
        }
    }
}