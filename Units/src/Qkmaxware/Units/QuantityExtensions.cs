using System;

namespace Qkmaxware.Units {

/// <summary>
/// Extension methods for measured quantities
/// </summary>
public static class QuantityExtensions {
    
    /// <summary>
    /// Create a new measured quantity from any type of object
    /// </summary>
    /// <param name="value">The value measured</param>
    /// <typeparam name="U">The units the value is measured in</typeparam>
    /// <typeparam name="T">The type of the value</typeparam>
    /// <returns></returns>
    public static Quantity<T, U> As<U, T> (this T value) where U:IUnit {
        return new Quantity<T, U>(value);
    } 
    
    /// <summary>
    /// Change the measurement units of a measured quantity
    /// </summary>
    /// <param name="quantity">The measured quantity</param>
    /// <typeparam name="U1">The original type</typeparam>
    /// <typeparam name="U2">The new type</typeparam>
    /// <typeparam name="T">The type of the value</typeparam>
    /// <returns>Quantity in the new units</returns>
    public static Quantity<T, U2> Cast<T,U1,U2> (this BaseQuantity<T, U1> quantity) where U1:IUnit where U2:IUnit {
        return new Quantity<T, U2> (quantity.Value);
    }

    /// <summary>
    /// Write a quantity to string while rounding the quantity to the given number of decimal places
    /// </summary>
    /// <param name="quanta">quantity</param>
    /// <param name="decimals">number of decimals to keep</param>
    /// <returns>string quantity with units</returns>
    public static string ToString<T,U>(this BaseQuantity<T, U> quanta, int decimals) where U:IUnit where T: IConvertible {
        return 
            (quanta.Value != null ? Math.Round(Convert.ToDouble(quanta.Value), decimals).ToString() : string.Empty) + 
            (string)(quanta.Units?.GetProperty("Symbol")?.GetValue(null) ?? string.Empty);
    }
}

}