using System;

namespace Qkmaxware.Units.AngularVelocity {

/// <summary>
/// Static class housing conversions for all geometric angles
/// </summary>
public static class AngularVelocityConversions {

    private static double Rad2Deg = 180 / Math.PI;
    private static double Deg2Rad = Math.PI / 180;

    /// <summary>
    /// Extension method to convert degrees to radians
    /// </summary>
    /// <param name="val">quantity measured in degrees</param>
    /// <returns>quantity measured in radians</returns>
    public static Quantity<double, RadiansPerSecond> ToRadians<T>(this BaseQuantity<T, DegreesPerSecond> val) where T:IConvertible {
        return new Quantity<double, RadiansPerSecond>(
            Convert.ToDouble(val.Value) * Deg2Rad
        );
    }

    /// <summary>
    /// Extension method to convert radians to degrees
    /// </summary>
    /// <param name="val">quantity measured in radians</param>
    /// <returns>quantity measured in degrees</returns>
    public static Quantity<double, DegreesPerSecond> ToDegrees<T>(this BaseQuantity<T, RadiansPerSecond> val) where T:IConvertible {
        return new Quantity<double, DegreesPerSecond>(
            Convert.ToDouble(val.Value) * Rad2Deg
        );
    }

}

}