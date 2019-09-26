using System.Units;
using System.Units.Length;

namespace System.Units.Examples {

/// <summary>
/// This example shows how pre-defined unit conversions work
/// </summary>
public class Example2 {

    public static void Main (string[] args) {
        var x = 12.45.m(); // Value in metres
        Console.WriteLine(x);

        // Some conversion functions are pre-defined for ease of use
        DoIt(x.ToKilometre());
    }

    public static void DoIt(Quantity<double, Kilometre> km) {
        Console.WriteLine(km);
    }

}

}