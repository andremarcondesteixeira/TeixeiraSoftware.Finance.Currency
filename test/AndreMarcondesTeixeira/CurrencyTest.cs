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
            Assert.False(Object.ReferenceEquals(Currency.GetByLetterCode("XXX"), Currency.GetByLetterCode("XXX")));
            Assert.False(Object.ReferenceEquals(Currency.GetByNumericCode("999"), Currency.GetByNumericCode("999")));
        }

        [Fact]
        public void Currency_Instances_Can_Be_Created_By_Three_Ways()
        {
            Assert.IsType(typeof(Currency), Currency.XXX);
            Assert.IsType(typeof(Currency), Currency.GetByLetterCode("XXX"));
            Assert.IsType(typeof(Currency), Currency.GetByNumericCode("999"));
        }

        [Fact]
        public void Currency_Getter_Methods_Throws_Exception_For_Nonexistent_Currencies()
        {
            Assert.Throws<ArgumentException>(() => Currency.GetByLetterCode("Nonexistent"));
            Assert.Throws<ArgumentException>(() => Currency.GetByNumericCode("Nonexistent"));
        }

        [Fact]
        public void Currency_Instances_Are_Compared_Through_Their_Whole_Set_Of_Properties()
        {
            Assert.False(Currency.XXX == Currency.XTS);
            Assert.True(Currency.XTS != Currency.XXX);
        }
    }
}