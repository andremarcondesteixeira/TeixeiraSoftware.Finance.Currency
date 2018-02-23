using System;
using System.Collections.Generic;
using Xunit;

namespace TeixeiraSoftware.Finance
{
    public class CurrencyTest
    {
        [Fact]
        public void All_Factory_Methods_Return_New_Currency_Instances()
        {
            Assert.False(Object.ReferenceEquals(Currency.XXX, Currency.XXX));
            Assert.False(Object.ReferenceEquals(
                Currency.ByAlphabeticCode("XXX"),
                Currency.ByAlphabeticCode("XXX")
            ));
            Assert.False(Object.ReferenceEquals(
                Currency.ByNumericCode("999"),
                Currency.ByNumericCode("999")
            ));
        }

        [Fact]
        public void Currency_Instances_Can_Be_Created_By_Three_Ways()
        {
            Assert.IsType(typeof(Currency), Currency.XXX);
            Assert.IsType(typeof(Currency), Currency.ByAlphabeticCode("XXX"));
            Assert.IsType(typeof(Currency), Currency.ByNumericCode("999"));
        }

        [Fact]
        public void Currency_Getter_Methods_Throw_Exception_For_Nonexistent_Currencies()
        {
            Assert.Throws<ArgumentException>(() => Currency.ByAlphabeticCode("Nonexistent"));
            Assert.Throws<ArgumentException>(() => Currency.ByNumericCode("Nonexistent"));
        }

        [Fact]
        public void Currency_Instances_Are_Compared_Through_Their_Whole_Set_Of_Properties()
        {
            Assert.Equal(
                new Currency(
                    "XXX",
                    "999",
                    0,
                    "The codes assigned for transactions where no currency is involved"
                ),
                Currency.XXX
            );
            Assert.NotEqual(
                new Currency(
                    "XXX",
                    "999",
                    0, // Minor Units are different
                    "The codes assigned for transactions where no currency is involved"
                ),
                new Currency(
                    "XXX",
                    "999",
                    1, // Minor Units are different
                    "The codes assigned for transactions where no currency is involved"
                )
            );
            Assert.NotEqual(Currency.XTS, Currency.XXX);
        }

        [Fact]
        public void There_Is_A_Publicly_Visible_Readonly_List_Of_All_Currencies()
        {
            Assert.IsType(typeof(List<ICurrency>), Currency.AllCurrencies);
            Assert.Equal(178, Currency.AllCurrencies.Count);
        }
    }
}