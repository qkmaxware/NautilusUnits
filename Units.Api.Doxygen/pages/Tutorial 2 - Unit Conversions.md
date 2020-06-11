# Tutorial 2 - Unit Conversions
## Introduction
For this tutorial we will cover conversions between different units, some of which are already implemented within the Nautilus framework. In this project,

## Project Set-Up
We will be following the same project set-up as in the first tutorial with a new .Net 3.0 console application which references the Nautilus Units library. 

## Principle
Often values are represented with units that are more convenient to visualize but need to be in standardized units in order to be used with particular formula. 

## Some Code
Nautilus contains many pre-defined conversion functions which can be called with any measured quantity which extends C#'s [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible) interface. This is because conversion factors are usually decimal numbers and C# has no way to generalize addition, subtraction, multiplication, and division between arbitrary classes and decimal values. For all cases where the type does implement [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible) all pre-defined conversion functions will be attached as extension methods and can be used as if they were class member.  

```cs
var grams = 12.g();
var kilograms = grams.ToKiloGrams();

Console.WriteLine(grams);          // Prints "12g"
Console.WriteLine(kilograms);      // Prints "0.012kg"
```

For all [SI](https://en.wikipedia.org/wiki/International_System_of_Units) units, conversion factors exist within Nautilus for each of the SI-prefixes. 

```cs
var mass = 1.g();

mass.ToYottaGram();
mass.ToZettaGram();
mass.ToExaGram();
mass.ToPetaGram();
mass.ToTeraGram();
mass.ToGigaGram();
mass.ToMegaGram();
mass.ToKiloGram();
mass.ToHectoGram();
mass.ToDekaGram();
mass.ToDeciGram();
mass.ToCentiGram();
mass.ToMilliGram();
mass.ToMicroGram();
mass.ToNanoGram();
mass.ToPicoGram();
mass.ToFemtoGram();
mass.ToAttoGram();
mass.ToZeptoGram();
mass.ToYoctoGram();
```

For non-SI units, such as those found in the imperial system some but not all conversion factors will be implemented. Additionally, for units from systems like imperial, there may not be conversions from the imperial units to the equivalent SI units. 

You can create your own custom conversion functions in many ways. The simplest way is to create a function that takes in the quantity you want to convert from and returns a new quantity in the new units of measure. You should reference the stored value with a quantity's `Value` property and multiply that by the required conversion factor.

```cs
using Qkmaxware.Units.Acceleration;

public static class G_Convert {

    public static Quantity<double, G> ToG(Quantity<double, MetrePerSecondSq> val)  {
        return new Quantity<double, G>(
            val.Value / 9.80665
        );
    }

}
```

However, the preferred way to create conversion functions within Nautilus' framework is to create extension methods that use generics implementing [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible). This allows the extension methods to be easy to use and allow them to work for a wide variety of value types such as integer, float, or double.  

```cs
using Qkmaxware.Units.Acceleration;

public static class G_Convert {

    // Being a generic will allow this conversion to be used with any type that can be cast to a double
    public static Quantity<double, G> ToG<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, G>(
            Convert.ToDouble(val.Value) / 9.80665
        );
    }

}
```