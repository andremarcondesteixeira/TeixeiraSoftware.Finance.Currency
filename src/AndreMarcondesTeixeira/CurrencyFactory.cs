namespace AndreMarcondesTeixeira
{
    public partial class Currency
    {
        private static Currency _AED;
        private static Currency _AFN;
        private static Currency _ALL;
        private static Currency _AMD;
        private static Currency _ANG;
        private static Currency _AOA;
        private static Currency _ARS;
        private static Currency _AUD;
        private static Currency _AWG;
        private static Currency _AZN;
        private static Currency _BAM;
        private static Currency _BBD;
        private static Currency _BDT;
        private static Currency _BGN;
        private static Currency _BHD;
        private static Currency _BIF;
        private static Currency _BMD;
        private static Currency _BND;
        private static Currency _BOB;
        private static Currency _BOV;
        private static Currency _BRL;
        private static Currency _BSD;
        private static Currency _BTN;
        private static Currency _BWP;
        private static Currency _BYN;
        private static Currency _BZD;
        private static Currency _CAD;
        private static Currency _CDF;
        private static Currency _CHE;
        private static Currency _CHF;
        private static Currency _CHW;
        private static Currency _CLF;
        private static Currency _CLP;
        private static Currency _CNY;
        private static Currency _COP;
        private static Currency _COU;
        private static Currency _CRC;
        private static Currency _CUC;
        private static Currency _CUP;
        private static Currency _CVE;
        private static Currency _CZK;
        private static Currency _DJF;
        private static Currency _DKK;
        private static Currency _DOP;
        private static Currency _DZD;
        private static Currency _EGP;
        private static Currency _ERN;
        private static Currency _ETB;
        private static Currency _EUR;
        private static Currency _FJD;
        private static Currency _FKP;
        private static Currency _GBP;
        private static Currency _GEL;
        private static Currency _GHS;
        private static Currency _GIP;
        private static Currency _GMD;
        private static Currency _GNF;
        private static Currency _GTQ;
        private static Currency _GYD;
        private static Currency _HKD;
        private static Currency _HNL;
        private static Currency _HRK;
        private static Currency _HTG;
        private static Currency _HUF;
        private static Currency _IDR;
        private static Currency _ILS;
        private static Currency _INR;
        private static Currency _IQD;
        private static Currency _IRR;
        private static Currency _ISK;
        private static Currency _JMD;
        private static Currency _JOD;
        private static Currency _JPY;
        private static Currency _KES;
        private static Currency _KGS;
        private static Currency _KHR;
        private static Currency _KMF;
        private static Currency _KPW;
        private static Currency _KRW;
        private static Currency _KWD;
        private static Currency _KYD;
        private static Currency _KZT;
        private static Currency _LAK;
        private static Currency _LBP;
        private static Currency _LKR;
        private static Currency _LRD;
        private static Currency _LSL;
        private static Currency _LYD;
        private static Currency _MAD;
        private static Currency _MDL;
        private static Currency _MGA;
        private static Currency _MKD;
        private static Currency _MMK;
        private static Currency _MNT;
        private static Currency _MOP;
        private static Currency _MRO;
        private static Currency _MUR;
        private static Currency _MVR;
        private static Currency _MWK;
        private static Currency _MXN;
        private static Currency _MXV;
        private static Currency _MYR;
        private static Currency _MZN;
        private static Currency _NAD;
        private static Currency _NGN;
        private static Currency _NIO;
        private static Currency _NOK;
        private static Currency _NPR;
        private static Currency _NZD;
        private static Currency _OMR;
        private static Currency _PAB;
        private static Currency _PEN;
        private static Currency _PGK;
        private static Currency _PHP;
        private static Currency _PKR;
        private static Currency _PLN;
        private static Currency _PYG;
        private static Currency _QAR;
        private static Currency _RON;
        private static Currency _RSD;
        private static Currency _RUB;
        private static Currency _RWF;
        private static Currency _SAR;
        private static Currency _SBD;
        private static Currency _SCR;
        private static Currency _SDG;
        private static Currency _SEK;
        private static Currency _SGD;
        private static Currency _SHP;
        private static Currency _SLL;
        private static Currency _SOS;
        private static Currency _SRD;
        private static Currency _SSP;
        private static Currency _STD;
        private static Currency _SVC;
        private static Currency _SYP;
        private static Currency _SZL;
        private static Currency _THB;
        private static Currency _TJS;
        private static Currency _TMT;
        private static Currency _TND;
        private static Currency _TOP;
        private static Currency _TRY;
        private static Currency _TTD;
        private static Currency _TWD;
        private static Currency _TZS;
        private static Currency _UAH;
        private static Currency _UGX;
        private static Currency _USD;
        private static Currency _USN;
        private static Currency _UYI;
        private static Currency _UYU;
        private static Currency _UZS;
        private static Currency _VEF;
        private static Currency _VND;
        private static Currency _VUV;
        private static Currency _WST;
        private static Currency _XAF;
        private static Currency _XAG;
        private static Currency _XAU;
        private static Currency _XBA;
        private static Currency _XBB;
        private static Currency _XBC;
        private static Currency _XBD;
        private static Currency _XCD;
        private static Currency _XDR;
        private static Currency _XOF;
        private static Currency _XPD;
        private static Currency _XPF;
        private static Currency _XPT;
        private static Currency _XSU;
        private static Currency _XTS;
        private static Currency _XUA;
        private static Currency _XXX;
        private static Currency _YER;
        private static Currency _ZAR;
        private static Currency _ZMW;
        private static Currency _ZWL;

        public static Currency AED
        {
            get
            {
                return _AED ?? (_AED = new Currency("AED", "784", 2, "UAE Dirham"));
            }
        }

        public static Currency AFN
        {
            get
            {
                return _AFN ?? (_AFN = new Currency("AFN", "971", 2, "Afghani"));
            }
        }

        public static Currency ALL
        {
            get
            {
                return _ALL ?? (_ALL = new Currency("ALL", "008", 2, "Lek"));
            }
        }

        public static Currency AMD
        {
            get
            {
                return _AMD ?? (_AMD = new Currency("AMD", "051", 2, "Armenian Dram"));
            }
        }

        public static Currency ANG
        {
            get
            {
                return _ANG ?? (_ANG = new Currency("ANG", "532", 2, "Netherlands Antillean Guilder"));
            }
        }

        public static Currency AOA
        {
            get
            {
                return _AOA ?? (_AOA = new Currency("AOA", "973", 2, "Kwanza"));
            }
        }

        public static Currency ARS
        {
            get
            {
                return _ARS ?? (_ARS = new Currency("ARS", "032", 2, "Argentine Peso"));
            }
        }

        public static Currency AUD
        {
            get
            {
                return _AUD ?? (_AUD = new Currency("AUD", "036", 2, "Australian Dollar"));
            }
        }

        public static Currency AWG
        {
            get
            {
                return _AWG ?? (_AWG = new Currency("AWG", "533", 2, "Aruban Florin"));
            }
        }

        public static Currency AZN
        {
            get
            {
                return _AZN ?? (_AZN = new Currency("AZN", "944", 2, "Azerbaijanian Manat"));
            }
        }

        public static Currency BAM
        {
            get
            {
                return _BAM ?? (_BAM = new Currency("BAM", "977", 2, "Convertible Mark"));
            }
        }

        public static Currency BBD
        {
            get
            {
                return _BBD ?? (_BBD = new Currency("BBD", "052", 2, "Barbados Dollar"));
            }
        }

        public static Currency BDT
        {
            get
            {
                return _BDT ?? (_BDT = new Currency("BDT", "050", 2, "Taka"));
            }
        }

        public static Currency BGN
        {
            get
            {
                return _BGN ?? (_BGN = new Currency("BGN", "975", 2, "Bulgarian Lev"));
            }
        }

        public static Currency BHD
        {
            get
            {
                return _BHD ?? (_BHD = new Currency("BHD", "048", 3, "Bahraini Dinar"));
            }
        }

        public static Currency BIF
        {
            get
            {
                return _BIF ?? (_BIF = new Currency("BIF", "108", 0, "Burundi Franc"));
            }
        }

        public static Currency BMD
        {
            get
            {
                return _BMD ?? (_BMD = new Currency("BMD", "060", 2, "Bermudian Dollar"));
            }
        }

        public static Currency BND
        {
            get
            {
                return _BND ?? (_BND = new Currency("BND", "096", 2, "Brunei Dollar"));
            }
        }

        public static Currency BOB
        {
            get
            {
                return _BOB ?? (_BOB = new Currency("BOB", "068", 2, "Boliviano"));
            }
        }

        public static Currency BOV
        {
            get
            {
                return _BOV ?? (_BOV = new Currency("BOV", "984", 2, "[object Object]"));
            }
        }

        public static Currency BRL
        {
            get
            {
                return _BRL ?? (_BRL = new Currency("BRL", "986", 2, "Brazilian Real"));
            }
        }

        public static Currency BSD
        {
            get
            {
                return _BSD ?? (_BSD = new Currency("BSD", "044", 2, "Bahamian Dollar"));
            }
        }

        public static Currency BTN
        {
            get
            {
                return _BTN ?? (_BTN = new Currency("BTN", "064", 2, "Ngultrum"));
            }
        }

        public static Currency BWP
        {
            get
            {
                return _BWP ?? (_BWP = new Currency("BWP", "072", 2, "Pula"));
            }
        }

        public static Currency BYN
        {
            get
            {
                return _BYN ?? (_BYN = new Currency("BYN", "933", 2, "Belarusian Ruble"));
            }
        }

        public static Currency BZD
        {
            get
            {
                return _BZD ?? (_BZD = new Currency("BZD", "084", 2, "Belize Dollar"));
            }
        }

        public static Currency CAD
        {
            get
            {
                return _CAD ?? (_CAD = new Currency("CAD", "124", 2, "Canadian Dollar"));
            }
        }

        public static Currency CDF
        {
            get
            {
                return _CDF ?? (_CDF = new Currency("CDF", "976", 2, "Congolese Franc"));
            }
        }

        public static Currency CHE
        {
            get
            {
                return _CHE ?? (_CHE = new Currency("CHE", "947", 2, "[object Object]"));
            }
        }

        public static Currency CHF
        {
            get
            {
                return _CHF ?? (_CHF = new Currency("CHF", "756", 2, "Swiss Franc"));
            }
        }

        public static Currency CHW
        {
            get
            {
                return _CHW ?? (_CHW = new Currency("CHW", "948", 2, "[object Object]"));
            }
        }

        public static Currency CLF
        {
            get
            {
                return _CLF ?? (_CLF = new Currency("CLF", "990", 4, "[object Object]"));
            }
        }

        public static Currency CLP
        {
            get
            {
                return _CLP ?? (_CLP = new Currency("CLP", "152", 0, "Chilean Peso"));
            }
        }

        public static Currency CNY
        {
            get
            {
                return _CNY ?? (_CNY = new Currency("CNY", "156", 2, "Yuan Renminbi"));
            }
        }

        public static Currency COP
        {
            get
            {
                return _COP ?? (_COP = new Currency("COP", "170", 2, "Colombian Peso"));
            }
        }

        public static Currency COU
        {
            get
            {
                return _COU ?? (_COU = new Currency("COU", "970", 2, "[object Object]"));
            }
        }

        public static Currency CRC
        {
            get
            {
                return _CRC ?? (_CRC = new Currency("CRC", "188", 2, "Costa Rican Colon"));
            }
        }

        public static Currency CUC
        {
            get
            {
                return _CUC ?? (_CUC = new Currency("CUC", "931", 2, "Peso Convertible"));
            }
        }

        public static Currency CUP
        {
            get
            {
                return _CUP ?? (_CUP = new Currency("CUP", "192", 2, "Cuban Peso"));
            }
        }

        public static Currency CVE
        {
            get
            {
                return _CVE ?? (_CVE = new Currency("CVE", "132", 2, "Cabo Verde Escudo"));
            }
        }

        public static Currency CZK
        {
            get
            {
                return _CZK ?? (_CZK = new Currency("CZK", "203", 2, "Czech Koruna"));
            }
        }

        public static Currency DJF
        {
            get
            {
                return _DJF ?? (_DJF = new Currency("DJF", "262", 0, "Djibouti Franc"));
            }
        }

        public static Currency DKK
        {
            get
            {
                return _DKK ?? (_DKK = new Currency("DKK", "208", 2, "Danish Krone"));
            }
        }

        public static Currency DOP
        {
            get
            {
                return _DOP ?? (_DOP = new Currency("DOP", "214", 2, "Dominican Peso"));
            }
        }

        public static Currency DZD
        {
            get
            {
                return _DZD ?? (_DZD = new Currency("DZD", "012", 2, "Algerian Dinar"));
            }
        }

        public static Currency EGP
        {
            get
            {
                return _EGP ?? (_EGP = new Currency("EGP", "818", 2, "Egyptian Pound"));
            }
        }

        public static Currency ERN
        {
            get
            {
                return _ERN ?? (_ERN = new Currency("ERN", "232", 2, "Nakfa"));
            }
        }

        public static Currency ETB
        {
            get
            {
                return _ETB ?? (_ETB = new Currency("ETB", "230", 2, "Ethiopian Birr"));
            }
        }

        public static Currency EUR
        {
            get
            {
                return _EUR ?? (_EUR = new Currency("EUR", "978", 2, "Euro"));
            }
        }

        public static Currency FJD
        {
            get
            {
                return _FJD ?? (_FJD = new Currency("FJD", "242", 2, "Fiji Dollar"));
            }
        }

        public static Currency FKP
        {
            get
            {
                return _FKP ?? (_FKP = new Currency("FKP", "238", 2, "Falkland Islands Pound"));
            }
        }

        public static Currency GBP
        {
            get
            {
                return _GBP ?? (_GBP = new Currency("GBP", "826", 2, "Pound Sterling"));
            }
        }

        public static Currency GEL
        {
            get
            {
                return _GEL ?? (_GEL = new Currency("GEL", "981", 2, "Lari"));
            }
        }

        public static Currency GHS
        {
            get
            {
                return _GHS ?? (_GHS = new Currency("GHS", "936", 2, "Ghana Cedi"));
            }
        }

        public static Currency GIP
        {
            get
            {
                return _GIP ?? (_GIP = new Currency("GIP", "292", 2, "Gibraltar Pound"));
            }
        }

        public static Currency GMD
        {
            get
            {
                return _GMD ?? (_GMD = new Currency("GMD", "270", 2, "Dalasi"));
            }
        }

        public static Currency GNF
        {
            get
            {
                return _GNF ?? (_GNF = new Currency("GNF", "324", 0, "Guinea Franc"));
            }
        }

        public static Currency GTQ
        {
            get
            {
                return _GTQ ?? (_GTQ = new Currency("GTQ", "320", 2, "Quetzal"));
            }
        }

        public static Currency GYD
        {
            get
            {
                return _GYD ?? (_GYD = new Currency("GYD", "328", 2, "Guyana Dollar"));
            }
        }

        public static Currency HKD
        {
            get
            {
                return _HKD ?? (_HKD = new Currency("HKD", "344", 2, "Hong Kong Dollar"));
            }
        }

        public static Currency HNL
        {
            get
            {
                return _HNL ?? (_HNL = new Currency("HNL", "340", 2, "Lempira"));
            }
        }

        public static Currency HRK
        {
            get
            {
                return _HRK ?? (_HRK = new Currency("HRK", "191", 2, "Kuna"));
            }
        }

        public static Currency HTG
        {
            get
            {
                return _HTG ?? (_HTG = new Currency("HTG", "332", 2, "Gourde"));
            }
        }

        public static Currency HUF
        {
            get
            {
                return _HUF ?? (_HUF = new Currency("HUF", "348", 2, "Forint"));
            }
        }

        public static Currency IDR
        {
            get
            {
                return _IDR ?? (_IDR = new Currency("IDR", "360", 2, "Rupiah"));
            }
        }

        public static Currency ILS
        {
            get
            {
                return _ILS ?? (_ILS = new Currency("ILS", "376", 2, "New Israeli Sheqel"));
            }
        }

        public static Currency INR
        {
            get
            {
                return _INR ?? (_INR = new Currency("INR", "356", 2, "Indian Rupee"));
            }
        }

        public static Currency IQD
        {
            get
            {
                return _IQD ?? (_IQD = new Currency("IQD", "368", 3, "Iraqi Dinar"));
            }
        }

        public static Currency IRR
        {
            get
            {
                return _IRR ?? (_IRR = new Currency("IRR", "364", 2, "Iranian Rial"));
            }
        }

        public static Currency ISK
        {
            get
            {
                return _ISK ?? (_ISK = new Currency("ISK", "352", 0, "Iceland Krona"));
            }
        }

        public static Currency JMD
        {
            get
            {
                return _JMD ?? (_JMD = new Currency("JMD", "388", 2, "Jamaican Dollar"));
            }
        }

        public static Currency JOD
        {
            get
            {
                return _JOD ?? (_JOD = new Currency("JOD", "400", 3, "Jordanian Dinar"));
            }
        }

        public static Currency JPY
        {
            get
            {
                return _JPY ?? (_JPY = new Currency("JPY", "392", 0, "Yen"));
            }
        }

        public static Currency KES
        {
            get
            {
                return _KES ?? (_KES = new Currency("KES", "404", 2, "Kenyan Shilling"));
            }
        }

        public static Currency KGS
        {
            get
            {
                return _KGS ?? (_KGS = new Currency("KGS", "417", 2, "Som"));
            }
        }

        public static Currency KHR
        {
            get
            {
                return _KHR ?? (_KHR = new Currency("KHR", "116", 2, "Riel"));
            }
        }

        public static Currency KMF
        {
            get
            {
                return _KMF ?? (_KMF = new Currency("KMF", "174", 0, "Comoro Franc"));
            }
        }

        public static Currency KPW
        {
            get
            {
                return _KPW ?? (_KPW = new Currency("KPW", "408", 2, "North Korean Won"));
            }
        }

        public static Currency KRW
        {
            get
            {
                return _KRW ?? (_KRW = new Currency("KRW", "410", 0, "Won"));
            }
        }

        public static Currency KWD
        {
            get
            {
                return _KWD ?? (_KWD = new Currency("KWD", "414", 3, "Kuwaiti Dinar"));
            }
        }

        public static Currency KYD
        {
            get
            {
                return _KYD ?? (_KYD = new Currency("KYD", "136", 2, "Cayman Islands Dollar"));
            }
        }

        public static Currency KZT
        {
            get
            {
                return _KZT ?? (_KZT = new Currency("KZT", "398", 2, "Tenge"));
            }
        }

        public static Currency LAK
        {
            get
            {
                return _LAK ?? (_LAK = new Currency("LAK", "418", 2, "Kip"));
            }
        }

        public static Currency LBP
        {
            get
            {
                return _LBP ?? (_LBP = new Currency("LBP", "422", 2, "Lebanese Pound"));
            }
        }

        public static Currency LKR
        {
            get
            {
                return _LKR ?? (_LKR = new Currency("LKR", "144", 2, "Sri Lanka Rupee"));
            }
        }

        public static Currency LRD
        {
            get
            {
                return _LRD ?? (_LRD = new Currency("LRD", "430", 2, "Liberian Dollar"));
            }
        }

        public static Currency LSL
        {
            get
            {
                return _LSL ?? (_LSL = new Currency("LSL", "426", 2, "Loti"));
            }
        }

        public static Currency LYD
        {
            get
            {
                return _LYD ?? (_LYD = new Currency("LYD", "434", 3, "Libyan Dinar"));
            }
        }

        public static Currency MAD
        {
            get
            {
                return _MAD ?? (_MAD = new Currency("MAD", "504", 2, "Moroccan Dirham"));
            }
        }

        public static Currency MDL
        {
            get
            {
                return _MDL ?? (_MDL = new Currency("MDL", "498", 2, "Moldovan Leu"));
            }
        }

        public static Currency MGA
        {
            get
            {
                return _MGA ?? (_MGA = new Currency("MGA", "969", 2, "Malagasy Ariary"));
            }
        }

        public static Currency MKD
        {
            get
            {
                return _MKD ?? (_MKD = new Currency("MKD", "807", 2, "Denar"));
            }
        }

        public static Currency MMK
        {
            get
            {
                return _MMK ?? (_MMK = new Currency("MMK", "104", 2, "Kyat"));
            }
        }

        public static Currency MNT
        {
            get
            {
                return _MNT ?? (_MNT = new Currency("MNT", "496", 2, "Tugrik"));
            }
        }

        public static Currency MOP
        {
            get
            {
                return _MOP ?? (_MOP = new Currency("MOP", "446", 2, "Pataca"));
            }
        }

        public static Currency MRO
        {
            get
            {
                return _MRO ?? (_MRO = new Currency("MRO", "478", 2, "Ouguiya"));
            }
        }

        public static Currency MUR
        {
            get
            {
                return _MUR ?? (_MUR = new Currency("MUR", "480", 2, "Mauritius Rupee"));
            }
        }

        public static Currency MVR
        {
            get
            {
                return _MVR ?? (_MVR = new Currency("MVR", "462", 2, "Rufiyaa"));
            }
        }

        public static Currency MWK
        {
            get
            {
                return _MWK ?? (_MWK = new Currency("MWK", "454", 2, "Malawi Kwacha"));
            }
        }

        public static Currency MXN
        {
            get
            {
                return _MXN ?? (_MXN = new Currency("MXN", "484", 2, "Mexican Peso"));
            }
        }

        public static Currency MXV
        {
            get
            {
                return _MXV ?? (_MXV = new Currency("MXV", "979", 2, "[object Object]"));
            }
        }

        public static Currency MYR
        {
            get
            {
                return _MYR ?? (_MYR = new Currency("MYR", "458", 2, "Malaysian Ringgit"));
            }
        }

        public static Currency MZN
        {
            get
            {
                return _MZN ?? (_MZN = new Currency("MZN", "943", 2, "Mozambique Metical"));
            }
        }

        public static Currency NAD
        {
            get
            {
                return _NAD ?? (_NAD = new Currency("NAD", "516", 2, "Namibia Dollar"));
            }
        }

        public static Currency NGN
        {
            get
            {
                return _NGN ?? (_NGN = new Currency("NGN", "566", 2, "Naira"));
            }
        }

        public static Currency NIO
        {
            get
            {
                return _NIO ?? (_NIO = new Currency("NIO", "558", 2, "Cordoba Oro"));
            }
        }

        public static Currency NOK
        {
            get
            {
                return _NOK ?? (_NOK = new Currency("NOK", "578", 2, "Norwegian Krone"));
            }
        }

        public static Currency NPR
        {
            get
            {
                return _NPR ?? (_NPR = new Currency("NPR", "524", 2, "Nepalese Rupee"));
            }
        }

        public static Currency NZD
        {
            get
            {
                return _NZD ?? (_NZD = new Currency("NZD", "554", 2, "New Zealand Dollar"));
            }
        }

        public static Currency OMR
        {
            get
            {
                return _OMR ?? (_OMR = new Currency("OMR", "512", 3, "Rial Omani"));
            }
        }

        public static Currency PAB
        {
            get
            {
                return _PAB ?? (_PAB = new Currency("PAB", "590", 2, "Balboa"));
            }
        }

        public static Currency PEN
        {
            get
            {
                return _PEN ?? (_PEN = new Currency("PEN", "604", 2, "Sol"));
            }
        }

        public static Currency PGK
        {
            get
            {
                return _PGK ?? (_PGK = new Currency("PGK", "598", 2, "Kina"));
            }
        }

        public static Currency PHP
        {
            get
            {
                return _PHP ?? (_PHP = new Currency("PHP", "608", 2, "Philippine Peso"));
            }
        }

        public static Currency PKR
        {
            get
            {
                return _PKR ?? (_PKR = new Currency("PKR", "586", 2, "Pakistan Rupee"));
            }
        }

        public static Currency PLN
        {
            get
            {
                return _PLN ?? (_PLN = new Currency("PLN", "985", 2, "Zloty"));
            }
        }

        public static Currency PYG
        {
            get
            {
                return _PYG ?? (_PYG = new Currency("PYG", "600", 0, "Guarani"));
            }
        }

        public static Currency QAR
        {
            get
            {
                return _QAR ?? (_QAR = new Currency("QAR", "634", 2, "Qatari Rial"));
            }
        }

        public static Currency RON
        {
            get
            {
                return _RON ?? (_RON = new Currency("RON", "946", 2, "Romanian Leu"));
            }
        }

        public static Currency RSD
        {
            get
            {
                return _RSD ?? (_RSD = new Currency("RSD", "941", 2, "Serbian Dinar"));
            }
        }

        public static Currency RUB
        {
            get
            {
                return _RUB ?? (_RUB = new Currency("RUB", "643", 2, "Russian Ruble"));
            }
        }

        public static Currency RWF
        {
            get
            {
                return _RWF ?? (_RWF = new Currency("RWF", "646", 0, "Rwanda Franc"));
            }
        }

        public static Currency SAR
        {
            get
            {
                return _SAR ?? (_SAR = new Currency("SAR", "682", 2, "Saudi Riyal"));
            }
        }

        public static Currency SBD
        {
            get
            {
                return _SBD ?? (_SBD = new Currency("SBD", "090", 2, "Solomon Islands Dollar"));
            }
        }

        public static Currency SCR
        {
            get
            {
                return _SCR ?? (_SCR = new Currency("SCR", "690", 2, "Seychelles Rupee"));
            }
        }

        public static Currency SDG
        {
            get
            {
                return _SDG ?? (_SDG = new Currency("SDG", "938", 2, "Sudanese Pound"));
            }
        }

        public static Currency SEK
        {
            get
            {
                return _SEK ?? (_SEK = new Currency("SEK", "752", 2, "Swedish Krona"));
            }
        }

        public static Currency SGD
        {
            get
            {
                return _SGD ?? (_SGD = new Currency("SGD", "702", 2, "Singapore Dollar"));
            }
        }

        public static Currency SHP
        {
            get
            {
                return _SHP ?? (_SHP = new Currency("SHP", "654", 2, "Saint Helena Pound"));
            }
        }

        public static Currency SLL
        {
            get
            {
                return _SLL ?? (_SLL = new Currency("SLL", "694", 2, "Leone"));
            }
        }

        public static Currency SOS
        {
            get
            {
                return _SOS ?? (_SOS = new Currency("SOS", "706", 2, "Somali Shilling"));
            }
        }

        public static Currency SRD
        {
            get
            {
                return _SRD ?? (_SRD = new Currency("SRD", "968", 2, "Surinam Dollar"));
            }
        }

        public static Currency SSP
        {
            get
            {
                return _SSP ?? (_SSP = new Currency("SSP", "728", 2, "South Sudanese Pound"));
            }
        }

        public static Currency STD
        {
            get
            {
                return _STD ?? (_STD = new Currency("STD", "678", 2, "Dobra"));
            }
        }

        public static Currency SVC
        {
            get
            {
                return _SVC ?? (_SVC = new Currency("SVC", "222", 2, "El Salvador Colon"));
            }
        }

        public static Currency SYP
        {
            get
            {
                return _SYP ?? (_SYP = new Currency("SYP", "760", 2, "Syrian Pound"));
            }
        }

        public static Currency SZL
        {
            get
            {
                return _SZL ?? (_SZL = new Currency("SZL", "748", 2, "Lilangeni"));
            }
        }

        public static Currency THB
        {
            get
            {
                return _THB ?? (_THB = new Currency("THB", "764", 2, "Baht"));
            }
        }

        public static Currency TJS
        {
            get
            {
                return _TJS ?? (_TJS = new Currency("TJS", "972", 2, "Somoni"));
            }
        }

        public static Currency TMT
        {
            get
            {
                return _TMT ?? (_TMT = new Currency("TMT", "934", 2, "Turkmenistan New Manat"));
            }
        }

        public static Currency TND
        {
            get
            {
                return _TND ?? (_TND = new Currency("TND", "788", 3, "Tunisian Dinar"));
            }
        }

        public static Currency TOP
        {
            get
            {
                return _TOP ?? (_TOP = new Currency("TOP", "776", 2, "Pa’anga"));
            }
        }

        public static Currency TRY
        {
            get
            {
                return _TRY ?? (_TRY = new Currency("TRY", "949", 2, "Turkish Lira"));
            }
        }

        public static Currency TTD
        {
            get
            {
                return _TTD ?? (_TTD = new Currency("TTD", "780", 2, "Trinidad and Tobago Dollar"));
            }
        }

        public static Currency TWD
        {
            get
            {
                return _TWD ?? (_TWD = new Currency("TWD", "901", 2, "New Taiwan Dollar"));
            }
        }

        public static Currency TZS
        {
            get
            {
                return _TZS ?? (_TZS = new Currency("TZS", "834", 2, "Tanzanian Shilling"));
            }
        }

        public static Currency UAH
        {
            get
            {
                return _UAH ?? (_UAH = new Currency("UAH", "980", 2, "Hryvnia"));
            }
        }

        public static Currency UGX
        {
            get
            {
                return _UGX ?? (_UGX = new Currency("UGX", "800", 0, "Uganda Shilling"));
            }
        }

        public static Currency USD
        {
            get
            {
                return _USD ?? (_USD = new Currency("USD", "840", 2, "US Dollar"));
            }
        }

        public static Currency USN
        {
            get
            {
                return _USN ?? (_USN = new Currency("USN", "997", 2, "[object Object]"));
            }
        }

        public static Currency UYI
        {
            get
            {
                return _UYI ?? (_UYI = new Currency("UYI", "940", 0, "[object Object]"));
            }
        }

        public static Currency UYU
        {
            get
            {
                return _UYU ?? (_UYU = new Currency("UYU", "858", 2, "Peso Uruguayo"));
            }
        }

        public static Currency UZS
        {
            get
            {
                return _UZS ?? (_UZS = new Currency("UZS", "860", 2, "Uzbekistan Sum"));
            }
        }

        public static Currency VEF
        {
            get
            {
                return _VEF ?? (_VEF = new Currency("VEF", "937", 2, "Bolívar"));
            }
        }

        public static Currency VND
        {
            get
            {
                return _VND ?? (_VND = new Currency("VND", "704", 0, "Dong"));
            }
        }

        public static Currency VUV
        {
            get
            {
                return _VUV ?? (_VUV = new Currency("VUV", "548", 0, "Vatu"));
            }
        }

        public static Currency WST
        {
            get
            {
                return _WST ?? (_WST = new Currency("WST", "882", 2, "Tala"));
            }
        }

        public static Currency XAF
        {
            get
            {
                return _XAF ?? (_XAF = new Currency("XAF", "950", 0, "CFA Franc BEAC"));
            }
        }

        public static Currency XAG
        {
            get
            {
                return _XAG ?? (_XAG = new Currency("XAG", "961", 0, "Silver"));
            }
        }

        public static Currency XAU
        {
            get
            {
                return _XAU ?? (_XAU = new Currency("XAU", "959", 0, "Gold"));
            }
        }

        public static Currency XBA
        {
            get
            {
                return _XBA ?? (_XBA = new Currency("XBA", "955", 0, "Bond Markets Unit European Composite Unit (EURCO)"));
            }
        }

        public static Currency XBB
        {
            get
            {
                return _XBB ?? (_XBB = new Currency("XBB", "956", 0, "Bond Markets Unit European Monetary Unit (E.M.U.-6)"));
            }
        }

        public static Currency XBC
        {
            get
            {
                return _XBC ?? (_XBC = new Currency("XBC", "957", 0, "Bond Markets Unit European Unit of Account 9 (E.U.A.-9)"));
            }
        }

        public static Currency XBD
        {
            get
            {
                return _XBD ?? (_XBD = new Currency("XBD", "958", 0, "Bond Markets Unit European Unit of Account 17 (E.U.A.-17)"));
            }
        }

        public static Currency XCD
        {
            get
            {
                return _XCD ?? (_XCD = new Currency("XCD", "951", 2, "East Caribbean Dollar"));
            }
        }

        public static Currency XDR
        {
            get
            {
                return _XDR ?? (_XDR = new Currency("XDR", "960", 0, "SDR (Special Drawing Right)"));
            }
        }

        public static Currency XOF
        {
            get
            {
                return _XOF ?? (_XOF = new Currency("XOF", "952", 0, "CFA Franc BCEAO"));
            }
        }

        public static Currency XPD
        {
            get
            {
                return _XPD ?? (_XPD = new Currency("XPD", "964", 0, "Palladium"));
            }
        }

        public static Currency XPF
        {
            get
            {
                return _XPF ?? (_XPF = new Currency("XPF", "953", 0, "CFP Franc"));
            }
        }

        public static Currency XPT
        {
            get
            {
                return _XPT ?? (_XPT = new Currency("XPT", "962", 0, "Platinum"));
            }
        }

        public static Currency XSU
        {
            get
            {
                return _XSU ?? (_XSU = new Currency("XSU", "994", 0, "Sucre"));
            }
        }

        public static Currency XTS
        {
            get
            {
                return _XTS ?? (_XTS = new Currency("XTS", "963", 0, "Codes specifically reserved for testing purposes"));
            }
        }

        public static Currency XUA
        {
            get
            {
                return _XUA ?? (_XUA = new Currency("XUA", "965", 0, "ADB Unit of Account"));
            }
        }

        public static Currency XXX
        {
            get
            {
                return _XXX ?? (_XXX = new Currency("XXX", "999", 0, "The codes assigned for transactions where no currency is involved"));
            }
        }

        public static Currency YER
        {
            get
            {
                return _YER ?? (_YER = new Currency("YER", "886", 2, "Yemeni Rial"));
            }
        }

        public static Currency ZAR
        {
            get
            {
                return _ZAR ?? (_ZAR = new Currency("ZAR", "710", 2, "Rand"));
            }
        }

        public static Currency ZMW
        {
            get
            {
                return _ZMW ?? (_ZMW = new Currency("ZMW", "967", 2, "Zambian Kwacha"));
            }
        }

        public static Currency ZWL
        {
            get
            {
                return _ZWL ?? (_ZWL = new Currency("ZWL", "932", 2, "Zimbabwe Dollar"));
            }
        }
    }
}