using System;
using Xunit;

namespace AndreMarcondesTeixeira
{
    public class CurrencyTest
    {
        [Fact]
        public void Currency_Instances_Are_Compared_Through_Their_ISONumber()
        {
            var inexistentCurrency = new Currency("inexistent 1", "000", 2, "inexistent");
            var anotherInexistentCurrency = new Currency("inexistent1 ", "000", 0, "bar");

            Assert.False(Currency.XXX == Currency.XTS);
            Assert.True(Currency.XTS != Currency.XXX);
            Assert.True(inexistentCurrency == anotherInexistentCurrency);
            Assert.False(inexistentCurrency != anotherInexistentCurrency);
        }

        [Fact]
        public void Currency_Instances_Cannot_Compare_Against_Null()
        {
            var message = "Currency must not be null";

            var exception1 = Assert.Throws<ArgumentException>(() => Currency.XTS == null);
            Assert.Equal(message, exception1.Message);

            var exception2 = Assert.Throws<ArgumentException>(() => Currency.XTS.Equals(null));
            Assert.Equal(message, exception2.Message);

            var exception3 = Assert.Throws<ArgumentException>(() => null == Currency.XTS);
            Assert.Equal(message, exception3.Message);

            var exception4 = Assert.Throws<ArgumentException>(() => Currency.XTS != null);
            Assert.Equal(message, exception4.Message);

            var exception5 = Assert.Throws<ArgumentException>(() => null != Currency.XTS);
            Assert.Equal(message, exception5.Message);
        }
    }
}