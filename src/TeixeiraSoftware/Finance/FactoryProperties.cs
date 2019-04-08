using System;

namespace TeixeiraSoftware.Finance
{
    public partial struct Currency : ICurrency, IComparable, IComparable<ICurrency>
    {
        /// <summary>UAE Dirham</summary>
        public static Currency AED
        {
            get
            {
                return new Currency("AED", "784", 2, "د.إ", "UAE Dirham");
            }
        }

        /// <summary>Afghani</summary>
        public static Currency AFN
        {
            get
            {
                return new Currency("AFN", "971", 2, "	Af", "Afghani");
            }
        }

        /// <summary>Lek</summary>
        public static Currency ALL
        {
            get
            {
                return new Currency("ALL", "008", 2, "L", "Lek");
            }
        }

        /// <summary>Armenian Dram</summary>
        public static Currency AMD
        {
            get
            {
                return new Currency("AMD", "051", 2, "Դ", "Armenian Dram");
            }
        }

        /// <summary>Netherlands Antillean Guilder</summary>
        public static Currency ANG
        {
            get
            {
                return new Currency("ANG", "532", 2, "ƒ", "Netherlands Antillean Guilder");
            }
        }

        /// <summary>Kwanza</summary>
        public static Currency AOA
        {
            get
            {
                return new Currency("AOA", "973", 2, "Kz", "Kwanza");
            }
        }

        /// <summary>Argentine Peso</summary>
        public static Currency ARS
        {
            get
            {
                return new Currency("ARS", "032", 2, "$", "Argentine Peso");
            }
        }

        /// <summary>Australian Dollar</summary>
        public static Currency AUD
        {
            get
            {
                return new Currency("AUD", "036", 2, "$", "Australian Dollar");
            }
        }

        /// <summary>Aruban Florin</summary>
        public static Currency AWG
        {
            get
            {
                return new Currency("AWG", "533", 2, "ƒ", "Aruban Florin");
            }
        }

        /// <summary>Azerbaijanian Manat</summary>
        public static Currency AZN
        {
            get
            {
                return new Currency("AZN", "944", 2, "ман", "Azerbaijanian Manat");
            }
        }

        /// <summary>Convertible Mark</summary>
        public static Currency BAM
        {
            get
            {
                return new Currency("BAM", "977", 2, "KM", "Convertible Mark");
            }
        }

        /// <summary>Barbados Dollar</summary>
        public static Currency BBD
        {
            get
            {
                return new Currency("BBD", "052", 2, "$", "Barbados Dollar");
            }
        }

        /// <summary>Taka</summary>
        public static Currency BDT
        {
            get
            {
                return new Currency("BDT", "050", 2, "৳	", "Taka");
            }
        }

        /// <summary>Bulgarian Lev</summary>
        public static Currency BGN
        {
            get
            {
                return new Currency("BGN", "975", 2, "лв", "Bulgarian Lev");
            }
        }

        /// <summary>Bahraini Dinar</summary>
        public static Currency BHD
        {
            get
            {
                return new Currency("BHD", "048", 3, "ب.د	", "Bahraini Dinar");
            }
        }

        /// <summary>Burundi Franc</summary>
        public static Currency BIF
        {
            get
            {
                return new Currency("BIF", "108", 0, "₣", "Burundi Franc");
            }
        }

        /// <summary>Bermudian Dollar</summary>
        public static Currency BMD
        {
            get
            {
                return new Currency("BMD", "060", 2, "$", "Bermudian Dollar");
            }
        }

        /// <summary>Brunei Dollar</summary>
        public static Currency BND
        {
            get
            {
                return new Currency("BND", "096", 2, "$", "Brunei Dollar");
            }
        }

        /// <summary>Boliviano</summary>
        public static Currency BOB
        {
            get
            {
                return new Currency("BOB", "068", 2, "Bs.", "Boliviano");
            }
        }

        /// <summary>Mvdol</summary>
        public static Currency BOV
        {
            get
            {
                return new Currency("BOV", "984", 2, null, "Mvdol");
            }
        }

        /// <summary>Brazilian Real</summary>
        public static Currency BRL
        {
            get
            {
                return new Currency("BRL", "986", 2, "R$", "Brazilian Real");
            }
        }

        /// <summary>Bahamian Dollar</summary>
        public static Currency BSD
        {
            get
            {
                return new Currency("BSD", "044", 2, "$", "Bahamian Dollar");
            }
        }

        /// <summary>Ngultrum</summary>
        public static Currency BTN
        {
            get
            {
                return new Currency("BTN", "064", 2, "", "Ngultrum");
            }
        }

        /// <summary>Pula</summary>
        public static Currency BWP
        {
            get
            {
                return new Currency("BWP", "072", 2, "P", "Pula");
            }
        }

        /// <summary>Belarusian Ruble</summary>
        public static Currency BYN
        {
            get
            {
                return new Currency("BYN", "933", 2, "Br", "Belarusian Ruble");
            }
        }

        /// <summary>Belize Dollar</summary>
        public static Currency BZD
        {
            get
            {
                return new Currency("BZD", "084", 2, "$", "Belize Dollar");
            }
        }

        /// <summary>Canadian Dollar</summary>
        public static Currency CAD
        {
            get
            {
                return new Currency("CAD", "124", 2, "$", "Canadian Dollar");
            }
        }

        /// <summary>Congolese Franc</summary>
        public static Currency CDF
        {
            get
            {
                return new Currency("CDF", "976", 2, "₣", "Congolese Franc");
            }
        }

        /// <summary>WIR Euro</summary>
        public static Currency CHE
        {
            get
            {
                return new Currency("CHE", "947", 2, "", "WIR Euro");
            }
        }

        /// <summary>Swiss Franc</summary>
        public static Currency CHF
        {
            get
            {
                return new Currency("CHF", "756", 2, "₣", "Swiss Franc");
            }
        }

        /// <summary>WIR Franc</summary>
        public static Currency CHW
        {
            get
            {
                return new Currency("CHW", "948", 2, null, "WIR Franc");
            }
        }

        /// <summary>Unidad de Fomento</summary>
        public static Currency CLF
        {
            get
            {
                return new Currency("CLF", "990", 4, "UF", "Unidad de Fomento");
            }
        }

        /// <summary>Chilean Peso</summary>
        public static Currency CLP
        {
            get
            {
                return new Currency("CLP", "152", 0, "$", "Chilean Peso");
            }
        }

        /// <summary>Yuan Renminbi</summary>
        public static Currency CNY
        {
            get
            {
                return new Currency("CNY", "156", 2, "¥", "Yuan Renminbi");
            }
        }

        /// <summary>Colombian Peso</summary>
        public static Currency COP
        {
            get
            {
                return new Currency("COP", "170", 2, "$", "Colombian Peso");
            }
        }

        /// <summary>Unidad de Valor Real</summary>
        public static Currency COU
        {
            get
            {
                return new Currency("COU", "970", 2, null, "Unidad de Valor Real");
            }
        }

        /// <summary>Costa Rican Colon</summary>
        public static Currency CRC
        {
            get
            {
                return new Currency("CRC", "188", 2, "₡", "Costa Rican Colon");
            }
        }

        /// <summary>Peso Convertible</summary>
        public static Currency CUC
        {
            get
            {
                return new Currency("CUC", "931", 2, null, "Peso Convertible");
            }
        }

        /// <summary>Cuban Peso</summary>
        public static Currency CUP
        {
            get
            {
                return new Currency("CUP", "192", 2, "$", "Cuban Peso");
            }
        }

        /// <summary>Cabo Verde Escudo</summary>
        public static Currency CVE
        {
            get
            {
                return new Currency("CVE", "132", 2, "$", "Cabo Verde Escudo");
            }
        }

        /// <summary>Czech Koruna</summary>
        public static Currency CZK
        {
            get
            {
                return new Currency("CZK", "203", 2, "Kč", "Czech Koruna");
            }
        }

        /// <summary>Djibouti Franc</summary>
        public static Currency DJF
        {
            get
            {
                return new Currency("DJF", "262", 0, "₣", "Djibouti Franc");
            }
        }

        /// <summary>Danish Krone</summary>
        public static Currency DKK
        {
            get
            {
                return new Currency("DKK", "208", 2, "kr", "Danish Krone");
            }
        }

        /// <summary>Dominican Peso</summary>
        public static Currency DOP
        {
            get
            {
                return new Currency("DOP", "214", 2, "$", "Dominican Peso");
            }
        }

        /// <summary>Algerian Dinar</summary>
        public static Currency DZD
        {
            get
            {
                return new Currency("DZD", "012", 2, "د.ج	", "Algerian Dinar");
            }
        }

        /// <summary>Egyptian Pound</summary>
        public static Currency EGP
        {
            get
            {
                return new Currency("EGP", "818", 2, "£", "Egyptian Pound");
            }
        }

        /// <summary>Nakfa</summary>
        public static Currency ERN
        {
            get
            {
                return new Currency("ERN", "232", 2, "Nfk", "Nakfa");
            }
        }

        /// <summary>Ethiopian Birr</summary>
        public static Currency ETB
        {
            get
            {
                return new Currency("ETB", "230", 2, "", "Ethiopian Birr");
            }
        }

        /// <summary>Euro</summary>
        public static Currency EUR
        {
            get
            {
                return new Currency("EUR", "978", 2, "€", "Euro");
            }
        }

        /// <summary>Fiji Dollar</summary>
        public static Currency FJD
        {
            get
            {
                return new Currency("FJD", "242", 2, "$", "Fiji Dollar");
            }
        }

        /// <summary>Falkland Islands Pound</summary>
        public static Currency FKP
        {
            get
            {
                return new Currency("FKP", "238", 2, "£", "Falkland Islands Pound");
            }
        }

        /// <summary>Pound Sterling</summary>
        public static Currency GBP
        {
            get
            {
                return new Currency("GBP", "826", 2, "£", "Pound Sterling");
            }
        }

        /// <summary>Lari</summary>
        public static Currency GEL
        {
            get
            {
                return new Currency("GEL", "981", 2, "ლ", "Lari");
            }
        }

        /// <summary>Ghana Cedi</summary>
        public static Currency GHS
        {
            get
            {
                return new Currency("GHS", "936", 2, "₵", "Ghana Cedi");
            }
        }

        /// <summary>Gibraltar Pound</summary>
        public static Currency GIP
        {
            get
            {
                return new Currency("GIP", "292", 2, "£", "Gibraltar Pound");
            }
        }

        /// <summary>Dalasi</summary>
        public static Currency GMD
        {
            get
            {
                return new Currency("GMD", "270", 2, "D", "Dalasi");
            }
        }

        /// <summary>Guinea Franc</summary>
        public static Currency GNF
        {
            get
            {
                return new Currency("GNF", "324", 0, "₣", "Guinea Franc");
            }
        }

        /// <summary>Quetzal</summary>
        public static Currency GTQ
        {
            get
            {
                return new Currency("GTQ", "320", 2, "Q", "Quetzal");
            }
        }

        /// <summary>Guyana Dollar</summary>
        public static Currency GYD
        {
            get
            {
                return new Currency("GYD", "328", 2, "$", "Guyana Dollar");
            }
        }

        /// <summary>Hong Kong Dollar</summary>
        public static Currency HKD
        {
            get
            {
                return new Currency("HKD", "344", 2, "$", "Hong Kong Dollar");
            }
        }

        /// <summary>Lempira</summary>
        public static Currency HNL
        {
            get
            {
                return new Currency("HNL", "340", 2, "L", "Lempira");
            }
        }

        /// <summary>Kuna</summary>
        public static Currency HRK
        {
            get
            {
                return new Currency("HRK", "191", 2, "Kn", "Kuna");
            }
        }

        /// <summary>Gourde</summary>
        public static Currency HTG
        {
            get
            {
                return new Currency("HTG", "332", 2, "G", "Gourde");
            }
        }

        /// <summary>Forint</summary>
        public static Currency HUF
        {
            get
            {
                return new Currency("HUF", "348", 2, "Ft", "Forint");
            }
        }

        /// <summary>Rupiah</summary>
        public static Currency IDR
        {
            get
            {
                return new Currency("IDR", "360", 2, "Rp", "Rupiah");
            }
        }

        /// <summary>New Israeli Sheqel</summary>
        public static Currency ILS
        {
            get
            {
                return new Currency("ILS", "376", 2, "₪", "New Israeli Sheqel");
            }
        }

        /// <summary>Indian Rupee</summary>
        public static Currency INR
        {
            get
            {
                return new Currency("INR", "356", 2, "₹", "Indian Rupee");
            }
        }

        /// <summary>Iraqi Dinar</summary>
        public static Currency IQD
        {
            get
            {
                return new Currency("IQD", "368", 3, "ع.د", "Iraqi Dinar");
            }
        }

        /// <summary>Iranian Rial</summary>
        public static Currency IRR
        {
            get
            {
                return new Currency("IRR", "364", 2, "	﷼", "Iranian Rial");
            }
        }

        /// <summary>Iceland Krona</summary>
        public static Currency ISK
        {
            get
            {
                return new Currency("ISK", "352", 0, "Kr", "Iceland Krona");
            }
        }

        /// <summary>Jamaican Dollar</summary>
        public static Currency JMD
        {
            get
            {
                return new Currency("JMD", "388", 2, "$", "Jamaican Dollar");
            }
        }

        /// <summary>Jordanian Dinar</summary>
        public static Currency JOD
        {
            get
            {
                return new Currency("JOD", "400", 3, "	د.ا", "Jordanian Dinar");
            }
        }

        /// <summary>Yen</summary>
        public static Currency JPY
        {
            get
            {
                return new Currency("JPY", "392", 0, "¥", "Yen");
            }
        }

        /// <summary>Kenyan Shilling</summary>
        public static Currency KES
        {
            get
            {
                return new Currency("KES", "404", 2, "Sh", "Kenyan Shilling");
            }
        }

        /// <summary>Som</summary>
        public static Currency KGS
        {
            get
            {
                return new Currency("KGS", "417", 2, "", "Som");
            }
        }

        /// <summary>Riel</summary>
        public static Currency KHR
        {
            get
            {
                return new Currency("KHR", "116", 2, "៛", "Riel");
            }
        }

        /// <summary>Comoro Franc</summary>
        public static Currency KMF
        {
            get
            {
                return new Currency("KMF", "174", 0, null, "Comoro Franc");
            }
        }

        /// <summary>North Korean Won</summary>
        public static Currency KPW
        {
            get
            {
                return new Currency("KPW", "408", 2, "₩	", "North Korean Won");
            }
        }

        /// <summary>Won</summary>
        public static Currency KRW
        {
            get
            {
                return new Currency("KRW", "410", 0, "₩	", "Won");
            }
        }

        /// <summary>Kuwaiti Dinar</summary>
        public static Currency KWD
        {
            get
            {
                return new Currency("KWD", "414", 3, "	د.ك", "Kuwaiti Dinar");
            }
        }

        /// <summary>Cayman Islands Dollar</summary>
        public static Currency KYD
        {
            get
            {
                return new Currency("KYD", "136", 2, "$", "Cayman Islands Dollar");
            }
        }

        /// <summary>Tenge</summary>
        public static Currency KZT
        {
            get
            {
                return new Currency("KZT", "398", 2, "〒", "Tenge");
            }
        }

        /// <summary>Kip</summary>
        public static Currency LAK
        {
            get
            {
                return new Currency("LAK", "418", 2, "₭", "Kip");
            }
        }

        /// <summary>Lebanese Pound</summary>
        public static Currency LBP
        {
            get
            {
                return new Currency("LBP", "422", 2, "	ل.ل", "Lebanese Pound");
            }
        }

        /// <summary>Sri Lanka Rupee</summary>
        public static Currency LKR
        {
            get
            {
                return new Currency("LKR", "144", 2, "Rs", "Sri Lanka Rupee");
            }
        }

        /// <summary>Liberian Dollar</summary>
        public static Currency LRD
        {
            get
            {
                return new Currency("LRD", "430", 2, "$", "Liberian Dollar");
            }
        }

        /// <summary>Loti</summary>
        public static Currency LSL
        {
            get
            {
                return new Currency("LSL", "426", 2, "L", "Loti");
            }
        }

        /// <summary>Libyan Dinar</summary>
        public static Currency LYD
        {
            get
            {
                return new Currency("LYD", "434", 3, "	ل.د", "Libyan Dinar");
            }
        }

        /// <summary>Moroccan Dirham</summary>
        public static Currency MAD
        {
            get
            {
                return new Currency("MAD", "504", 2, "د.م.", "Moroccan Dirham");
            }
        }

        /// <summary>Moldovan Leu</summary>
        public static Currency MDL
        {
            get
            {
                return new Currency("MDL", "498", 2, "L", "Moldovan Leu");
            }
        }

        /// <summary>Malagasy Ariary</summary>
        public static Currency MGA
        {
            get
            {
                return new Currency("MGA", "969", 2, "", "Malagasy Ariary");
            }
        }

        /// <summary>Denar</summary>
        public static Currency MKD
        {
            get
            {
                return new Currency("MKD", "807", 2, "ден", "Denar");
            }
        }

        /// <summary>Kyat</summary>
        public static Currency MMK
        {
            get
            {
                return new Currency("MMK", "104", 2, "MMK", "Kyat");
            }
        }

        /// <summary>Tugrik</summary>
        public static Currency MNT
        {
            get
            {
                return new Currency("MNT", "496", 2, "₮	", "Tugrik");
            }
        }

        /// <summary>Pataca</summary>
        public static Currency MOP
        {
            get
            {
                return new Currency("MOP", "446", 2, "P", "Pataca");
            }
        }

        /// <summary>Ouguiya</summary>
        public static Currency MRO
        {
            get
            {
                return new Currency("MRO", "478", 2, "UM", "Ouguiya");
            }
        }

        /// <summary>Mauritius Rupee</summary>
        public static Currency MUR
        {
            get
            {
                return new Currency("MUR", "480", 2, "Rs", "Mauritius Rupee");
            }
        }

        /// <summary>Rufiyaa</summary>
        public static Currency MVR
        {
            get
            {
                return new Currency("MVR", "462", 2, "ރ.	", "Rufiyaa");
            }
        }

        /// <summary>Malawi Kwacha</summary>
        public static Currency MWK
        {
            get
            {
                return new Currency("MWK", "454", 2, "MK", "Malawi Kwacha");
            }
        }

        /// <summary>Mexican Peso</summary>
        public static Currency MXN
        {
            get
            {
                return new Currency("MXN", "484", 2, "$", "Mexican Peso");
            }
        }

        /// <summary>Mexican Unidad de Inversion (UDI)</summary>
        public static Currency MXV
        {
            get
            {
                return new Currency("MXV", "979", 2, null, "Mexican Unidad de Inversion (UDI)");
            }
        }

        /// <summary>Malaysian Ringgit</summary>
        public static Currency MYR
        {
            get
            {
                return new Currency("MYR", "458", 2, "RM", "Malaysian Ringgit");
            }
        }

        /// <summary>Mozambique Metical</summary>
        public static Currency MZN
        {
            get
            {
                return new Currency("MZN", "943", 2, "MTn	", "Mozambique Metical");
            }
        }

        /// <summary>Namibia Dollar</summary>
        public static Currency NAD
        {
            get
            {
                return new Currency("NAD", "516", 2, "$", "Namibia Dollar");
            }
        }

        /// <summary>Naira</summary>
        public static Currency NGN
        {
            get
            {
                return new Currency("NGN", "566", 2, "₦", "Naira");
            }
        }

        /// <summary>Cordoba Oro</summary>
        public static Currency NIO
        {
            get
            {
                return new Currency("NIO", "558", 2, "C$", "Cordoba Oro");
            }
        }

        /// <summary>Norwegian Krone</summary>
        public static Currency NOK
        {
            get
            {
                return new Currency("NOK", "578", 2, "kr", "Norwegian Krone");
            }
        }

        /// <summary>Nepalese Rupee</summary>
        public static Currency NPR
        {
            get
            {
                return new Currency("NPR", "524", 2, "₨", "Nepalese Rupee");
            }
        }

        /// <summary>New Zealand Dollar</summary>
        public static Currency NZD
        {
            get
            {
                return new Currency("NZD", "554", 2, "$", "New Zealand Dollar");
            }
        }

        /// <summary>Rial Omani</summary>
        public static Currency OMR
        {
            get
            {
                return new Currency("OMR", "512", 3, "ر.ع.	", "Rial Omani");
            }
        }

        /// <summary>Balboa</summary>
        public static Currency PAB
        {
            get
            {
                return new Currency("PAB", "590", 2, "B/.", "Balboa");
            }
        }

        /// <summary>Sol</summary>
        public static Currency PEN
        {
            get
            {
                return new Currency("PEN", "604", 2, "S/.", "Sol");
            }
        }

        /// <summary>Kina</summary>
        public static Currency PGK
        {
            get
            {
                return new Currency("PGK", "598", 2, "K", "Kina");
            }
        }

        /// <summary>Philippine Peso</summary>
        public static Currency PHP
        {
            get
            {
                return new Currency("PHP", "608", 2, "₱", "Philippine Peso");
            }
        }

        /// <summary>Pakistan Rupee</summary>
        public static Currency PKR
        {
            get
            {
                return new Currency("PKR", "586", 2, "₨", "Pakistan Rupee");
            }
        }

        /// <summary>Zloty</summary>
        public static Currency PLN
        {
            get
            {
                return new Currency("PLN", "985", 2, "zł", "Zloty");
            }
        }

        /// <summary>Guarani</summary>
        public static Currency PYG
        {
            get
            {
                return new Currency("PYG", "600", 0, "₲	", "Guarani");
            }
        }

        /// <summary>Qatari Rial</summary>
        public static Currency QAR
        {
            get
            {
                return new Currency("QAR", "634", 2, "ر.ق	", "Qatari Rial");
            }
        }

        /// <summary>Romanian Leu</summary>
        public static Currency RON
        {
            get
            {
                return new Currency("RON", "946", 2, "L", "Romanian Leu");
            }
        }

        /// <summary>Serbian Dinar</summary>
        public static Currency RSD
        {
            get
            {
                return new Currency("RSD", "941", 2, "din", "Serbian Dinar");
            }
        }

        /// <summary>Russian Ruble</summary>
        public static Currency RUB
        {
            get
            {
                return new Currency("RUB", "643", 2, "р.", "Russian Ruble");
            }
        }

        /// <summary>Rwanda Franc</summary>
        public static Currency RWF
        {
            get
            {
                return new Currency("RWF", "646", 0, "₣", "Rwanda Franc");
            }
        }

        /// <summary>Saudi Riyal</summary>
        public static Currency SAR
        {
            get
            {
                return new Currency("SAR", "682", 2, "ر.س	", "Saudi Riyal");
            }
        }

        /// <summary>Solomon Islands Dollar</summary>
        public static Currency SBD
        {
            get
            {
                return new Currency("SBD", "090", 2, "$", "Solomon Islands Dollar");
            }
        }

        /// <summary>Seychelles Rupee</summary>
        public static Currency SCR
        {
            get
            {
                return new Currency("SCR", "690", 2, "₨", "Seychelles Rupee");
            }
        }

        /// <summary>Sudanese Pound</summary>
        public static Currency SDG
        {
            get
            {
                return new Currency("SDG", "938", 2, "£", "Sudanese Pound");
            }
        }

        /// <summary>Swedish Krona</summary>
        public static Currency SEK
        {
            get
            {
                return new Currency("SEK", "752", 2, "kr", "Swedish Krona");
            }
        }

        /// <summary>Singapore Dollar</summary>
        public static Currency SGD
        {
            get
            {
                return new Currency("SGD", "702", 2, "$", "Singapore Dollar");
            }
        }

        /// <summary>Saint Helena Pound</summary>
        public static Currency SHP
        {
            get
            {
                return new Currency("SHP", "654", 2, "£", "Saint Helena Pound");
            }
        }

        /// <summary>Leone</summary>
        public static Currency SLL
        {
            get
            {
                return new Currency("SLL", "694", 2, "Le", "Leone");
            }
        }

        /// <summary>Somali Shilling</summary>
        public static Currency SOS
        {
            get
            {
                return new Currency("SOS", "706", 2, "Sh", "Somali Shilling");
            }
        }

        /// <summary>Surinam Dollar</summary>
        public static Currency SRD
        {
            get
            {
                return new Currency("SRD", "968", 2, "$", "Surinam Dollar");
            }
        }

        /// <summary>South Sudanese Pound</summary>
        public static Currency SSP
        {
            get
            {
                return new Currency("SSP", "728", 2, null, "South Sudanese Pound");
            }
        }

        /// <summary>Dobra</summary>
        public static Currency STD
        {
            get
            {
                return new Currency("STD", "678", 2, "Db", "Dobra");
            }
        }

        /// <summary>El Salvador Colon</summary>
        public static Currency SVC
        {
            get
            {
                return new Currency("SVC", "222", 2, "$", "El Salvador Colon");
            }
        }

        /// <summary>Syrian Pound</summary>
        public static Currency SYP
        {
            get
            {
                return new Currency("SYP", "760", 2, "ل.س	", "Syrian Pound");
            }
        }

        /// <summary>Lilangeni</summary>
        public static Currency SZL
        {
            get
            {
                return new Currency("SZL", "748", 2, "L", "Lilangeni");
            }
        }

        /// <summary>Baht</summary>
        public static Currency THB
        {
            get
            {
                return new Currency("THB", "764", 2, "฿	", "Baht");
            }
        }

        /// <summary>Somoni</summary>
        public static Currency TJS
        {
            get
            {
                return new Currency("TJS", "972", 2, "SM", "Somoni");
            }
        }

        /// <summary>Turkmenistan New Manat</summary>
        public static Currency TMT
        {
            get
            {
                return new Currency("TMT", "934", 2, "m", "Turkmenistan New Manat");
            }
        }

        /// <summary>Tunisian Dinar</summary>
        public static Currency TND
        {
            get
            {
                return new Currency("TND", "788", 3, "د.ت	", "Tunisian Dinar");
            }
        }

        /// <summary>Pa’anga</summary>
        public static Currency TOP
        {
            get
            {
                return new Currency("TOP", "776", 2, "T$", "Pa’anga");
            }
        }

        /// <summary>Turkish Lira</summary>
        public static Currency TRY
        {
            get
            {
                return new Currency("TRY", "949", 2, "₤	", "Turkish Lira");
            }
        }

        /// <summary>Trinidad and Tobago Dollar</summary>
        public static Currency TTD
        {
            get
            {
                return new Currency("TTD", "780", 2, "$", "Trinidad and Tobago Dollar");
            }
        }

        /// <summary>New Taiwan Dollar</summary>
        public static Currency TWD
        {
            get
            {
                return new Currency("TWD", "901", 2, "$", "New Taiwan Dollar");
            }
        }

        /// <summary>Tanzanian Shilling</summary>
        public static Currency TZS
        {
            get
            {
                return new Currency("TZS", "834", 2, "Sh", "Tanzanian Shilling");
            }
        }

        /// <summary>Hryvnia</summary>
        public static Currency UAH
        {
            get
            {
                return new Currency("UAH", "980", 2, "₴	", "Hryvnia");
            }
        }

        /// <summary>Uganda Shilling</summary>
        public static Currency UGX
        {
            get
            {
                return new Currency("UGX", "800", 0, "Sh", "Uganda Shilling");
            }
        }

        /// <summary>US Dollar</summary>
        public static Currency USD
        {
            get
            {
                return new Currency("USD", "840", 2, "$", "US Dollar");
            }
        }

        /// <summary>US Dollar (Next day)</summary>
        public static Currency USN
        {
            get
            {
                return new Currency("USN", "997", 2, "$", "US Dollar (Next day)");
            }
        }

        /// <summary>Uruguay Peso en Unidades Indexadas (URUIURUI)</summary>
        public static Currency UYI
        {
            get
            {
                return new Currency("UYI", "940", 0, null, "Uruguay Peso en Unidades Indexadas (URUIURUI)");
            }
        }

        /// <summary>Peso Uruguayo</summary>
        public static Currency UYU
        {
            get
            {
                return new Currency("UYU", "858", 2, "$", "Peso Uruguayo");
            }
        }

        /// <summary>Uzbekistan Sum</summary>
        public static Currency UZS
        {
            get
            {
                return new Currency("UZS", "860", 2, "", "Uzbekistan Sum");
            }
        }

        /// <summary>Bolívar</summary>
        public static Currency VEF
        {
            get
            {
                return new Currency("VEF", "937", 2, "Bs F", "Bolívar");
            }
        }

        /// <summary>Dong</summary>
        public static Currency VND
        {
            get
            {
                return new Currency("VND", "704", 0, "₫	", "Dong");
            }
        }

        /// <summary>Vatu</summary>
        public static Currency VUV
        {
            get
            {
                return new Currency("VUV", "548", 0, "Vt", "Vatu");
            }
        }

        /// <summary>Tala</summary>
        public static Currency WST
        {
            get
            {
                return new Currency("WST", "882", 2, "WST", "Tala");
            }
        }

        /// <summary>CFA Franc BEAC</summary>
        public static Currency XAF
        {
            get
            {
                return new Currency("XAF", "950", 0, "₣", "CFA Franc BEAC");
            }
        }

        /// <summary>Silver</summary>
        public static Currency XAG
        {
            get
            {
                return new Currency("XAG", "961", 0, null, "Silver");
            }
        }

        /// <summary>Gold</summary>
        public static Currency XAU
        {
            get
            {
                return new Currency("XAU", "959", 0, null, "Gold");
            }
        }

        /// <summary>Bond Markets Unit European Composite Unit (EURCO)</summary>
        public static Currency XBA
        {
            get
            {
                return new Currency("XBA", "955", 0, null, "Bond Markets Unit European Composite Unit (EURCO)");
            }
        }

        /// <summary>Bond Markets Unit European Monetary Unit (E.M.U.-6)</summary>
        public static Currency XBB
        {
            get
            {
                return new Currency("XBB", "956", 0, null, "Bond Markets Unit European Monetary Unit (E.M.U.-6)");
            }
        }

        /// <summary>Bond Markets Unit European Unit of Account 9 (E.U.A.-9)</summary>
        public static Currency XBC
        {
            get
            {
                return new Currency("XBC", "957", 0, null, "Bond Markets Unit European Unit of Account 9 (E.U.A.-9)");
            }
        }

        /// <summary>Bond Markets Unit European Unit of Account 17 (E.U.A.-17)</summary>
        public static Currency XBD
        {
            get
            {
                return new Currency("XBD", "958", 0, null, "Bond Markets Unit European Unit of Account 17 (E.U.A.-17)");
            }
        }

        /// <summary>East Caribbean Dollar</summary>
        public static Currency XCD
        {
            get
            {
                return new Currency("XCD", "951", 2, "$", "East Caribbean Dollar");
            }
        }

        /// <summary>SDR (Special Drawing Right)</summary>
        public static Currency XDR
        {
            get
            {
                return new Currency("XDR", "960", 0, null, "SDR (Special Drawing Right)");
            }
        }

        /// <summary>CFA Franc BCEAO</summary>
        public static Currency XOF
        {
            get
            {
                return new Currency("XOF", "952", 0, null, "CFA Franc BCEAO");
            }
        }

        /// <summary>Palladium</summary>
        public static Currency XPD
        {
            get
            {
                return new Currency("XPD", "964", 0, null, "Palladium");
            }
        }

        /// <summary>CFP Franc</summary>
        public static Currency XPF
        {
            get
            {
                return new Currency("XPF", "953", 0, "₣", "CFP Franc");
            }
        }

        /// <summary>Platinum</summary>
        public static Currency XPT
        {
            get
            {
                return new Currency("XPT", "962", 0, null, "Platinum");
            }
        }

        /// <summary>Sucre</summary>
        public static Currency XSU
        {
            get
            {
                return new Currency("XSU", "994", 0, null, "Sucre");
            }
        }

        /// <summary>Codes specifically reserved for testing purposes</summary>
        public static Currency XTS
        {
            get
            {
                return new Currency("XTS", "963", 0, null, "Codes specifically reserved for testing purposes");
            }
        }

        /// <summary>ADB Unit of Account</summary>
        public static Currency XUA
        {
            get
            {
                return new Currency("XUA", "965", 0, null, "ADB Unit of Account");
            }
        }

        /// <summary>The codes assigned for transactions where no currency is involved</summary>
        public static Currency XXX
        {
            get
            {
                return new Currency("XXX", "999", 0, "", "The codes assigned for transactions where no currency is involved");
            }
        }

        /// <summary>Yemeni Rial</summary>
        public static Currency YER
        {
            get
            {
                return new Currency("YER", "886", 2, "﷼	", "Yemeni Rial");
            }
        }

        /// <summary>Rand</summary>
        public static Currency ZAR
        {
            get
            {
                return new Currency("ZAR", "710", 2, "R", "Rand");
            }
        }

        /// <summary>Zambian Kwacha</summary>
        public static Currency ZMW
        {
            get
            {
                return new Currency("ZMW", "967", 2, "ZK", "Zambian Kwacha");
            }
        }

        /// <summary>Zimbabwe Dollar</summary>
        public static Currency ZWL
        {
            get
            {
                return new Currency("ZWL", "932", 2, "$", "Zimbabwe Dollar");
            }
        }
    }
}