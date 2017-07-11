# Currency
A simple and cross platform currency class library that follows the ISO 4217 standard.
Currency is a value type, i.e, a struct, with no public constructor, but simple, quick methods that return you the currency instance you want instead.

### Usage
First, you need to import the class:

``` c#
    using AndreMarcondesTeixeira;`
```

Then, you can get a currency instance by three ways:

1. Calling a factory property, where XXX is the three letters ISO code of the currency:

``` c#
var currency = Currency.XXX;
```

2. Using the method GetByLetterCode, where, again, XXX is the three letters ISO code of the currency:

``` c#
var currency = Currency.GetByLetterCode("XXX");
```

3. Using the method GetByNumericCode, where 999 is the three numbers ISO code of the currency:

``` c#
var currency = Currency.GetByNumericCode("999"); //(Note that the numeric code is a string)
```