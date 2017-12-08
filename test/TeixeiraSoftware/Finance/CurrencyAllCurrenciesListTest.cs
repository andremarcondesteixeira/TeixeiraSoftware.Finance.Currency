using Xunit;

namespace TeixeiraSoftware.Finance
{
    public class CurrencyAllCurrenciesListTest
    {
        [Fact]
        public void Test_Currency_AED_Properties()
        {
            Assert.Equal("AED", Currency.AED.LetterCode);
            Assert.Equal("784", Currency.AED.NumericCode);
            Assert.Equal("UAE Dirham", Currency.AED.Name);
            Assert.Equal(2, Currency.AED.MinorUnits);
        }

        [Fact]
        public void Test_Currency_AFN_Properties()
        {
            Assert.Equal("AFN", Currency.AFN.LetterCode);
            Assert.Equal("971", Currency.AFN.NumericCode);
            Assert.Equal("Afghani", Currency.AFN.Name);
            Assert.Equal(2, Currency.AFN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_ALL_Properties()
        {
            Assert.Equal("ALL", Currency.ALL.LetterCode);
            Assert.Equal("008", Currency.ALL.NumericCode);
            Assert.Equal("Lek", Currency.ALL.Name);
            Assert.Equal(2, Currency.ALL.MinorUnits);
        }

        [Fact]
        public void Test_Currency_AMD_Properties()
        {
            Assert.Equal("AMD", Currency.AMD.LetterCode);
            Assert.Equal("051", Currency.AMD.NumericCode);
            Assert.Equal("Armenian Dram", Currency.AMD.Name);
            Assert.Equal(2, Currency.AMD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_ANG_Properties()
        {
            Assert.Equal("ANG", Currency.ANG.LetterCode);
            Assert.Equal("532", Currency.ANG.NumericCode);
            Assert.Equal("Netherlands Antillean Guilder", Currency.ANG.Name);
            Assert.Equal(2, Currency.ANG.MinorUnits);
        }

        [Fact]
        public void Test_Currency_AOA_Properties()
        {
            Assert.Equal("AOA", Currency.AOA.LetterCode);
            Assert.Equal("973", Currency.AOA.NumericCode);
            Assert.Equal("Kwanza", Currency.AOA.Name);
            Assert.Equal(2, Currency.AOA.MinorUnits);
        }

        [Fact]
        public void Test_Currency_ARS_Properties()
        {
            Assert.Equal("ARS", Currency.ARS.LetterCode);
            Assert.Equal("032", Currency.ARS.NumericCode);
            Assert.Equal("Argentine Peso", Currency.ARS.Name);
            Assert.Equal(2, Currency.ARS.MinorUnits);
        }

        [Fact]
        public void Test_Currency_AUD_Properties()
        {
            Assert.Equal("AUD", Currency.AUD.LetterCode);
            Assert.Equal("036", Currency.AUD.NumericCode);
            Assert.Equal("Australian Dollar", Currency.AUD.Name);
            Assert.Equal(2, Currency.AUD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_AWG_Properties()
        {
            Assert.Equal("AWG", Currency.AWG.LetterCode);
            Assert.Equal("533", Currency.AWG.NumericCode);
            Assert.Equal("Aruban Florin", Currency.AWG.Name);
            Assert.Equal(2, Currency.AWG.MinorUnits);
        }

        [Fact]
        public void Test_Currency_AZN_Properties()
        {
            Assert.Equal("AZN", Currency.AZN.LetterCode);
            Assert.Equal("944", Currency.AZN.NumericCode);
            Assert.Equal("Azerbaijanian Manat", Currency.AZN.Name);
            Assert.Equal(2, Currency.AZN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BAM_Properties()
        {
            Assert.Equal("BAM", Currency.BAM.LetterCode);
            Assert.Equal("977", Currency.BAM.NumericCode);
            Assert.Equal("Convertible Mark", Currency.BAM.Name);
            Assert.Equal(2, Currency.BAM.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BBD_Properties()
        {
            Assert.Equal("BBD", Currency.BBD.LetterCode);
            Assert.Equal("052", Currency.BBD.NumericCode);
            Assert.Equal("Barbados Dollar", Currency.BBD.Name);
            Assert.Equal(2, Currency.BBD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BDT_Properties()
        {
            Assert.Equal("BDT", Currency.BDT.LetterCode);
            Assert.Equal("050", Currency.BDT.NumericCode);
            Assert.Equal("Taka", Currency.BDT.Name);
            Assert.Equal(2, Currency.BDT.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BGN_Properties()
        {
            Assert.Equal("BGN", Currency.BGN.LetterCode);
            Assert.Equal("975", Currency.BGN.NumericCode);
            Assert.Equal("Bulgarian Lev", Currency.BGN.Name);
            Assert.Equal(2, Currency.BGN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BHD_Properties()
        {
            Assert.Equal("BHD", Currency.BHD.LetterCode);
            Assert.Equal("048", Currency.BHD.NumericCode);
            Assert.Equal("Bahraini Dinar", Currency.BHD.Name);
            Assert.Equal(3, Currency.BHD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BIF_Properties()
        {
            Assert.Equal("BIF", Currency.BIF.LetterCode);
            Assert.Equal("108", Currency.BIF.NumericCode);
            Assert.Equal("Burundi Franc", Currency.BIF.Name);
            Assert.Equal(0, Currency.BIF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BMD_Properties()
        {
            Assert.Equal("BMD", Currency.BMD.LetterCode);
            Assert.Equal("060", Currency.BMD.NumericCode);
            Assert.Equal("Bermudian Dollar", Currency.BMD.Name);
            Assert.Equal(2, Currency.BMD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BND_Properties()
        {
            Assert.Equal("BND", Currency.BND.LetterCode);
            Assert.Equal("096", Currency.BND.NumericCode);
            Assert.Equal("Brunei Dollar", Currency.BND.Name);
            Assert.Equal(2, Currency.BND.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BOB_Properties()
        {
            Assert.Equal("BOB", Currency.BOB.LetterCode);
            Assert.Equal("068", Currency.BOB.NumericCode);
            Assert.Equal("Boliviano", Currency.BOB.Name);
            Assert.Equal(2, Currency.BOB.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BOV_Properties()
        {
            Assert.Equal("BOV", Currency.BOV.LetterCode);
            Assert.Equal("984", Currency.BOV.NumericCode);
            Assert.Equal("Mvdol", Currency.BOV.Name);
            Assert.Equal(2, Currency.BOV.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BRL_Properties()
        {
            Assert.Equal("BRL", Currency.BRL.LetterCode);
            Assert.Equal("986", Currency.BRL.NumericCode);
            Assert.Equal("Brazilian Real", Currency.BRL.Name);
            Assert.Equal(2, Currency.BRL.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BSD_Properties()
        {
            Assert.Equal("BSD", Currency.BSD.LetterCode);
            Assert.Equal("044", Currency.BSD.NumericCode);
            Assert.Equal("Bahamian Dollar", Currency.BSD.Name);
            Assert.Equal(2, Currency.BSD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BTN_Properties()
        {
            Assert.Equal("BTN", Currency.BTN.LetterCode);
            Assert.Equal("064", Currency.BTN.NumericCode);
            Assert.Equal("Ngultrum", Currency.BTN.Name);
            Assert.Equal(2, Currency.BTN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BWP_Properties()
        {
            Assert.Equal("BWP", Currency.BWP.LetterCode);
            Assert.Equal("072", Currency.BWP.NumericCode);
            Assert.Equal("Pula", Currency.BWP.Name);
            Assert.Equal(2, Currency.BWP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BYN_Properties()
        {
            Assert.Equal("BYN", Currency.BYN.LetterCode);
            Assert.Equal("933", Currency.BYN.NumericCode);
            Assert.Equal("Belarusian Ruble", Currency.BYN.Name);
            Assert.Equal(2, Currency.BYN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_BZD_Properties()
        {
            Assert.Equal("BZD", Currency.BZD.LetterCode);
            Assert.Equal("084", Currency.BZD.NumericCode);
            Assert.Equal("Belize Dollar", Currency.BZD.Name);
            Assert.Equal(2, Currency.BZD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CAD_Properties()
        {
            Assert.Equal("CAD", Currency.CAD.LetterCode);
            Assert.Equal("124", Currency.CAD.NumericCode);
            Assert.Equal("Canadian Dollar", Currency.CAD.Name);
            Assert.Equal(2, Currency.CAD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CDF_Properties()
        {
            Assert.Equal("CDF", Currency.CDF.LetterCode);
            Assert.Equal("976", Currency.CDF.NumericCode);
            Assert.Equal("Congolese Franc", Currency.CDF.Name);
            Assert.Equal(2, Currency.CDF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CHE_Properties()
        {
            Assert.Equal("CHE", Currency.CHE.LetterCode);
            Assert.Equal("947", Currency.CHE.NumericCode);
            Assert.Equal("WIR Euro", Currency.CHE.Name);
            Assert.Equal(2, Currency.CHE.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CHF_Properties()
        {
            Assert.Equal("CHF", Currency.CHF.LetterCode);
            Assert.Equal("756", Currency.CHF.NumericCode);
            Assert.Equal("Swiss Franc", Currency.CHF.Name);
            Assert.Equal(2, Currency.CHF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CHW_Properties()
        {
            Assert.Equal("CHW", Currency.CHW.LetterCode);
            Assert.Equal("948", Currency.CHW.NumericCode);
            Assert.Equal("WIR Franc", Currency.CHW.Name);
            Assert.Equal(2, Currency.CHW.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CLF_Properties()
        {
            Assert.Equal("CLF", Currency.CLF.LetterCode);
            Assert.Equal("990", Currency.CLF.NumericCode);
            Assert.Equal("Unidad de Fomento", Currency.CLF.Name);
            Assert.Equal(4, Currency.CLF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CLP_Properties()
        {
            Assert.Equal("CLP", Currency.CLP.LetterCode);
            Assert.Equal("152", Currency.CLP.NumericCode);
            Assert.Equal("Chilean Peso", Currency.CLP.Name);
            Assert.Equal(0, Currency.CLP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CNY_Properties()
        {
            Assert.Equal("CNY", Currency.CNY.LetterCode);
            Assert.Equal("156", Currency.CNY.NumericCode);
            Assert.Equal("Yuan Renminbi", Currency.CNY.Name);
            Assert.Equal(2, Currency.CNY.MinorUnits);
        }

        [Fact]
        public void Test_Currency_COP_Properties()
        {
            Assert.Equal("COP", Currency.COP.LetterCode);
            Assert.Equal("170", Currency.COP.NumericCode);
            Assert.Equal("Colombian Peso", Currency.COP.Name);
            Assert.Equal(2, Currency.COP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_COU_Properties()
        {
            Assert.Equal("COU", Currency.COU.LetterCode);
            Assert.Equal("970", Currency.COU.NumericCode);
            Assert.Equal("Unidad de Valor Real", Currency.COU.Name);
            Assert.Equal(2, Currency.COU.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CRC_Properties()
        {
            Assert.Equal("CRC", Currency.CRC.LetterCode);
            Assert.Equal("188", Currency.CRC.NumericCode);
            Assert.Equal("Costa Rican Colon", Currency.CRC.Name);
            Assert.Equal(2, Currency.CRC.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CUC_Properties()
        {
            Assert.Equal("CUC", Currency.CUC.LetterCode);
            Assert.Equal("931", Currency.CUC.NumericCode);
            Assert.Equal("Peso Convertible", Currency.CUC.Name);
            Assert.Equal(2, Currency.CUC.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CUP_Properties()
        {
            Assert.Equal("CUP", Currency.CUP.LetterCode);
            Assert.Equal("192", Currency.CUP.NumericCode);
            Assert.Equal("Cuban Peso", Currency.CUP.Name);
            Assert.Equal(2, Currency.CUP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CVE_Properties()
        {
            Assert.Equal("CVE", Currency.CVE.LetterCode);
            Assert.Equal("132", Currency.CVE.NumericCode);
            Assert.Equal("Cabo Verde Escudo", Currency.CVE.Name);
            Assert.Equal(2, Currency.CVE.MinorUnits);
        }

        [Fact]
        public void Test_Currency_CZK_Properties()
        {
            Assert.Equal("CZK", Currency.CZK.LetterCode);
            Assert.Equal("203", Currency.CZK.NumericCode);
            Assert.Equal("Czech Koruna", Currency.CZK.Name);
            Assert.Equal(2, Currency.CZK.MinorUnits);
        }

        [Fact]
        public void Test_Currency_DJF_Properties()
        {
            Assert.Equal("DJF", Currency.DJF.LetterCode);
            Assert.Equal("262", Currency.DJF.NumericCode);
            Assert.Equal("Djibouti Franc", Currency.DJF.Name);
            Assert.Equal(0, Currency.DJF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_DKK_Properties()
        {
            Assert.Equal("DKK", Currency.DKK.LetterCode);
            Assert.Equal("208", Currency.DKK.NumericCode);
            Assert.Equal("Danish Krone", Currency.DKK.Name);
            Assert.Equal(2, Currency.DKK.MinorUnits);
        }

        [Fact]
        public void Test_Currency_DOP_Properties()
        {
            Assert.Equal("DOP", Currency.DOP.LetterCode);
            Assert.Equal("214", Currency.DOP.NumericCode);
            Assert.Equal("Dominican Peso", Currency.DOP.Name);
            Assert.Equal(2, Currency.DOP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_DZD_Properties()
        {
            Assert.Equal("DZD", Currency.DZD.LetterCode);
            Assert.Equal("012", Currency.DZD.NumericCode);
            Assert.Equal("Algerian Dinar", Currency.DZD.Name);
            Assert.Equal(2, Currency.DZD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_EGP_Properties()
        {
            Assert.Equal("EGP", Currency.EGP.LetterCode);
            Assert.Equal("818", Currency.EGP.NumericCode);
            Assert.Equal("Egyptian Pound", Currency.EGP.Name);
            Assert.Equal(2, Currency.EGP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_ERN_Properties()
        {
            Assert.Equal("ERN", Currency.ERN.LetterCode);
            Assert.Equal("232", Currency.ERN.NumericCode);
            Assert.Equal("Nakfa", Currency.ERN.Name);
            Assert.Equal(2, Currency.ERN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_ETB_Properties()
        {
            Assert.Equal("ETB", Currency.ETB.LetterCode);
            Assert.Equal("230", Currency.ETB.NumericCode);
            Assert.Equal("Ethiopian Birr", Currency.ETB.Name);
            Assert.Equal(2, Currency.ETB.MinorUnits);
        }

        [Fact]
        public void Test_Currency_EUR_Properties()
        {
            Assert.Equal("EUR", Currency.EUR.LetterCode);
            Assert.Equal("978", Currency.EUR.NumericCode);
            Assert.Equal("Euro", Currency.EUR.Name);
            Assert.Equal(2, Currency.EUR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_FJD_Properties()
        {
            Assert.Equal("FJD", Currency.FJD.LetterCode);
            Assert.Equal("242", Currency.FJD.NumericCode);
            Assert.Equal("Fiji Dollar", Currency.FJD.Name);
            Assert.Equal(2, Currency.FJD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_FKP_Properties()
        {
            Assert.Equal("FKP", Currency.FKP.LetterCode);
            Assert.Equal("238", Currency.FKP.NumericCode);
            Assert.Equal("Falkland Islands Pound", Currency.FKP.Name);
            Assert.Equal(2, Currency.FKP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_GBP_Properties()
        {
            Assert.Equal("GBP", Currency.GBP.LetterCode);
            Assert.Equal("826", Currency.GBP.NumericCode);
            Assert.Equal("Pound Sterling", Currency.GBP.Name);
            Assert.Equal(2, Currency.GBP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_GEL_Properties()
        {
            Assert.Equal("GEL", Currency.GEL.LetterCode);
            Assert.Equal("981", Currency.GEL.NumericCode);
            Assert.Equal("Lari", Currency.GEL.Name);
            Assert.Equal(2, Currency.GEL.MinorUnits);
        }

        [Fact]
        public void Test_Currency_GHS_Properties()
        {
            Assert.Equal("GHS", Currency.GHS.LetterCode);
            Assert.Equal("936", Currency.GHS.NumericCode);
            Assert.Equal("Ghana Cedi", Currency.GHS.Name);
            Assert.Equal(2, Currency.GHS.MinorUnits);
        }

        [Fact]
        public void Test_Currency_GIP_Properties()
        {
            Assert.Equal("GIP", Currency.GIP.LetterCode);
            Assert.Equal("292", Currency.GIP.NumericCode);
            Assert.Equal("Gibraltar Pound", Currency.GIP.Name);
            Assert.Equal(2, Currency.GIP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_GMD_Properties()
        {
            Assert.Equal("GMD", Currency.GMD.LetterCode);
            Assert.Equal("270", Currency.GMD.NumericCode);
            Assert.Equal("Dalasi", Currency.GMD.Name);
            Assert.Equal(2, Currency.GMD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_GNF_Properties()
        {
            Assert.Equal("GNF", Currency.GNF.LetterCode);
            Assert.Equal("324", Currency.GNF.NumericCode);
            Assert.Equal("Guinea Franc", Currency.GNF.Name);
            Assert.Equal(0, Currency.GNF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_GTQ_Properties()
        {
            Assert.Equal("GTQ", Currency.GTQ.LetterCode);
            Assert.Equal("320", Currency.GTQ.NumericCode);
            Assert.Equal("Quetzal", Currency.GTQ.Name);
            Assert.Equal(2, Currency.GTQ.MinorUnits);
        }

        [Fact]
        public void Test_Currency_GYD_Properties()
        {
            Assert.Equal("GYD", Currency.GYD.LetterCode);
            Assert.Equal("328", Currency.GYD.NumericCode);
            Assert.Equal("Guyana Dollar", Currency.GYD.Name);
            Assert.Equal(2, Currency.GYD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_HKD_Properties()
        {
            Assert.Equal("HKD", Currency.HKD.LetterCode);
            Assert.Equal("344", Currency.HKD.NumericCode);
            Assert.Equal("Hong Kong Dollar", Currency.HKD.Name);
            Assert.Equal(2, Currency.HKD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_HNL_Properties()
        {
            Assert.Equal("HNL", Currency.HNL.LetterCode);
            Assert.Equal("340", Currency.HNL.NumericCode);
            Assert.Equal("Lempira", Currency.HNL.Name);
            Assert.Equal(2, Currency.HNL.MinorUnits);
        }

        [Fact]
        public void Test_Currency_HRK_Properties()
        {
            Assert.Equal("HRK", Currency.HRK.LetterCode);
            Assert.Equal("191", Currency.HRK.NumericCode);
            Assert.Equal("Kuna", Currency.HRK.Name);
            Assert.Equal(2, Currency.HRK.MinorUnits);
        }

        [Fact]
        public void Test_Currency_HTG_Properties()
        {
            Assert.Equal("HTG", Currency.HTG.LetterCode);
            Assert.Equal("332", Currency.HTG.NumericCode);
            Assert.Equal("Gourde", Currency.HTG.Name);
            Assert.Equal(2, Currency.HTG.MinorUnits);
        }

        [Fact]
        public void Test_Currency_HUF_Properties()
        {
            Assert.Equal("HUF", Currency.HUF.LetterCode);
            Assert.Equal("348", Currency.HUF.NumericCode);
            Assert.Equal("Forint", Currency.HUF.Name);
            Assert.Equal(2, Currency.HUF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_IDR_Properties()
        {
            Assert.Equal("IDR", Currency.IDR.LetterCode);
            Assert.Equal("360", Currency.IDR.NumericCode);
            Assert.Equal("Rupiah", Currency.IDR.Name);
            Assert.Equal(2, Currency.IDR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_ILS_Properties()
        {
            Assert.Equal("ILS", Currency.ILS.LetterCode);
            Assert.Equal("376", Currency.ILS.NumericCode);
            Assert.Equal("New Israeli Sheqel", Currency.ILS.Name);
            Assert.Equal(2, Currency.ILS.MinorUnits);
        }

        [Fact]
        public void Test_Currency_INR_Properties()
        {
            Assert.Equal("INR", Currency.INR.LetterCode);
            Assert.Equal("356", Currency.INR.NumericCode);
            Assert.Equal("Indian Rupee", Currency.INR.Name);
            Assert.Equal(2, Currency.INR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_IQD_Properties()
        {
            Assert.Equal("IQD", Currency.IQD.LetterCode);
            Assert.Equal("368", Currency.IQD.NumericCode);
            Assert.Equal("Iraqi Dinar", Currency.IQD.Name);
            Assert.Equal(3, Currency.IQD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_IRR_Properties()
        {
            Assert.Equal("IRR", Currency.IRR.LetterCode);
            Assert.Equal("364", Currency.IRR.NumericCode);
            Assert.Equal("Iranian Rial", Currency.IRR.Name);
            Assert.Equal(2, Currency.IRR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_ISK_Properties()
        {
            Assert.Equal("ISK", Currency.ISK.LetterCode);
            Assert.Equal("352", Currency.ISK.NumericCode);
            Assert.Equal("Iceland Krona", Currency.ISK.Name);
            Assert.Equal(0, Currency.ISK.MinorUnits);
        }

        [Fact]
        public void Test_Currency_JMD_Properties()
        {
            Assert.Equal("JMD", Currency.JMD.LetterCode);
            Assert.Equal("388", Currency.JMD.NumericCode);
            Assert.Equal("Jamaican Dollar", Currency.JMD.Name);
            Assert.Equal(2, Currency.JMD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_JOD_Properties()
        {
            Assert.Equal("JOD", Currency.JOD.LetterCode);
            Assert.Equal("400", Currency.JOD.NumericCode);
            Assert.Equal("Jordanian Dinar", Currency.JOD.Name);
            Assert.Equal(3, Currency.JOD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_JPY_Properties()
        {
            Assert.Equal("JPY", Currency.JPY.LetterCode);
            Assert.Equal("392", Currency.JPY.NumericCode);
            Assert.Equal("Yen", Currency.JPY.Name);
            Assert.Equal(0, Currency.JPY.MinorUnits);
        }

        [Fact]
        public void Test_Currency_KES_Properties()
        {
            Assert.Equal("KES", Currency.KES.LetterCode);
            Assert.Equal("404", Currency.KES.NumericCode);
            Assert.Equal("Kenyan Shilling", Currency.KES.Name);
            Assert.Equal(2, Currency.KES.MinorUnits);
        }

        [Fact]
        public void Test_Currency_KGS_Properties()
        {
            Assert.Equal("KGS", Currency.KGS.LetterCode);
            Assert.Equal("417", Currency.KGS.NumericCode);
            Assert.Equal("Som", Currency.KGS.Name);
            Assert.Equal(2, Currency.KGS.MinorUnits);
        }

        [Fact]
        public void Test_Currency_KHR_Properties()
        {
            Assert.Equal("KHR", Currency.KHR.LetterCode);
            Assert.Equal("116", Currency.KHR.NumericCode);
            Assert.Equal("Riel", Currency.KHR.Name);
            Assert.Equal(2, Currency.KHR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_KMF_Properties()
        {
            Assert.Equal("KMF", Currency.KMF.LetterCode);
            Assert.Equal("174", Currency.KMF.NumericCode);
            Assert.Equal("Comoro Franc", Currency.KMF.Name);
            Assert.Equal(0, Currency.KMF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_KPW_Properties()
        {
            Assert.Equal("KPW", Currency.KPW.LetterCode);
            Assert.Equal("408", Currency.KPW.NumericCode);
            Assert.Equal("North Korean Won", Currency.KPW.Name);
            Assert.Equal(2, Currency.KPW.MinorUnits);
        }

        [Fact]
        public void Test_Currency_KRW_Properties()
        {
            Assert.Equal("KRW", Currency.KRW.LetterCode);
            Assert.Equal("410", Currency.KRW.NumericCode);
            Assert.Equal("Won", Currency.KRW.Name);
            Assert.Equal(0, Currency.KRW.MinorUnits);
        }

        [Fact]
        public void Test_Currency_KWD_Properties()
        {
            Assert.Equal("KWD", Currency.KWD.LetterCode);
            Assert.Equal("414", Currency.KWD.NumericCode);
            Assert.Equal("Kuwaiti Dinar", Currency.KWD.Name);
            Assert.Equal(3, Currency.KWD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_KYD_Properties()
        {
            Assert.Equal("KYD", Currency.KYD.LetterCode);
            Assert.Equal("136", Currency.KYD.NumericCode);
            Assert.Equal("Cayman Islands Dollar", Currency.KYD.Name);
            Assert.Equal(2, Currency.KYD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_KZT_Properties()
        {
            Assert.Equal("KZT", Currency.KZT.LetterCode);
            Assert.Equal("398", Currency.KZT.NumericCode);
            Assert.Equal("Tenge", Currency.KZT.Name);
            Assert.Equal(2, Currency.KZT.MinorUnits);
        }

        [Fact]
        public void Test_Currency_LAK_Properties()
        {
            Assert.Equal("LAK", Currency.LAK.LetterCode);
            Assert.Equal("418", Currency.LAK.NumericCode);
            Assert.Equal("Kip", Currency.LAK.Name);
            Assert.Equal(2, Currency.LAK.MinorUnits);
        }

        [Fact]
        public void Test_Currency_LBP_Properties()
        {
            Assert.Equal("LBP", Currency.LBP.LetterCode);
            Assert.Equal("422", Currency.LBP.NumericCode);
            Assert.Equal("Lebanese Pound", Currency.LBP.Name);
            Assert.Equal(2, Currency.LBP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_LKR_Properties()
        {
            Assert.Equal("LKR", Currency.LKR.LetterCode);
            Assert.Equal("144", Currency.LKR.NumericCode);
            Assert.Equal("Sri Lanka Rupee", Currency.LKR.Name);
            Assert.Equal(2, Currency.LKR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_LRD_Properties()
        {
            Assert.Equal("LRD", Currency.LRD.LetterCode);
            Assert.Equal("430", Currency.LRD.NumericCode);
            Assert.Equal("Liberian Dollar", Currency.LRD.Name);
            Assert.Equal(2, Currency.LRD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_LSL_Properties()
        {
            Assert.Equal("LSL", Currency.LSL.LetterCode);
            Assert.Equal("426", Currency.LSL.NumericCode);
            Assert.Equal("Loti", Currency.LSL.Name);
            Assert.Equal(2, Currency.LSL.MinorUnits);
        }

        [Fact]
        public void Test_Currency_LYD_Properties()
        {
            Assert.Equal("LYD", Currency.LYD.LetterCode);
            Assert.Equal("434", Currency.LYD.NumericCode);
            Assert.Equal("Libyan Dinar", Currency.LYD.Name);
            Assert.Equal(3, Currency.LYD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MAD_Properties()
        {
            Assert.Equal("MAD", Currency.MAD.LetterCode);
            Assert.Equal("504", Currency.MAD.NumericCode);
            Assert.Equal("Moroccan Dirham", Currency.MAD.Name);
            Assert.Equal(2, Currency.MAD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MDL_Properties()
        {
            Assert.Equal("MDL", Currency.MDL.LetterCode);
            Assert.Equal("498", Currency.MDL.NumericCode);
            Assert.Equal("Moldovan Leu", Currency.MDL.Name);
            Assert.Equal(2, Currency.MDL.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MGA_Properties()
        {
            Assert.Equal("MGA", Currency.MGA.LetterCode);
            Assert.Equal("969", Currency.MGA.NumericCode);
            Assert.Equal("Malagasy Ariary", Currency.MGA.Name);
            Assert.Equal(2, Currency.MGA.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MKD_Properties()
        {
            Assert.Equal("MKD", Currency.MKD.LetterCode);
            Assert.Equal("807", Currency.MKD.NumericCode);
            Assert.Equal("Denar", Currency.MKD.Name);
            Assert.Equal(2, Currency.MKD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MMK_Properties()
        {
            Assert.Equal("MMK", Currency.MMK.LetterCode);
            Assert.Equal("104", Currency.MMK.NumericCode);
            Assert.Equal("Kyat", Currency.MMK.Name);
            Assert.Equal(2, Currency.MMK.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MNT_Properties()
        {
            Assert.Equal("MNT", Currency.MNT.LetterCode);
            Assert.Equal("496", Currency.MNT.NumericCode);
            Assert.Equal("Tugrik", Currency.MNT.Name);
            Assert.Equal(2, Currency.MNT.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MOP_Properties()
        {
            Assert.Equal("MOP", Currency.MOP.LetterCode);
            Assert.Equal("446", Currency.MOP.NumericCode);
            Assert.Equal("Pataca", Currency.MOP.Name);
            Assert.Equal(2, Currency.MOP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MRO_Properties()
        {
            Assert.Equal("MRO", Currency.MRO.LetterCode);
            Assert.Equal("478", Currency.MRO.NumericCode);
            Assert.Equal("Ouguiya", Currency.MRO.Name);
            Assert.Equal(2, Currency.MRO.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MUR_Properties()
        {
            Assert.Equal("MUR", Currency.MUR.LetterCode);
            Assert.Equal("480", Currency.MUR.NumericCode);
            Assert.Equal("Mauritius Rupee", Currency.MUR.Name);
            Assert.Equal(2, Currency.MUR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MVR_Properties()
        {
            Assert.Equal("MVR", Currency.MVR.LetterCode);
            Assert.Equal("462", Currency.MVR.NumericCode);
            Assert.Equal("Rufiyaa", Currency.MVR.Name);
            Assert.Equal(2, Currency.MVR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MWK_Properties()
        {
            Assert.Equal("MWK", Currency.MWK.LetterCode);
            Assert.Equal("454", Currency.MWK.NumericCode);
            Assert.Equal("Malawi Kwacha", Currency.MWK.Name);
            Assert.Equal(2, Currency.MWK.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MXN_Properties()
        {
            Assert.Equal("MXN", Currency.MXN.LetterCode);
            Assert.Equal("484", Currency.MXN.NumericCode);
            Assert.Equal("Mexican Peso", Currency.MXN.Name);
            Assert.Equal(2, Currency.MXN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MXV_Properties()
        {
            Assert.Equal("MXV", Currency.MXV.LetterCode);
            Assert.Equal("979", Currency.MXV.NumericCode);
            Assert.Equal("Mexican Unidad de Inversion (UDI)", Currency.MXV.Name);
            Assert.Equal(2, Currency.MXV.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MYR_Properties()
        {
            Assert.Equal("MYR", Currency.MYR.LetterCode);
            Assert.Equal("458", Currency.MYR.NumericCode);
            Assert.Equal("Malaysian Ringgit", Currency.MYR.Name);
            Assert.Equal(2, Currency.MYR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_MZN_Properties()
        {
            Assert.Equal("MZN", Currency.MZN.LetterCode);
            Assert.Equal("943", Currency.MZN.NumericCode);
            Assert.Equal("Mozambique Metical", Currency.MZN.Name);
            Assert.Equal(2, Currency.MZN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_NAD_Properties()
        {
            Assert.Equal("NAD", Currency.NAD.LetterCode);
            Assert.Equal("516", Currency.NAD.NumericCode);
            Assert.Equal("Namibia Dollar", Currency.NAD.Name);
            Assert.Equal(2, Currency.NAD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_NGN_Properties()
        {
            Assert.Equal("NGN", Currency.NGN.LetterCode);
            Assert.Equal("566", Currency.NGN.NumericCode);
            Assert.Equal("Naira", Currency.NGN.Name);
            Assert.Equal(2, Currency.NGN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_NIO_Properties()
        {
            Assert.Equal("NIO", Currency.NIO.LetterCode);
            Assert.Equal("558", Currency.NIO.NumericCode);
            Assert.Equal("Cordoba Oro", Currency.NIO.Name);
            Assert.Equal(2, Currency.NIO.MinorUnits);
        }

        [Fact]
        public void Test_Currency_NOK_Properties()
        {
            Assert.Equal("NOK", Currency.NOK.LetterCode);
            Assert.Equal("578", Currency.NOK.NumericCode);
            Assert.Equal("Norwegian Krone", Currency.NOK.Name);
            Assert.Equal(2, Currency.NOK.MinorUnits);
        }

        [Fact]
        public void Test_Currency_NPR_Properties()
        {
            Assert.Equal("NPR", Currency.NPR.LetterCode);
            Assert.Equal("524", Currency.NPR.NumericCode);
            Assert.Equal("Nepalese Rupee", Currency.NPR.Name);
            Assert.Equal(2, Currency.NPR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_NZD_Properties()
        {
            Assert.Equal("NZD", Currency.NZD.LetterCode);
            Assert.Equal("554", Currency.NZD.NumericCode);
            Assert.Equal("New Zealand Dollar", Currency.NZD.Name);
            Assert.Equal(2, Currency.NZD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_OMR_Properties()
        {
            Assert.Equal("OMR", Currency.OMR.LetterCode);
            Assert.Equal("512", Currency.OMR.NumericCode);
            Assert.Equal("Rial Omani", Currency.OMR.Name);
            Assert.Equal(3, Currency.OMR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_PAB_Properties()
        {
            Assert.Equal("PAB", Currency.PAB.LetterCode);
            Assert.Equal("590", Currency.PAB.NumericCode);
            Assert.Equal("Balboa", Currency.PAB.Name);
            Assert.Equal(2, Currency.PAB.MinorUnits);
        }

        [Fact]
        public void Test_Currency_PEN_Properties()
        {
            Assert.Equal("PEN", Currency.PEN.LetterCode);
            Assert.Equal("604", Currency.PEN.NumericCode);
            Assert.Equal("Sol", Currency.PEN.Name);
            Assert.Equal(2, Currency.PEN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_PGK_Properties()
        {
            Assert.Equal("PGK", Currency.PGK.LetterCode);
            Assert.Equal("598", Currency.PGK.NumericCode);
            Assert.Equal("Kina", Currency.PGK.Name);
            Assert.Equal(2, Currency.PGK.MinorUnits);
        }

        [Fact]
        public void Test_Currency_PHP_Properties()
        {
            Assert.Equal("PHP", Currency.PHP.LetterCode);
            Assert.Equal("608", Currency.PHP.NumericCode);
            Assert.Equal("Philippine Peso", Currency.PHP.Name);
            Assert.Equal(2, Currency.PHP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_PKR_Properties()
        {
            Assert.Equal("PKR", Currency.PKR.LetterCode);
            Assert.Equal("586", Currency.PKR.NumericCode);
            Assert.Equal("Pakistan Rupee", Currency.PKR.Name);
            Assert.Equal(2, Currency.PKR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_PLN_Properties()
        {
            Assert.Equal("PLN", Currency.PLN.LetterCode);
            Assert.Equal("985", Currency.PLN.NumericCode);
            Assert.Equal("Zloty", Currency.PLN.Name);
            Assert.Equal(2, Currency.PLN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_PYG_Properties()
        {
            Assert.Equal("PYG", Currency.PYG.LetterCode);
            Assert.Equal("600", Currency.PYG.NumericCode);
            Assert.Equal("Guarani", Currency.PYG.Name);
            Assert.Equal(0, Currency.PYG.MinorUnits);
        }

        [Fact]
        public void Test_Currency_QAR_Properties()
        {
            Assert.Equal("QAR", Currency.QAR.LetterCode);
            Assert.Equal("634", Currency.QAR.NumericCode);
            Assert.Equal("Qatari Rial", Currency.QAR.Name);
            Assert.Equal(2, Currency.QAR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_RON_Properties()
        {
            Assert.Equal("RON", Currency.RON.LetterCode);
            Assert.Equal("946", Currency.RON.NumericCode);
            Assert.Equal("Romanian Leu", Currency.RON.Name);
            Assert.Equal(2, Currency.RON.MinorUnits);
        }

        [Fact]
        public void Test_Currency_RSD_Properties()
        {
            Assert.Equal("RSD", Currency.RSD.LetterCode);
            Assert.Equal("941", Currency.RSD.NumericCode);
            Assert.Equal("Serbian Dinar", Currency.RSD.Name);
            Assert.Equal(2, Currency.RSD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_RUB_Properties()
        {
            Assert.Equal("RUB", Currency.RUB.LetterCode);
            Assert.Equal("643", Currency.RUB.NumericCode);
            Assert.Equal("Russian Ruble", Currency.RUB.Name);
            Assert.Equal(2, Currency.RUB.MinorUnits);
        }

        [Fact]
        public void Test_Currency_RWF_Properties()
        {
            Assert.Equal("RWF", Currency.RWF.LetterCode);
            Assert.Equal("646", Currency.RWF.NumericCode);
            Assert.Equal("Rwanda Franc", Currency.RWF.Name);
            Assert.Equal(0, Currency.RWF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SAR_Properties()
        {
            Assert.Equal("SAR", Currency.SAR.LetterCode);
            Assert.Equal("682", Currency.SAR.NumericCode);
            Assert.Equal("Saudi Riyal", Currency.SAR.Name);
            Assert.Equal(2, Currency.SAR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SBD_Properties()
        {
            Assert.Equal("SBD", Currency.SBD.LetterCode);
            Assert.Equal("090", Currency.SBD.NumericCode);
            Assert.Equal("Solomon Islands Dollar", Currency.SBD.Name);
            Assert.Equal(2, Currency.SBD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SCR_Properties()
        {
            Assert.Equal("SCR", Currency.SCR.LetterCode);
            Assert.Equal("690", Currency.SCR.NumericCode);
            Assert.Equal("Seychelles Rupee", Currency.SCR.Name);
            Assert.Equal(2, Currency.SCR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SDG_Properties()
        {
            Assert.Equal("SDG", Currency.SDG.LetterCode);
            Assert.Equal("938", Currency.SDG.NumericCode);
            Assert.Equal("Sudanese Pound", Currency.SDG.Name);
            Assert.Equal(2, Currency.SDG.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SEK_Properties()
        {
            Assert.Equal("SEK", Currency.SEK.LetterCode);
            Assert.Equal("752", Currency.SEK.NumericCode);
            Assert.Equal("Swedish Krona", Currency.SEK.Name);
            Assert.Equal(2, Currency.SEK.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SGD_Properties()
        {
            Assert.Equal("SGD", Currency.SGD.LetterCode);
            Assert.Equal("702", Currency.SGD.NumericCode);
            Assert.Equal("Singapore Dollar", Currency.SGD.Name);
            Assert.Equal(2, Currency.SGD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SHP_Properties()
        {
            Assert.Equal("SHP", Currency.SHP.LetterCode);
            Assert.Equal("654", Currency.SHP.NumericCode);
            Assert.Equal("Saint Helena Pound", Currency.SHP.Name);
            Assert.Equal(2, Currency.SHP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SLL_Properties()
        {
            Assert.Equal("SLL", Currency.SLL.LetterCode);
            Assert.Equal("694", Currency.SLL.NumericCode);
            Assert.Equal("Leone", Currency.SLL.Name);
            Assert.Equal(2, Currency.SLL.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SOS_Properties()
        {
            Assert.Equal("SOS", Currency.SOS.LetterCode);
            Assert.Equal("706", Currency.SOS.NumericCode);
            Assert.Equal("Somali Shilling", Currency.SOS.Name);
            Assert.Equal(2, Currency.SOS.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SRD_Properties()
        {
            Assert.Equal("SRD", Currency.SRD.LetterCode);
            Assert.Equal("968", Currency.SRD.NumericCode);
            Assert.Equal("Surinam Dollar", Currency.SRD.Name);
            Assert.Equal(2, Currency.SRD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SSP_Properties()
        {
            Assert.Equal("SSP", Currency.SSP.LetterCode);
            Assert.Equal("728", Currency.SSP.NumericCode);
            Assert.Equal("South Sudanese Pound", Currency.SSP.Name);
            Assert.Equal(2, Currency.SSP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_STD_Properties()
        {
            Assert.Equal("STD", Currency.STD.LetterCode);
            Assert.Equal("678", Currency.STD.NumericCode);
            Assert.Equal("Dobra", Currency.STD.Name);
            Assert.Equal(2, Currency.STD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SVC_Properties()
        {
            Assert.Equal("SVC", Currency.SVC.LetterCode);
            Assert.Equal("222", Currency.SVC.NumericCode);
            Assert.Equal("El Salvador Colon", Currency.SVC.Name);
            Assert.Equal(2, Currency.SVC.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SYP_Properties()
        {
            Assert.Equal("SYP", Currency.SYP.LetterCode);
            Assert.Equal("760", Currency.SYP.NumericCode);
            Assert.Equal("Syrian Pound", Currency.SYP.Name);
            Assert.Equal(2, Currency.SYP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_SZL_Properties()
        {
            Assert.Equal("SZL", Currency.SZL.LetterCode);
            Assert.Equal("748", Currency.SZL.NumericCode);
            Assert.Equal("Lilangeni", Currency.SZL.Name);
            Assert.Equal(2, Currency.SZL.MinorUnits);
        }

        [Fact]
        public void Test_Currency_THB_Properties()
        {
            Assert.Equal("THB", Currency.THB.LetterCode);
            Assert.Equal("764", Currency.THB.NumericCode);
            Assert.Equal("Baht", Currency.THB.Name);
            Assert.Equal(2, Currency.THB.MinorUnits);
        }

        [Fact]
        public void Test_Currency_TJS_Properties()
        {
            Assert.Equal("TJS", Currency.TJS.LetterCode);
            Assert.Equal("972", Currency.TJS.NumericCode);
            Assert.Equal("Somoni", Currency.TJS.Name);
            Assert.Equal(2, Currency.TJS.MinorUnits);
        }

        [Fact]
        public void Test_Currency_TMT_Properties()
        {
            Assert.Equal("TMT", Currency.TMT.LetterCode);
            Assert.Equal("934", Currency.TMT.NumericCode);
            Assert.Equal("Turkmenistan New Manat", Currency.TMT.Name);
            Assert.Equal(2, Currency.TMT.MinorUnits);
        }

        [Fact]
        public void Test_Currency_TND_Properties()
        {
            Assert.Equal("TND", Currency.TND.LetterCode);
            Assert.Equal("788", Currency.TND.NumericCode);
            Assert.Equal("Tunisian Dinar", Currency.TND.Name);
            Assert.Equal(3, Currency.TND.MinorUnits);
        }

        [Fact]
        public void Test_Currency_TOP_Properties()
        {
            Assert.Equal("TOP", Currency.TOP.LetterCode);
            Assert.Equal("776", Currency.TOP.NumericCode);
            Assert.Equal("Pa’anga", Currency.TOP.Name);
            Assert.Equal(2, Currency.TOP.MinorUnits);
        }

        [Fact]
        public void Test_Currency_TRY_Properties()
        {
            Assert.Equal("TRY", Currency.TRY.LetterCode);
            Assert.Equal("949", Currency.TRY.NumericCode);
            Assert.Equal("Turkish Lira", Currency.TRY.Name);
            Assert.Equal(2, Currency.TRY.MinorUnits);
        }

        [Fact]
        public void Test_Currency_TTD_Properties()
        {
            Assert.Equal("TTD", Currency.TTD.LetterCode);
            Assert.Equal("780", Currency.TTD.NumericCode);
            Assert.Equal("Trinidad and Tobago Dollar", Currency.TTD.Name);
            Assert.Equal(2, Currency.TTD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_TWD_Properties()
        {
            Assert.Equal("TWD", Currency.TWD.LetterCode);
            Assert.Equal("901", Currency.TWD.NumericCode);
            Assert.Equal("New Taiwan Dollar", Currency.TWD.Name);
            Assert.Equal(2, Currency.TWD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_TZS_Properties()
        {
            Assert.Equal("TZS", Currency.TZS.LetterCode);
            Assert.Equal("834", Currency.TZS.NumericCode);
            Assert.Equal("Tanzanian Shilling", Currency.TZS.Name);
            Assert.Equal(2, Currency.TZS.MinorUnits);
        }

        [Fact]
        public void Test_Currency_UAH_Properties()
        {
            Assert.Equal("UAH", Currency.UAH.LetterCode);
            Assert.Equal("980", Currency.UAH.NumericCode);
            Assert.Equal("Hryvnia", Currency.UAH.Name);
            Assert.Equal(2, Currency.UAH.MinorUnits);
        }

        [Fact]
        public void Test_Currency_UGX_Properties()
        {
            Assert.Equal("UGX", Currency.UGX.LetterCode);
            Assert.Equal("800", Currency.UGX.NumericCode);
            Assert.Equal("Uganda Shilling", Currency.UGX.Name);
            Assert.Equal(0, Currency.UGX.MinorUnits);
        }

        [Fact]
        public void Test_Currency_USD_Properties()
        {
            Assert.Equal("USD", Currency.USD.LetterCode);
            Assert.Equal("840", Currency.USD.NumericCode);
            Assert.Equal("US Dollar", Currency.USD.Name);
            Assert.Equal(2, Currency.USD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_USN_Properties()
        {
            Assert.Equal("USN", Currency.USN.LetterCode);
            Assert.Equal("997", Currency.USN.NumericCode);
            Assert.Equal("US Dollar (Next day)", Currency.USN.Name);
            Assert.Equal(2, Currency.USN.MinorUnits);
        }

        [Fact]
        public void Test_Currency_UYI_Properties()
        {
            Assert.Equal("UYI", Currency.UYI.LetterCode);
            Assert.Equal("940", Currency.UYI.NumericCode);
            Assert.Equal("Uruguay Peso en Unidades Indexadas (URUIURUI)", Currency.UYI.Name);
            Assert.Equal(0, Currency.UYI.MinorUnits);
        }

        [Fact]
        public void Test_Currency_UYU_Properties()
        {
            Assert.Equal("UYU", Currency.UYU.LetterCode);
            Assert.Equal("858", Currency.UYU.NumericCode);
            Assert.Equal("Peso Uruguayo", Currency.UYU.Name);
            Assert.Equal(2, Currency.UYU.MinorUnits);
        }

        [Fact]
        public void Test_Currency_UZS_Properties()
        {
            Assert.Equal("UZS", Currency.UZS.LetterCode);
            Assert.Equal("860", Currency.UZS.NumericCode);
            Assert.Equal("Uzbekistan Sum", Currency.UZS.Name);
            Assert.Equal(2, Currency.UZS.MinorUnits);
        }

        [Fact]
        public void Test_Currency_VEF_Properties()
        {
            Assert.Equal("VEF", Currency.VEF.LetterCode);
            Assert.Equal("937", Currency.VEF.NumericCode);
            Assert.Equal("Bolívar", Currency.VEF.Name);
            Assert.Equal(2, Currency.VEF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_VND_Properties()
        {
            Assert.Equal("VND", Currency.VND.LetterCode);
            Assert.Equal("704", Currency.VND.NumericCode);
            Assert.Equal("Dong", Currency.VND.Name);
            Assert.Equal(0, Currency.VND.MinorUnits);
        }

        [Fact]
        public void Test_Currency_VUV_Properties()
        {
            Assert.Equal("VUV", Currency.VUV.LetterCode);
            Assert.Equal("548", Currency.VUV.NumericCode);
            Assert.Equal("Vatu", Currency.VUV.Name);
            Assert.Equal(0, Currency.VUV.MinorUnits);
        }

        [Fact]
        public void Test_Currency_WST_Properties()
        {
            Assert.Equal("WST", Currency.WST.LetterCode);
            Assert.Equal("882", Currency.WST.NumericCode);
            Assert.Equal("Tala", Currency.WST.Name);
            Assert.Equal(2, Currency.WST.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XAF_Properties()
        {
            Assert.Equal("XAF", Currency.XAF.LetterCode);
            Assert.Equal("950", Currency.XAF.NumericCode);
            Assert.Equal("CFA Franc BEAC", Currency.XAF.Name);
            Assert.Equal(0, Currency.XAF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XAG_Properties()
        {
            Assert.Equal("XAG", Currency.XAG.LetterCode);
            Assert.Equal("961", Currency.XAG.NumericCode);
            Assert.Equal("Silver", Currency.XAG.Name);
            Assert.Equal(0, Currency.XAG.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XAU_Properties()
        {
            Assert.Equal("XAU", Currency.XAU.LetterCode);
            Assert.Equal("959", Currency.XAU.NumericCode);
            Assert.Equal("Gold", Currency.XAU.Name);
            Assert.Equal(0, Currency.XAU.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XBA_Properties()
        {
            Assert.Equal("XBA", Currency.XBA.LetterCode);
            Assert.Equal("955", Currency.XBA.NumericCode);
            Assert.Equal("Bond Markets Unit European Composite Unit (EURCO)", Currency.XBA.Name);
            Assert.Equal(0, Currency.XBA.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XBB_Properties()
        {
            Assert.Equal("XBB", Currency.XBB.LetterCode);
            Assert.Equal("956", Currency.XBB.NumericCode);
            Assert.Equal("Bond Markets Unit European Monetary Unit (E.M.U.-6)", Currency.XBB.Name);
            Assert.Equal(0, Currency.XBB.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XBC_Properties()
        {
            Assert.Equal("XBC", Currency.XBC.LetterCode);
            Assert.Equal("957", Currency.XBC.NumericCode);
            Assert.Equal("Bond Markets Unit European Unit of Account 9 (E.U.A.-9)", Currency.XBC.Name);
            Assert.Equal(0, Currency.XBC.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XBD_Properties()
        {
            Assert.Equal("XBD", Currency.XBD.LetterCode);
            Assert.Equal("958", Currency.XBD.NumericCode);
            Assert.Equal("Bond Markets Unit European Unit of Account 17 (E.U.A.-17)", Currency.XBD.Name);
            Assert.Equal(0, Currency.XBD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XCD_Properties()
        {
            Assert.Equal("XCD", Currency.XCD.LetterCode);
            Assert.Equal("951", Currency.XCD.NumericCode);
            Assert.Equal("East Caribbean Dollar", Currency.XCD.Name);
            Assert.Equal(2, Currency.XCD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XDR_Properties()
        {
            Assert.Equal("XDR", Currency.XDR.LetterCode);
            Assert.Equal("960", Currency.XDR.NumericCode);
            Assert.Equal("SDR (Special Drawing Right)", Currency.XDR.Name);
            Assert.Equal(0, Currency.XDR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XOF_Properties()
        {
            Assert.Equal("XOF", Currency.XOF.LetterCode);
            Assert.Equal("952", Currency.XOF.NumericCode);
            Assert.Equal("CFA Franc BCEAO", Currency.XOF.Name);
            Assert.Equal(0, Currency.XOF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XPD_Properties()
        {
            Assert.Equal("XPD", Currency.XPD.LetterCode);
            Assert.Equal("964", Currency.XPD.NumericCode);
            Assert.Equal("Palladium", Currency.XPD.Name);
            Assert.Equal(0, Currency.XPD.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XPF_Properties()
        {
            Assert.Equal("XPF", Currency.XPF.LetterCode);
            Assert.Equal("953", Currency.XPF.NumericCode);
            Assert.Equal("CFP Franc", Currency.XPF.Name);
            Assert.Equal(0, Currency.XPF.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XPT_Properties()
        {
            Assert.Equal("XPT", Currency.XPT.LetterCode);
            Assert.Equal("962", Currency.XPT.NumericCode);
            Assert.Equal("Platinum", Currency.XPT.Name);
            Assert.Equal(0, Currency.XPT.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XSU_Properties()
        {
            Assert.Equal("XSU", Currency.XSU.LetterCode);
            Assert.Equal("994", Currency.XSU.NumericCode);
            Assert.Equal("Sucre", Currency.XSU.Name);
            Assert.Equal(0, Currency.XSU.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XTS_Properties()
        {
            Assert.Equal("XTS", Currency.XTS.LetterCode);
            Assert.Equal("963", Currency.XTS.NumericCode);
            Assert.Equal("Codes specifically reserved for testing purposes", Currency.XTS.Name);
            Assert.Equal(0, Currency.XTS.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XUA_Properties()
        {
            Assert.Equal("XUA", Currency.XUA.LetterCode);
            Assert.Equal("965", Currency.XUA.NumericCode);
            Assert.Equal("ADB Unit of Account", Currency.XUA.Name);
            Assert.Equal(0, Currency.XUA.MinorUnits);
        }

        [Fact]
        public void Test_Currency_XXX_Properties()
        {
            Assert.Equal("XXX", Currency.XXX.LetterCode);
            Assert.Equal("999", Currency.XXX.NumericCode);
            Assert.Equal("The codes assigned for transactions where no currency is involved", Currency.XXX.Name);
            Assert.Equal(0, Currency.XXX.MinorUnits);
        }

        [Fact]
        public void Test_Currency_YER_Properties()
        {
            Assert.Equal("YER", Currency.YER.LetterCode);
            Assert.Equal("886", Currency.YER.NumericCode);
            Assert.Equal("Yemeni Rial", Currency.YER.Name);
            Assert.Equal(2, Currency.YER.MinorUnits);
        }

        [Fact]
        public void Test_Currency_ZAR_Properties()
        {
            Assert.Equal("ZAR", Currency.ZAR.LetterCode);
            Assert.Equal("710", Currency.ZAR.NumericCode);
            Assert.Equal("Rand", Currency.ZAR.Name);
            Assert.Equal(2, Currency.ZAR.MinorUnits);
        }

        [Fact]
        public void Test_Currency_ZMW_Properties()
        {
            Assert.Equal("ZMW", Currency.ZMW.LetterCode);
            Assert.Equal("967", Currency.ZMW.NumericCode);
            Assert.Equal("Zambian Kwacha", Currency.ZMW.Name);
            Assert.Equal(2, Currency.ZMW.MinorUnits);
        }

        [Fact]
        public void Test_Currency_ZWL_Properties()
        {
            Assert.Equal("ZWL", Currency.ZWL.LetterCode);
            Assert.Equal("932", Currency.ZWL.NumericCode);
            Assert.Equal("Zimbabwe Dollar", Currency.ZWL.Name);
            Assert.Equal(2, Currency.ZWL.MinorUnits);
        }
    }
}