using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xunit;

namespace TeixeiraSoftware.Finance
{
    public class CurrencyTest
    {
        [Fact]
        public void All_Factory_Methods_Return_New_Currency_Instances()
        {
            Assert.False(ReferenceEquals(Currency.XXX, Currency.XXX));
            Assert.False(ReferenceEquals(Currency.ByAlphabeticCode("XXX"), Currency.ByAlphabeticCode("XXX")));
            Assert.False(ReferenceEquals(Currency.ByNumericCode("999"), Currency.ByNumericCode("999")));
        }

        [Fact]
        public void Currency_Instances_Can_Be_Created_By_Three_Ways()
        {
            Assert.IsType<Currency>(Currency.XXX);
            Assert.IsType<Currency>(Currency.ByAlphabeticCode("XXX"));
            Assert.IsType<Currency>(Currency.ByNumericCode("999"));
        }

        [Fact]
        public void Currency_Getter_Methods_Throw_Exception_For_Nonexistent_Currencies()
        {
            Assert.Throws<ArgumentException>(() => Currency.ByAlphabeticCode("Nonexistent"));
            Assert.Throws<ArgumentException>(() => Currency.ByNumericCode("Nonexistent"));
        }

        [Fact]
        public void Currency_Instances_Are_Compared_Through_The_Symbol()
        {
            var xxx = new Currency("XXX", "999", 0, "The codes assigned for transactions where no currency is involved");

            Assert.Equal(xxx, Currency.XXX);
            Assert.Equal(xxx, new Currency("XXX", "987", 1, "A different name"));
            Assert.NotEqual(Currency.XTS, Currency.XXX);
        }

        [Fact]
        public void You_Cannot_Compare_Currency_Against_Non_Currencies()
        {
            Assert.Equal(Currency.XXX, Currency.XXX);
            Assert.Equal(Currency.XXX, (Object)Currency.XXX);

            var exception = Assert.Throws<ArgumentException>(() => Currency.XXX.Equals(new Object()));
            var message = "System.Object is not an instance of TeixeiraSoftware.Finance.Currency";

            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void There_Is_A_Publicly_Visible_Readonly_List_Of_All_Currencies()
        {
            Assert.IsType<ReadOnlyCollection<Currency>>(Currency.AllCurrencies);
            Assert.Equal(178, Currency.AllCurrencies.Count);
        }
    }
}