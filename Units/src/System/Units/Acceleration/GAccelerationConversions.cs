using System;
namespace System.Units.Acceleration {
public static class GAccelerationConversions {

    /// <summary>
    /// Extension method to convert MetrePerSecondSq to G
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in G</returns>
	public static Quantity<double, G> ToG<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, G>(
            Convert.ToDouble(val.Value) / 9.80665
        );
    }

    /// <summary>
    /// Extension method to convert G to MetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in G</param>
    /// <returns>quantity measured in MetrePerSecondSq</returns>
	public static Quantity<double, MetrePerSecondSq> ToMetrePerSecondSq<T>(this Quantity<T, G> val) where T:IConvertible {
        return new Quantity<double, MetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 9.80665
        );
    }

}
}