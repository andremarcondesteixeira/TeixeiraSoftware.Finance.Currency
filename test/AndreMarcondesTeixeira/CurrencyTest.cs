using System;
using Xunit;

namespace AndreMarcondesTeixeira
{
    public class CurrencyTest
    {
        [Fact]
        public void Currency_Is_A_Value_Type_And_All_Factory_Methods_Return_New_Instances()
        {
            Assert.False(Object.ReferenceEquals(Currency.XXX, Currency.XXX));
            //Assert.False(Object.ReferenceEquals(Currency.GetByLetterCode("XXX"), Currency.GetByLetterCode("XXX")));
            //Assert.False(Object.ReferenceEquals(Currency.GetByNumericCode("999"), Currency.GetByNumericCode("999")));
        }

        [Fact]
        public void Currency_Instances_Can_Be_Created_By_Four_Ways()
        {
            Assert.IsType(typeof(Currency), Currency.XXX);
            Assert.IsType(typeof(Currency), new Currency("ZZZ", "000", 0, "Test"));
            //Assert.IsType(typeof(Currency), Currency.GetByLetterCode("XXX"));
            //Assert.IsType(typeof(Currency), Currency.GetByNumericCode("999"));
        }

        [Fact]
        public void Currency_Instances_Are_Compared_Through_Their_Properties()
        {
            var customCurrency = new Currency("ZZ", "000", 2, "Test");
            var differentLetterCode = new Currency("ZZZ", "000", 2, "Test");
            var differentNumberCode = new Currency("ZZ", "00", 2, "Test");
            var differentMinorUnits = new Currency("ZZ", "000", 1, "Test");
            var differentName = new Currency("ZZ", "000", 2, "Different Name");
            var equivalentCurrency = new Currency("ZZ", "000", 2, "Test");

            Assert.True(customCurrency != differentLetterCode);
            Assert.True(customCurrency != differentNumberCode);
            Assert.True(customCurrency != differentMinorUnits);
            Assert.True(customCurrency != differentName);
            Assert.True(customCurrency == equivalentCurrency);
            Assert.False(customCurrency != equivalentCurrency);
            Assert.False(Currency.XXX == Currency.XTS);
            Assert.True(Currency.XTS != Currency.XXX);
        }
    }
}