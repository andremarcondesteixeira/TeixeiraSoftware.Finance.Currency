[![CURRENCY](https://github.com/TeixeiraSoftware/Currency/raw/master/currency-logo.png)](https://TeixeiraSoftware.github.io/Currency/)

# TeixeiraSoftware.Finance.Currency [![Tweet](https://img.shields.io/twitter/url/http/shields.io.svg?style=social)](https://twitter.com/intent/tweet?text=A%20simple%20currency%20class%20library&url=https://TeixeiraSoftware.github.io/Currency/&hashtags=currency,money,finance,software,dotnet,simplicity,crossplatform)
[![Build status](https://ci.appveyor.com/api/projects/status/ff4jg5689m7ify1q?svg=true)](https://ci.appveyor.com/project/TeixeiraSoftware/Currency)
[![license](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/TeixeiraSoftware/Currency/blob/master/LICENSE)
[![Pull Requests](https://img.shields.io/badge/Pull%20Requests-Welcome-brightgreen.svg)](https://github.com/TeixeiraSoftware/Currency/blob/master/CONTRIBUTING.md)
[![NuGet](https://img.shields.io/nuget/dt/currency.svg)](https://www.nuget.org/packages/TeixeiraSoftware.Finance.Currency/)

A simple cross platform currency class library for .Net, that follows the ISO 4217 standard.

The implementation of this library is compatible with .Net Standard 2.0 (see [https://docs.microsoft.com/en-us/dotnet/standard/net-standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) for details).

TeixeiraSoftware.Finance.Currency is a value type.

### Installation

Install through NuGet Package Manager:
```
Install-Package TeixeiraSoftware.Finance.Currency
```

### Usage
First of all, import the namespace, for convenience:
``` c#
using TeixeiraSoftware.Finance;
```

Then, you can get a currency instance by using one of these methods:

* Calling a factory property, where XXX is the three letters ISO code of the currency:
``` c#
var currency = Currency.XXX;
```

* Using the method GetByLetterCode, where, again, XXX is the three letters ISO code of the currency:
``` c#
var currency = Currency.GetByLetterCode("XXX");
```

* Using the method GetByNumericCode, where 999 is the three numbers ISO code of the currency:
``` c#
// Note that the numeric code is a string
var currency = Currency.GetByNumericCode("999");
```

The Currency class have four read only properties:
``` c#
public struct Currency : IEquatable<Currency>
{
    // The 3 letters ISO code of the currency
    public string LetterCode { get; }

    // The ISO minor units of the currency
    public byte MinorUnits { get; }

    // The ISO name of the currency
    public string Name { get; }

    // The numeric ISO code of the currency
    public string NumericCode { get; }
}
```

You can compare currencies using the operators == and !=
``` c#
// returns true
var areCurrenciesEquivalent = (Currency.XXX == Currency.XXX);

// returns false
var areCurrenciesEquivalent = (Currency.XXX != Currency.XXX);
```

You can get a list of all currencies:
``` c#
var allCurrencies = Currency.AllCurrencies;

foreach (var currency in allCurrencies)
{
    var currencyISOLetterCode = currency.LetterCode;
    var currencyISONumericCode = currency.NumericCode;
    var currencyName = currency.Name;
    var currencyMinorUnits = currency.MinorUnits;
}
```

### Contributing
I'm currently looking for help to improve the project. You can see some topics that you can help with in the [issues section of the project's GitHub page](https://github.com/TeixeiraSoftware/TeixeiraSoftware.Finance.Currency/issues).
You can also contribute by doing unit tests, documentation, making pull requests or sharing the project.
