using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreMarcondesTeixeira
{
    public partial struct Currency : IEquatable<Currency>
    {
        private static IList<Currency> referenceCurrencies = new List<Currency>
        {
            Currency.AED,
            Currency.AFN,
            Currency.ALL,
            Currency.AMD,
            Currency.ANG,
            Currency.AOA,
            Currency.ARS,
            Currency.AUD,
            Currency.AWG,
            Currency.AZN,
            Currency.BAM,
            Currency.BBD,
            Currency.BDT,
            Currency.BGN,
            Currency.BHD,
            Currency.BIF,
            Currency.BMD,
            Currency.BND,
            Currency.BOB,
            Currency.BOV,
            Currency.BRL,
            Currency.BSD,
            Currency.BTN,
            Currency.BWP,
            Currency.BYN,
            Currency.BZD,
            Currency.CAD,
            Currency.CDF,
            Currency.CHE,
            Currency.CHF,
            Currency.CHW,
            Currency.CLF,
            Currency.CLP,
            Currency.CNY,
            Currency.COP,
            Currency.COU,
            Currency.CRC,
            Currency.CUC,
            Currency.CUP,
            Currency.CVE,
            Currency.CZK,
            Currency.DJF,
            Currency.DKK,
            Currency.DOP,
            Currency.DZD,
            Currency.EGP,
            Currency.ERN,
            Currency.ETB,
            Currency.EUR,
            Currency.FJD,
            Currency.FKP,
            Currency.GBP,
            Currency.GEL,
            Currency.GHS,
            Currency.GIP,
            Currency.GMD,
            Currency.GNF,
            Currency.GTQ,
            Currency.GYD,
            Currency.HKD,
            Currency.HNL,
            Currency.HRK,
            Currency.HTG,
            Currency.HUF,
            Currency.IDR,
            Currency.ILS,
            Currency.INR,
            Currency.IQD,
            Currency.IRR,
            Currency.ISK,
            Currency.JMD,
            Currency.JOD,
            Currency.JPY,
            Currency.KES,
            Currency.KGS,
            Currency.KHR,
            Currency.KMF,
            Currency.KPW,
            Currency.KRW,
            Currency.KWD,
            Currency.KYD,
            Currency.KZT,
            Currency.LAK,
            Currency.LBP,
            Currency.LKR,
            Currency.LRD,
            Currency.LSL,
            Currency.LYD,
            Currency.MAD,
            Currency.MDL,
            Currency.MGA,
            Currency.MKD,
            Currency.MMK,
            Currency.MNT,
            Currency.MOP,
            Currency.MRO,
            Currency.MUR,
            Currency.MVR,
            Currency.MWK,
            Currency.MXN,
            Currency.MXV,
            Currency.MYR,
            Currency.MZN,
            Currency.NAD,
            Currency.NGN,
            Currency.NIO,
            Currency.NOK,
            Currency.NPR,
            Currency.NZD,
            Currency.OMR,
            Currency.PAB,
            Currency.PEN,
            Currency.PGK,
            Currency.PHP,
            Currency.PKR,
            Currency.PLN,
            Currency.PYG,
            Currency.QAR,
            Currency.RON,
            Currency.RSD,
            Currency.RUB,
            Currency.RWF,
            Currency.SAR,
            Currency.SBD,
            Currency.SCR,
            Currency.SDG,
            Currency.SEK,
            Currency.SGD,
            Currency.SHP,
            Currency.SLL,
            Currency.SOS,
            Currency.SRD,
            Currency.SSP,
            Currency.STD,
            Currency.SVC,
            Currency.SYP,
            Currency.SZL,
            Currency.THB,
            Currency.TJS,
            Currency.TMT,
            Currency.TND,
            Currency.TOP,
            Currency.TRY,
            Currency.TTD,
            Currency.TWD,
            Currency.TZS,
            Currency.UAH,
            Currency.UGX,
            Currency.USD,
            Currency.USN,
            Currency.UYI,
            Currency.UYU,
            Currency.UZS,
            Currency.VEF,
            Currency.VND,
            Currency.VUV,
            Currency.WST,
            Currency.XAF,
            Currency.XAG,
            Currency.XAU,
            Currency.XBA,
            Currency.XBB,
            Currency.XBC,
            Currency.XBD,
            Currency.XCD,
            Currency.XDR,
            Currency.XOF,
            Currency.XPD,
            Currency.XPF,
            Currency.XPT,
            Currency.XSU,
            Currency.XTS,
            Currency.XUA,
            Currency.XXX,
            Currency.YER,
            Currency.ZAR,
            Currency.ZMW,
            Currency.ZWL
        };

        /// <summary>Gets a currency by its letter code.</summary>
        /// <param name="letterCode">The letter code of the desired currency.</param>
        /// <exception cref="System.ArgumentException">
        ///     Thrown when no currency is found with the specified letter code.
        /// </exception>
        public static Currency GetByLetterCode(string letterCode)
        {
            var filteredCurrencies = Currency.referenceCurrencies.Where(currency => currency.Code == letterCode);

            if (filteredCurrencies.Count() > 0)
            {
                return filteredCurrencies.First();
            }

            throw new ArgumentException($"There is no registered currency with the letter code {letterCode}.");
        }

        /// <summary>Gets a currency by its numeric code.</summary>
        /// <param name="numericCode">The numeric code of the desired currency.</param>
        /// <exception cref="System.ArgumentException">
        ///     Thrown when no currency is found with the specified numeric code.
        /// </exception>
        public static Currency GetByNumericCode(string numericCode)
        {
            var filteredCurrencies = Currency.referenceCurrencies.Where(currency => currency.Number == numericCode);

            if (filteredCurrencies.Count() > 0)
            {
                return filteredCurrencies.First();
            }

            throw new ArgumentException($"There is no registered currency with the numeric code {numericCode}.");
        }

        /// <summary>
        ///     Register a currency so it can be found with the methods <see cref="GetByLetterCode(System.String)" />
        ///     and <see cref="GetByNumericCode(System.String)" />
        /// </summary>
        /// <remarks>
        ///     The factory properties such as <see cref="Currency.XXX" /> will not be available for currencies
        ///     registered through this method.
        /// </remarks>
        /// <param name="currency">An instance of <see cref="Currency" />.</param>
        /// <exception cref="System.ArgumentException">
        ///     Thrown when a currency is already registered with the same set of properties.
        /// </exception>
        public static void RegisterCurrency(Currency currency)
        {
            throw new NotImplementedException();
        }
    }
}