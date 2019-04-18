using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xunit;

namespace TeixeiraSoftware.Finance
{
    public class CurrencyTest
    {
        [Fact]
        public void Currency_Instances_Can_Be_Created_By_Four_Ways()
        {
            Assert.IsType<Currency>(Currency.XXX);
            Assert.IsType<Currency>(Currency.ByAlphabeticCode("XXX"));
            Assert.IsType<Currency>(Currency.ByNumericCode("999"));
            Assert.IsType<Currency>(new Currency("XXX", "999", 0, "", "The codes assigned for transactions where no currency is involved"));
        }

        [Fact]
        public void Factory_Methods_Return_New_Currency_Instances()
        {
            Assert.False(ReferenceEquals(Currency.XXX, Currency.XXX));
            Assert.False(ReferenceEquals(Currency.ByAlphabeticCode("XXX"), Currency.ByAlphabeticCode("XXX")));
            Assert.False(ReferenceEquals(Currency.ByNumericCode("999"), Currency.ByNumericCode("999")));
        }

        [Fact]
        public void Currency_Getter_Methods_Throw_Exception_For_Nonexistent_Currencies()
        {
            var exception1 = Assert.Throws<ArgumentException>(() => Currency.ByAlphabeticCode("ZZZ"));
            var message1 = "There is no registered currency with the alphabetic code ZZZ";
            Assert.Equal(message1, exception1.Message);
            
            var exception2 = Assert.Throws<ArgumentException>(() => Currency.ByNumericCode("000"));
            var message2 = "There is no registered currency with the numeric code 000";
            Assert.Equal(message2, exception2.Message);
        }

        [Fact]
        public void Currency_Instances_Compare_Equality_Through_Their_Symbol_Properties()
        {
            var xxx = new Currency("XXX", "999", 0, "", "The codes assigned for transactions where no currency is involved");
            var xts = new Currency("XTS", "123", 0, "&", "Another name");
            var xxx2 = new Currency("XXX", "987", 1, "%", "A different name");

            Assert.Equal(xxx, xxx);
            Assert.Equal(xxx, xxx2);
            Assert.Equal(xxx, Currency.XXX);
            Assert.Equal(xxx2, xxx);
            Assert.Equal(xxx2, xxx2);
            Assert.Equal(xxx2, Currency.XXX);
            Assert.Equal(Currency.XXX, xxx);
            Assert.Equal(Currency.XXX, xxx2);
            Assert.Equal(Currency.XXX, Currency.XXX);
            Assert.NotEqual(xxx, xts);
            Assert.NotEqual(xxx, Currency.XTS);
            Assert.NotEqual(xxx2, xts);
            Assert.NotEqual(xxx2, Currency.XTS);
            Assert.NotEqual(Currency.XXX, xts);
            Assert.NotEqual(Currency.XXX, Currency.XTS);
        }

        [Fact]
        public void Currency_Instances_Compare_Equality_Through_Their_Symbol_Properties_When_Using_Object_Type()
        {
            var xxx = new Currency("XXX", "999", 0, "", "The codes assigned for transactions where no currency is involved");
            var xts = new Currency("XTS", "123", 0, "&", "Another name");
            var xxx2 = new Currency("XXX", "987", 1, "%", "A different name");

            Assert.Equal(xxx, (object) xxx);
            Assert.Equal(xxx, (object) xxx2);
            Assert.Equal(xxx, (object) Currency.XXX);
            Assert.Equal(xxx2, (object) xxx);
            Assert.Equal(xxx2, (object) xxx2);
            Assert.Equal(xxx2, (object) Currency.XXX);
            Assert.Equal(Currency.XXX, (object) xxx);
            Assert.Equal(Currency.XXX, (object) xxx2);
            Assert.Equal(Currency.XXX, (object) Currency.XXX);
            Assert.NotEqual(xxx, (object) xts);
            Assert.NotEqual(xxx, (object) Currency.XTS);
            Assert.NotEqual(xxx2, (object) xts);
            Assert.NotEqual(xxx2, (object) Currency.XTS);
            Assert.NotEqual(Currency.XXX, (object) xts);
            Assert.NotEqual(Currency.XXX, (object) Currency.XTS);
        }

        [Fact]
        public void Cannot_Compare_The_Equality_Of_A_Currency_Against_Non_Currencies()
        {
            var exception = Assert.Throws<ArgumentException>(() => Currency.XXX.Equals(new Object()));
            var message = "System.Object is not an instance of TeixeiraSoftware.Finance.ICurrency";

            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void Currency_Instances_Can_Be_Sorted_By_Their_Alphabetic_Code()
        {
            Assert.Equal(1, Currency.XXX.CompareTo(Currency.AED));
            Assert.Equal(0, Currency.XXX.CompareTo(Currency.XXX));
            Assert.Equal(-1, Currency.AED.CompareTo(Currency.XXX));
        }

        [Fact]
        public void Currency_Instances_Can_Be_Compared_Using_Object_Type()
        {
            Assert.Equal(1, Currency.XXX.CompareTo((object) Currency.AED));
            Assert.Equal(0, Currency.XXX.CompareTo((object) Currency.XXX));
            Assert.Equal(-1, Currency.AED.CompareTo((object) Currency.XXX));
        }

        [Fact]
        public void Cannot_Compare_The_Alphabetic_Code_Precedence_Of_A_Currency_Against_Non_Currencies()
        {
            var exception = Assert.Throws<ArgumentException>(() => Currency.XXX.CompareTo(new Object()));
            var message = "System.Object is not an instance of TeixeiraSoftware.Finance.ICurrency";

            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void There_Is_A_Publicly_Visible_Readonly_List_Of_All_The_ISO_Currencies()
        {
            Assert.IsType<ReadOnlyCollection<Currency>>(Currency.AllCurrencies);
            Assert.Equal(178, Currency.AllCurrencies.Count);
        }
    }
}