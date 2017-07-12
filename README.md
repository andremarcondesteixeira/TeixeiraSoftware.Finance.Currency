# Currency
[![Build status](https://ci.appveyor.com/api/projects/status/ff4jg5689m7ify1q?svg=true)](https://ci.appveyor.com/project/andremarcondesteixeira/currency)

A simple and cross platform currency class library that follows the ISO 4217 standard.

Currency is a value type, i.e, a struct, with no public constructor, but simple, quick methods that return you the currency instance you want instead.

### Installation

Install through NuGet Package Manager:
```
Install-Package currency
```

### Usage
First of all, import the namespace, for convenience:
``` c#
using AndreMarcondesTeixeira;
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
You can contribute by doing unit tests, documentation, making pull requests or sharing the project.
