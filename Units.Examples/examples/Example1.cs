using System.Units;
using System.Units.Length;

namespace System.Units.Examples {

/// <summary>
/// This example shows how to create measured quantities and statically restrict the units allowed in methods
/// </summary>
public class Example1 {

    public static void Run (string[] args) {
        var x = 12.45.As<double, Metre>();  // Manual declaration of a type as a measured quantity
        var y = (-6.24).m();                // Shortcut method to declare a type of a certain unit

        var z = x.Add<double, Metre>(y);

        /*
         12.45m
         + -6.24m
         -----------
         6.21m
         */

        WhatIs(x);
        Console.Write("+ ");
        WhatIs(y);
        Console.WriteLine("-----------");
        WhatIs(z);
    }

    public static void WhatIs(Quantity<double, Metre> length) {
        Console.WriteLine(length);
    }

}

}