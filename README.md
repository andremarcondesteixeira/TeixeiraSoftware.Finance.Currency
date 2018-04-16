[![TeixeiraSoftware.Finance.Currency](https://github.com/TeixeiraSoftware/assets/raw/master/logo_small.png)](https://TeixeiraSoftware.github.io/TeixeiraSoftware.Finance.Currency/)

# TeixeiraSoftware.Finance.Currency

[![Build status](https://ci.appveyor.com/api/projects/status/3o49qv68nskk7cnj?svg=true)](https://ci.appveyor.com/project/TeixeiraSoftware/teixeirasoftware-finance-currency)
[![license](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/TeixeiraSoftware/TeixeiraSoftware.Finance.Currency/blob/master/LICENSE)
[![Pull Requests](https://img.shields.io/badge/Pull%20Requests-Welcome-brightgreen.svg)](https://github.com/TeixeiraSoftware/TeixeiraSoftware.Finance.Currency/blob/master/CONTRIBUTING.md)
[![NuGet](https://img.shields.io/nuget/dt/TeixeiraSoftware.Finance.Currency.svg)](https://www.nuget.org/packages/TeixeiraSoftware.Finance.Currency/)

A simple cross platform currency class library for .Net, that follows the ISO 4217 standard.

The implementation of this library is compatible with .Net Standard 2.0 (see [https://docs.microsoft.com/en-us/dotnet/standard/net-standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) for details).

This package depends on `TeixeiraSoftware.Finance.Money`. `Currency` is a value type (a struct).

## Usage
You can get a currency instance by three different ways:

* Calling a factory property, where XXX is the three letters ISO code of the currency:
``` c#
var currency = Currency.XXX;
```

* Using the ByAlphabeticCode method, where, again, XXX is the three letters ISO code of the currency:
``` c#
var currency = Currency.ByAlphabeticCode("XXX");
```

* Using the ByNumericCode method, where 999 is the three numbers ISO code of the currency:
``` c#
// Note that the numeric code is a string
var currency = Currency.ByNumericCode("999");
```

### Properties
The Currency struct have five read only properties:
``` c#
public partial struct Currency : ICurrency, IComparable, IComparable<ICurrency>
{
    // The alphabetic ISO code of the currency
    // This property is always the same as AlphabeticCode
    public string Symbol { get; }

    // The name of the currency
    public string Name { get; }

    // The alphabetic ISO code of the currency
    // This property is always the same as Symbol
    public string AlphabeticCode {
        get {
            return Symbol;
        }
    }

    // The ISO numeric code of the currency
    public string NumericCode { get; }

    // The minor units of the currency
    public byte MinorUnits { get; }
}
```

### Comparing currencies
The available comparison operators are `==` and `!=`.
The `.Equals` method is also available.
``` c#
// returns true
var areCurrenciesEquivalent = (Currency.XXX == Currency.XXX);

// returns false
var areCurrenciesEquivalent = (Currency.XXX != Currency.XXX);
```

### Listing all the currencies
You can use the `Currency.AllCurrencies` property to get a list of all the currencies:
``` c#
var allCurrencies = Currency.AllCurrencies;

foreach (var currency in allCurrencies)
{
    var currencyName = currency.Name;
    var currencyISOAlphabeticCode = currency.AlphabeticCode;
    var currencyISONumericCode = currency.NumericCode;
    var currencyMinorUnits = currency.MinorUnits;
}
```

## Contributing
You can see some topics that you can help with in the [issues section](https://github.com/TeixeiraSoftware/TeixeiraSoftware.Finance.Currency/issues) of the project.
You can also contribute by doing unit tests, writing documentation, making pull requests or sharing the project.
