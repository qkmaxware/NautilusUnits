using System.Units;
using System.Units.Length;
using System.Units.Time;

namespace System.Units.Examples {

/// <summary>
/// This example shows how to create custom units 
/// </summary>
public class Example3 {

    public static void Main (string[] args) {
        var speed   = 12.0.m_s();
        var time    = 5.0.s();

        var dist = Distance(speed, time);

        // An object travelling at {12m/s} will have moved {60m} in {5s}.
        Console.WriteLine(
            String.Format("An object travelling at {0} will have moved {2} in {1}."),
            speed, time, dist
        );
    }

    /// <summary>
    /// Distance (m) = Speed (m/s) * Time (s)
    /// </summary>
    /// <param name="speed">Speed in Metres/Second</param>
    /// <param name="time">Time in Seconds</param>
    /// <returns>Distance in Metres</returns>
    public static Quantity<double, Metre> Distance(Quantity<double, M_S> speed, Quantity<double, Second> time) {
        return (speed.Value * time.Value).As<double, Metre>();
    }

}

// New unit definition
public struct M_S : IUnit {
    public static string Name => "Metres Per Second";
    public static string Symbol => "m/s";
}

// Extension method to make constructing objects of this utility easy (optional)
public static class M_SUtils {
    public static Quantity<T, M_S> m_s<T> (this T value) {
        return value.As<T, M_S>();
    }
}

}