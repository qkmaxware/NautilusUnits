# Tutorial 3 - Custom Units
## Introduction
In this tutorial, we will cover how to create and use new units of measure which are not included within Nautilus. 

## Project Set-Up
We will be following the same project set-up as in the first two tutorials with a new .Net 3.0 console application which references the Nautilus Units library. 

## Principle
Nautilus only implements a small number of all the possible units of measure and as such there will be cases where the unit you would like to use is not implemented. Luckily it is very easy to create a new unit of measurement within Nautilus. 

## Some Code
All units in Nautilus must implement the `System.Units.IUnit` interface. This interface relies on C# 8 features such as static interface members in order create units of measurement that do not need to be instantiated. 

```cs
using System.Units; 
...
public struct PartsPerMillion : IUnit {
    public static string Name => "Parts/Million";
    public static string Symbol => "ppm";
}
```

It is also often convenient to create an extension method which can be applied to any instance in order to easily create them in an unobtrusive and readable manner. 

```cs
public static class PartsPerMillionFactory {
    // Create quantities of any type measured in parts/million 
    public static Quantity<ValueType, PartsPerMillion> ppm<ValueType>(this ValueType value) {
        return new Quantity<ValueType, PartsPerMillion> (value);
    }
}
```

In Nautilus this extension method is the same name as the unit's symbol to make reading quantities much like one would when writing them on paper.

```cs
public static void Main(string[] args) {
    var concentration = 12.ppm();

    Console.WriteLine(concentration); // prints 12ppm
}
```