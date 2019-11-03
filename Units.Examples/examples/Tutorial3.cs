using System;
using System.Units; 

namespace Tutorials.Tutorial3 {

    public struct PartsPerMillion : IUnit {
        public static string Name => "Parts/Million";
        public static string Symbol => "ppm";
    }

    public static class PartsPerMillionFactory {
        public static Quantity<ValueType, PartsPerMillion> ppm<ValueType>(this ValueType value) {
            return new Quantity<ValueType, PartsPerMillion> (value);
        }
    }

    public class Program {
        public static void Run() {
            var concentration = 12.ppm();

            Console.WriteLine(concentration); // prints 12ppm
        }
    }
}