using System;

namespace System.Units.Angle {

public static class AngleConversions {

    private static double Rad2Deg = 180 / Math.PI;
    private static double Deg2Rad = Math.PI / 180;

    /// <summary>
    /// Extension method to convert degrees to radians
    /// </summary>
    /// <param name="val">quantity measured in degrees</param>
    /// <returns>quantity measured in radians</returns>
    public static Quantity<double, Radians> ToRadians<T>(this Quantity<T, Degrees> val) where T:IConvertible {
        return new Quantity<double, Radians>(
            Convert.ToDouble(val.Value) * Deg2Rad
        );
    }

    /// <summary>
    /// Extension method to convert radians to degrees
    /// </summary>
    /// <param name="val">quantity measured in radians</param>
    /// <returns>quantity measured in degrees</returns>
    public static Quantity<double, Degrees> ToDegrees<T>(this Quantity<T, Radians> val) where T:IConvertible {
        return new Quantity<double, Degrees>(
            Convert.ToDouble(val.Value) * Rad2Deg
        );
    }

}

}