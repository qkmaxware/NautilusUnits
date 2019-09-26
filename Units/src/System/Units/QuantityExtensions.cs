namespace System.Units {

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
    public static Quantity<T, U> As<T, U> (this T value) where U:IUnit {
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
    public static Quantity<T, U2> Cast<T,U1,U2> (this Quantity<T, U1> quantity) where U1:IUnit where U2:IUnit {
        return new Quantity<T, U2> (quantity.Value);
    }
}

}